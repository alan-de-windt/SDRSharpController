using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO.Ports;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using SDRSharp.Common;
using SDRSharp.Radio;

namespace SDRSharp.SDRSharpController
{
    public partial class ControlPanel : UserControl
    {

        private ISharpControl _control;

        private const string _settingSerialEn = "netRemoteSerialEnable";
        private const string _settingSerialPort = "netRemoteSerialPort";

        private Thread _threadSerial;
        private Serial _serial = null;
        private CustomQueue _queue;

        private int[] _tuning_steps = { 1, 10, 100, 500, 1000, 2500, 3000, 5000, 6250,
            7500, 8333, 9000, 10000, 12500, 15000, 20000, 25000, 30000, 50000, 100000,
            150000, 200000, 250000, 300000, 350000, 400000, 450000, 500000, 1000000 };
        private string[] _modes = { "NFM", "WFM", "AM", "DSB", "LSB", "USB", "CW", "RAW" };

        private object _item;
        private string _data;
        private long _new_frequency = 0;
        private long _frequency_adjustment = 0;
        private int _new_audio_gain = 0;
        private int _audio_gain_adjustment = 0;
        private int _new_squelch_threshold = 0;
        private int _squelch_threshold_adjustment = 0;
        private int _new_zoom = 0;
        private int _zoom_adjustment = 0;
        private int _new_filter_bandwidth = 0;
        private int _filter_bandwidth_adjustment = 0;
        private int _index = 0;

        private long _memory_frequency = 0;
        private int _memory_filter_bandwidth = 0;
        private int _memory_mode = 0;

        private bool _connection_established = false;
        private static System.Timers.Timer aTimer;

        public ControlPanel(ISharpControl control)
        {

            InitializeComponent();

            _control = control;

            checkSerial.Checked = Utils.GetBooleanSetting(_settingSerialEn, false);
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            if (ports.Length > 0)
            {
                comboSerial.Enabled = !checkSerial.Checked;
                comboSerial.Items.AddRange(ports);
                comboSerial.SelectedIndex = 0;
                comboSerial.SelectedItem = Utils.GetStringSetting(_settingSerialPort, "");
            }
            else
            {
                checkSerial.Checked = false;
                checkSerial.Enabled = false;
                comboSerial.Enabled = false;
            }

            SerialControl();

        }

        public void Close()
        {
            Utils.SaveSetting(_settingSerialEn, checkSerial.Checked);
            Utils.SaveSetting(_settingSerialPort, comboSerial.SelectedItem);

            checkSerial.Checked = false;
            SerialControl();
        }

        private void SerialControl()
        {
            if (checkSerial.Checked)
            {
                if (_threadSerial == null)
                {
                    _queue = new CustomQueue();
                    // Using Invoke makes ConsumeQueue run in the UI thread (serializes the call to the UI thread)
                    _queue.ItemInserted += (o, e) => Invoke(new Action(ConsumeQueue));

                    _serial = new Serial(comboSerial.SelectedItem.ToString(), _queue);
                    _serial.SerialError += OnSerialError;

                    _threadSerial = new Thread(new ThreadStart(_serial.Start));
                    _threadSerial.Start();

                    tableLayoutPanel3.Controls.Clear();
                    tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                    labelControl.Text = "Connecting...";

                    aTimer = new System.Timers.Timer(1000);
                    aTimer.Elapsed += CheckConnectionEstablished;
                    aTimer.AutoReset = false;
                    aTimer.Enabled = true;

                }
            }
            else
            {
                if (_threadSerial != null)
                {
                    _serial.Stop();
                    _threadSerial.Join(1000);
                    _threadSerial = null;
                    _queue = null;

                    tableLayoutPanel3.Controls.Clear();
                    tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                    if (_connection_established == true)
                    {
                        labelControl.Text = "Not connected";
                    }
                    else
                    {
                        labelControl.Text = "Not responding!";
                    }

                    _connection_established = false;

                    labelTuningStepValue.Text = "";
                    labelFilterBandwidthValue.Text = "";
                    labelModeValue.Text = "";
                    labelZoomValue.Text = "";
                    labelSquelchThresholdValue.Text = "";

                    aTimer.Stop();
                    aTimer.Dispose();

                }
            }
        }

        private void OnSerialError(object sender, EventArgs e)
        {
            _threadSerial = null;
            checkSerial.Checked = false;
        }


