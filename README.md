# SDRSharp Controller

WARNING: This repository is not yet ready for consumption.

TODO:
* Add installation instructions
* Upload .dll of compiled plugin

This is a plugin for SDRSharp to be able to control it over a USB serial connection. It is inspired from the excellent SDRSharp Net Remote plugin created by Al Brown (https://github.com/EarToEarOak/SDRSharp-Net-Remote).

The following are the main features of this plugin:

*  Commands sent to this plugin are simple key/value text (no JSON formatting).
*  It supports receiving increase/decrease commands for every setting (i.e. "adjust_audio_gain:+1", "adjust_audio_gain:+5", "adjust_audio_gain:-6). Out of bounds is checked by this plugin. This simplifies implementation of the external controller as it does not need to query the current value of a setting and keep track of it which can get out of sync if the user changes settings using the SDRSharp UI directly.
*  It can show in its UI what is currently being controlled and renders this with an appropriate UI component. For example if it receives a "show_mode:audio gain" command it will show that this setting is currently being controlled in the "Current Control" section of its UI and will show a track bar reflecting the current audio gain setting. In addition to showing this useful information it allows users to minimize what is shown in the SDRSharp UI to a minimum and only show this plugin if they wish to.
*  Current settings which can be changed with the plugin but that don't always appear in the SDRSharp UI are shown in the Controller Settings section of the plugin UI. Similarly to the Current Control section, this allows the user to only show the plugin UI if they wish to, thus minimizing screen real-estate used to show this information.
*  It can store the current frequency, filter mode and bandwidth ("memory:store" command) and restore SDRSharp to these settings ("memory:recall" command). The external controller does not need to retrieve and save anything. The plugin does everything when it receives these simple commands. The currently stored frequency is shown in the Memory section of its UI for reference.
*  Similar commands to SDRSharp Net Remote are supported to set a setting to an exact value (i.e. "set_audio_gain:-40") and to retrieve current settings ("get:audio_gain").
*  The plugin does not respond to acknowledge that it has received most command - it simply executes them if it can, or otherwise ignores them and does not do anything. This again simplifies implementation on the external controller end and reduces serial communications ("fire and forget", one way communication from the external controller to the plugin for "set" and "adjust" commands).

Tested on Windows 10 with SDRSharp version 1919.

<h1>Installation</h1>

