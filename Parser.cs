using SDRSharp.Common;
using SDRSharp.Radio;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace SDRSharp.SerialRemote
{
    class Parser
    {

        private ISharpControl _control;

        public Parser(ISharpControl control)
        {

            _control = control;

        }

        public void Parse(string data)
        {

            long new_frequency = 0;
            long frequency_adjustment = 0;
            int new_audio_gain = 0;
            int audio_gain_adjustment = 0;
            int new_squelch_threshold = 0;
            int squelch_threshold_adjustment = 0;
            int new_zoom = 0;
            int zoom_adjustment = 0;
            int new_filter_bandwidth = 0;
            int filter_bandwidth_adjustment = 0;

            data = data.ToLower();
            string[] command = data.Split(':');

            switch (command[0])
            {

                case "set_frequency":
                    // Frequency range: 1 to 999999999999
                    new_frequency = Convert.ToInt64(command[1]);
                    if (new_frequency >= 1 && new_frequency <= 999999999999)
                    {
                        _control.Frequency = new_frequency;
                    }
                    break;

                case "adjust_frequency":
                    // Frequency range: 1 to 999999999999
                    frequency_adjustment = Convert.ToInt64(command[1]);
                    new_frequency = _control.Frequency + frequency_adjustment;
                    if (new_frequency < 1) { 
                        _control.Frequency = 1; 
                    }
                    else if (new_frequency > 999999999999) { 
                        _control.Frequency = 999999999999; 
                    }
                    else { 
                        _control.Frequency = new_frequency; 
                    }
                    break;

                case "set_audio_gain":
                    // Audio Gain range: -60 to 20
                    new_audio_gain = Convert.ToInt16(command[1]);
                    if (new_audio_gain >= -60 && new_audio_gain <= 20)
                    {
                        _control.AudioGain = new_audio_gain;
                    }
                    break;

                case "adjust_audio_gain":
                    // Audio Gain Range: -60 to 20
                    audio_gain_adjustment = Convert.ToInt16(command[1]);
                    new_audio_gain = _control.AudioGain + audio_gain_adjustment;
                    if (new_audio_gain < -60)
                    {
                        _control.AudioGain = -60;
                    }
                    else if (new_audio_gain > 20)
                    {
                        _control.AudioGain = 20;
                    }
                    else
                    {
                        _control.AudioGain = new_audio_gain;
                    }
                    break;

                case "set_squelch_threshold":
                    // Squelch range: 0 to 100
                    new_squelch_threshold = Convert.ToInt16(command[1]);
                    if (new_squelch_threshold >= 0 && new_squelch_threshold <= 100)
                    {
                        _control.SquelchThreshold = new_squelch_threshold;
                    }
                    break;

                case "adjust_squelch_threshold":
                    // Squelch range: 0 to 100
                    squelch_threshold_adjustment = Convert.ToInt16(command[1]);
                    new_squelch_threshold = _control.SquelchThreshold + squelch_threshold_adjustment;
                    if (new_squelch_threshold < 0)
                    {
                        _control.SquelchThreshold = 0;
                    }
                    else if (new_squelch_threshold > 100)
                    {
                        _control.SquelchThreshold = 100;
                    }
                    else
                    {
                        _control.SquelchThreshold = new_squelch_threshold;
                    }
                    break;

                case "set_zoom":
                    // Zoom range: 0 to 100
                    new_zoom = Convert.ToInt16(command[1]);
                    if (new_zoom >= 0 && new_zoom <= 100)
                    {
                        _control.Zoom = new_zoom;
                    }
                    break;

                case "adjust_zoom":
                    // Zoom range: 0 to 100
                    zoom_adjustment = Convert.ToInt16(command[1]);
                    new_zoom = _control.Zoom + zoom_adjustment;
                    if (new_zoom < 0)
                    {
                        _control.Zoom = 0;
                    }
                    else if (new_zoom > 60)
                    {
                        _control.Zoom = 60;
                    }
                    else
                    {
                        _control.Zoom = new_zoom;
                    }
                    break;

                case "set_filter_bandwidth":
                    // Filter Bandwidth range: 10 to 250000
                    new_filter_bandwidth = Convert.ToInt16(command[1]);
                    if (new_filter_bandwidth >= 10 && new_filter_bandwidth <= 250000)
                    {
                        _control.FilterBandwidth = new_filter_bandwidth;
                    }
                    break;

                case "adjust_filter_bandwidth":
                    // Filter Bandwidth range: 10 to 250000
                    filter_bandwidth_adjustment = Convert.ToInt16(command[1]);
                    new_filter_bandwidth = _control.FilterBandwidth + filter_bandwidth_adjustment;
                    if (new_filter_bandwidth < 10)
                    {
                        _control.FilterBandwidth = 10;
                    }
                    else if (new_filter_bandwidth > 250000)
                    {
                        _control.FilterBandwidth = 250000;
                    }
                    else
                    {
                        _control.FilterBandwidth = new_filter_bandwidth;
                    }
                    break;

                default:

                    break;

            }

        }

    }

}