        private void CheckChangedSerial(object sender, EventArgs e)
        {
            comboSerial.Enabled = !checkSerial.Checked;
            SerialControl();
        }

        private void ConsumeQueue()
        {

            while (_queue.Count > 0)
            {
                if (_queue.TryDequeue(out _item))
                {
                    _data = _item.ToString();
                    _data = _data.ToLower();
                    _data = _data.Replace("\r", "");  // Removes carriage return character at end of string
                    string[] command = _data.Split(':');

                    if (_connection_established == false)
                    {
                        if (command[0] == "connection_status" && command[1] == "established")
                        {
                            _connection_established = true;
                            labelControl.Text = "Connected";

                            labelTuningStepValue.Text = _control.StepSize.ToString("0,0", CultureInfo.InvariantCulture);
                            labelFilterBandwidthValue.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                            labelModeValue.Text = _control.DetectorType.ToString();
                            labelZoomValue.Text = _control.Zoom.ToString();
                            labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();

                        }

                    }
                    else
                    {

                        if (command[0] == "show_mode")
                        {
                            labelControl.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(command[1]);
                            switch (command[1])
                            {
                                case "tuning":
                                    if (tableLayoutPanel3.Controls.Contains(labelFrequency) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(labelFrequency, 0, 1);
                                        labelFrequency.Text = _control.Frequency.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "tuning step":
                                    if (tableLayoutPanel3.Controls.Contains(labelTuningStep) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(labelTuningStep, 0, 1);
                                        labelTuningStep.Text = _control.StepSize.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelTuningStepValue.Text = _control.StepSize.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "filter bandwidth":
                                    if (tableLayoutPanel3.Controls.Contains(labelFilterBandwidth) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(labelFilterBandwidth, 0, 1);
                                        labelFilterBandwidth.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelFilterBandwidthValue.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "mode":
                                    if (tableLayoutPanel3.Controls.Contains(labelMode) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(labelMode, 0, 1);
                                        labelMode.Text = _control.DetectorType.ToString();
                                        labelModeValue.Text = _control.DetectorType.ToString();
                                    }
                                    break;

                                case "audio gain":
                                    if (tableLayoutPanel3.Controls.Contains(trackBarAudioGain) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(trackBarAudioGain, 0, 1);
                                        trackBarAudioGain.Value = _control.AudioGain;
                                    }
                                    break;

                                case "zoom":
                                    if (tableLayoutPanel3.Controls.Contains(trackBarZoom) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        tableLayoutPanel3.Controls.Add(trackBarZoom, 0, 1);
                                        trackBarZoom.Value = _control.Zoom;
                                        labelZoomValue.Text = _control.Zoom.ToString();
                                    }
                                    break;

                                case "squelch threshold":
                                    if (tableLayoutPanel3.Controls.Contains(trackBarSquelch) == false)
                                    {
                                        tableLayoutPanel3.Controls.Clear();
                                        tableLayoutPanel3.Controls.Add(labelControl, 0, 0);
                                        if (_control.DetectorType.ToString() == "NFM" ||
                                            _control.DetectorType.ToString() == "WFM" ||
                                            _control.DetectorType.ToString() == "AM")
                                        {
                                            tableLayoutPanel3.Controls.Add(trackBarSquelch, 0, 1);
                                            trackBarSquelch.Value = _control.SquelchThreshold;
                                            labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                        }
                                        else
                                        {
                                            tableLayoutPanel3.Controls.Add(labelNoSquelch, 0, 1);
                                        }
                                    }
                                    break;

                                default:

                                    break;

                            }
                        }
                        else if (command[0] == "memory")
                        {
                            switch (command[1])
                            {
                                case "store":
                                    if (groupBox3.Controls.Contains(labelMemory) == false)
                                    {
                                        groupBox3.Controls.Clear();
                                        groupBox3.Controls.Add(labelMemory);

                                    }
                                    _memory_frequency = _control.Frequency;
                                    _memory_mode = (int)_control.DetectorType;
                                    _memory_filter_bandwidth = _control.FilterBandwidth;
                                    labelMemory.Text = _control.Frequency.ToString("0,0", CultureInfo.InvariantCulture);
                                    break;

                                case "recall":
                                    if (_memory_frequency != 0)
                                    {
                                        _control.Frequency = _memory_frequency;
                                        _control.DetectorType = (DetectorType)_memory_mode;
                                        _control.FilterBandwidth = _memory_filter_bandwidth;
                                        labelFrequency.Text = _control.Frequency.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelFilterBandwidth.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelMode.Text = _control.DetectorType.ToString();
                                    }
                                    break;

                            }
                        }
                        else
                        {
                            switch (command[0])
                            {
                                case "set_tuning":
                                    // Frequency range: 1 to 999999999999
                                    _new_frequency = Convert.ToInt64(command[1]);
                                    if (_new_frequency >= 1 && _new_frequency <= 999999999999)
                                    {
                                        _control.Frequency = _new_frequency;
                                        labelFrequency.Text = _control.Frequency.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "adjust_tuning":
                                    // Frequency range: 1 to 999999999999
                                    _frequency_adjustment = Convert.ToInt64(command[1]) * _control.StepSize;
                                    _new_frequency = _control.Frequency + _frequency_adjustment;
                                    if (_new_frequency < 1)
                                    {
                                        _control.Frequency = 1;
                                    }
                                    else if (_new_frequency > 999999999999)
                                    {
                                        _control.Frequency = 999999999999;
                                    }
                                    else
                                    {
                                        _control.Frequency = _new_frequency;
                                    }
                                    labelFrequency.Text = _control.Frequency.ToString("0,0", CultureInfo.InvariantCulture);
                                    break;

                                case "adjust_tuning_step":
                                    _index = Array.FindIndex(_tuning_steps, FindStep);
                                    if (_index != -1)
                                    {
                                        _index += Convert.ToInt16(command[1]);
                                        if (_index < 0)
                                        {
                                            _index = 0;
                                        }
                                        else if (_index > (_tuning_steps.Length - 1))
                                        {
                                            _index = _tuning_steps.Length - 1;
                                        }
                                        _control.StepSize = _tuning_steps[_index];
                                        labelTuningStep.Text = _control.StepSize.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelTuningStepValue.Text = _control.StepSize.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "adjust_mode":
                                    _index = Array.FindIndex(_modes, FindMode);
                                    if (_index != -1)
                                    {
                                        _index += Convert.ToInt16(command[1]);
                                        if (_index < 0)
                                        {
                                            _index = 0;
                                        }
                                        else if (_index > (_modes.Length - 1))
                                        {
                                            _index = _modes.Length - 1;
                                        }
                                        _control.DetectorType = (DetectorType)_index;
                                        labelMode.Text = _control.DetectorType.ToString();
                                        labelModeValue.Text = _control.DetectorType.ToString();
                                        labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                        labelFilterBandwidthValue.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "set_audio_gain":
                                    // Audio Gain range: -60 to 20
                                    _new_audio_gain = Convert.ToInt16(command[1]);
                                    if (_new_audio_gain >= -60 && _new_audio_gain <= 20)
                                    {
                                        _control.AudioGain = _new_audio_gain;
                                        trackBarAudioGain.Value = _control.AudioGain;
                                    }
                                    break;

                                case "adjust_audio_gain":
                                    // Audio Gain Range: -60 to 20
                                    _audio_gain_adjustment = Convert.ToInt16(command[1]);
                                    _new_audio_gain = _control.AudioGain + _audio_gain_adjustment;
                                    if (_new_audio_gain < -60)
                                    {
                                        _new_audio_gain = -60;
                                    }
                                    else if (_new_audio_gain > 20)
                                    {
                                        _new_audio_gain = 20;
                                    }
                                    _control.AudioGain = _new_audio_gain;
                                    trackBarAudioGain.Value = _control.AudioGain;
                                    break;

                                case "set_squelch_threshold":
                                    // Squelch range: 0 to 100
                                    // Squelch is only available in NFM, WFM and AM
                                    if (_control.DetectorType.ToString() == "NFM" ||
                                        _control.DetectorType.ToString() == "WFM" ||
                                        _control.DetectorType.ToString() == "AM")
                                    {
                                        _new_squelch_threshold = Convert.ToInt16(command[1]);
                                        if (_new_squelch_threshold >= 0 && _new_squelch_threshold <= 100)
                                        {
                                            _control.SquelchThreshold = _new_squelch_threshold;
                                            trackBarSquelch.Value = _control.SquelchThreshold;
                                            labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                        }
                                    }
                                    else
                                    {
                                        labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                    }
                                    break;

                                case "adjust_squelch_threshold":
                                    // Squelch range: 0 to 100
                                    // Squelch is only available in NFM, WFM and AM
                                    if (_control.DetectorType.ToString() == "NFM" ||
                                        _control.DetectorType.ToString() == "WFM" ||
                                        _control.DetectorType.ToString() == "AM")
                                    {
                                        _squelch_threshold_adjustment = Convert.ToInt16(command[1]);
                                        _new_squelch_threshold = _control.SquelchThreshold + _squelch_threshold_adjustment;
                                        if (_new_squelch_threshold < 0)
                                        {
                                            _control.SquelchThreshold = 0;
                                            _control.SquelchEnabled = false;
                                        }
                                        else if (_new_squelch_threshold > 100)
                                        {
                                            _control.SquelchThreshold = 100;
                                            _control.SquelchEnabled = true;
                                        }
                                        else
                                        {
                                            _control.SquelchThreshold = _new_squelch_threshold;
                                            _control.SquelchEnabled = true;
                                        }
                                        trackBarSquelch.Value = _control.SquelchThreshold;
                                        labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                    }
                                    else
                                    {
                                        labelSquelchThresholdValue.Text = _control.SquelchThreshold.ToString();
                                    }
                                    break;

                                case "set_zoom":
                                    // Zoom range: 0 to 60
                                    _new_zoom = Convert.ToInt16(command[1]);
                                    if (_new_zoom >= 0 && _new_zoom <= 100)
                                    {
                                        _control.Zoom = _new_zoom;
                                        trackBarZoom.Value = _control.Zoom;
                                        labelZoomValue.Text = _control.Zoom.ToString();
                                    }
                                    break;

                                case "adjust_zoom":
                                    // Zoom range: 0 to 60
                                    _zoom_adjustment = Convert.ToInt16(command[1]);
                                    _new_zoom = _control.Zoom + _zoom_adjustment;
                                    if (_new_zoom < 0)
                                    {
                                        _control.Zoom = 0;
                                    }
                                    else if (_new_zoom > 60)
                                    {
                                        _control.Zoom = 60;
                                    }
                                    else
                                    {
                                        _control.Zoom = _new_zoom;
                                    }
                                    trackBarZoom.Value = _control.Zoom;
                                    labelZoomValue.Text = _control.Zoom.ToString();
                                    break;

                                case "set_filter_bandwidth":
                                    // Filter Bandwidth range: 10 to 250000
                                    _new_filter_bandwidth = Convert.ToInt16(command[1]);
                                    if (_new_filter_bandwidth >= 10 && _new_filter_bandwidth <= 250000)
                                    {
                                        _control.FilterBandwidth = _new_filter_bandwidth;
                                        labelFilterBandwidth.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                        labelFilterBandwidthValue.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                    }
                                    break;

                                case "adjust_filter_bandwidth":
                                    // Filter Bandwidth range: 10 to 250000
                                    _filter_bandwidth_adjustment = Convert.ToInt16(command[1]);
                                    _new_filter_bandwidth = _control.FilterBandwidth + _filter_bandwidth_adjustment;
                                    if (_new_filter_bandwidth < 10)
                                    {
                                        _control.FilterBandwidth = 10;
                                    }
                                    else if (_new_filter_bandwidth > 250000)
                                    {
                                        _control.FilterBandwidth = 250000;
                                    }
                                    else
                                    {
                                        _control.FilterBandwidth = _new_filter_bandwidth;
                                    }
                                    labelFilterBandwidth.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                    labelFilterBandwidthValue.Text = _control.FilterBandwidth.ToString("0,0", CultureInfo.InvariantCulture);
                                    break;

                                default:

                                    break;
                            }
                        }
                    }
                }
            }
        }

        private bool FindStep(int s)
        {
            if (s == _control.StepSize)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool FindMode(string s)
        {
            if (s == _control.DetectorType.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckConnectionEstablished(Object source, ElapsedEventArgs e)
        {
            if (_connection_established == false)
            {
                checkSerial.Checked = false;
                SerialControl();
            }
        }

    }

    public class CustomQueue : ConcurrentQueue<object>
    {
        public event EventHandler ItemInserted;

        protected virtual void OnItemInserted()
        {
            ItemInserted?.Invoke(this, EventArgs.Empty);
        }

        //Modified Enqueue method.
        public new void Enqueue(object obj)
        {
            base.Enqueue(obj);
            OnItemInserted();
        }
    }


}
