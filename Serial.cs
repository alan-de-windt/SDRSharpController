using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace SDRSharp.SDRSharpController
{
    class Serial
    {
        public event EventHandler SerialError;

        private string _data;
        private string _port;
        private CustomQueue _queue;

        private ManualResetEvent _signal = new ManualResetEvent(false);

        public Serial(string port, CustomQueue queue)
        {
            _port = port;
            _queue = queue;
        }

        public static string[] GetPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            return ports;
        }

        public void Start()
        {
            SerialPort port = new SerialPort(_port, 115200);
            port.BaudRate = 115200;
            port.Parity = Parity.None;
            port.StopBits = StopBits.One;
            port.DataBits = 8;
            port.Handshake = Handshake.None;
            port.RtsEnable = true;
            port.DtrEnable = true;

            port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                port.Open();
                port.DiscardInBuffer();
                Send(port, "connection_request");
            }
            catch (IOException ex)
            {
                OnSerialError();
                string msg = "Serial Port Error:\n" + ex.Message;
                MessageBox.Show(msg, Info.Title() + "Serial Port Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(port);
                return;
            }
            catch (UnauthorizedAccessException ex)
            {
                OnSerialError();
                string msg = "Serial Port Error:\n" + ex.Message;
                MessageBox.Show(msg, Info.Title() + "Serial Port Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(port);
                return;
            }

            _signal.Reset();
            _signal.WaitOne();

            Close(port);
        }
        private void Send(SerialPort port, String data)
        {
            if (port.IsOpen && data != null)
                port.Write(data);
        }

        public void Stop()
        {
            _signal.Set();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort port = (SerialPort)sender;

            while (port.BytesToRead > 0)
            {
                _data = port.ReadLine();
                _queue.Enqueue(_data);
            }

        }

        private void Close(SerialPort port)
        {
            try
            {
                port.Close();
            }
            catch (IOException)
            {
            }

        }

        protected virtual void OnSerialError()
        {
            EventHandler handler = SerialError;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }
}
