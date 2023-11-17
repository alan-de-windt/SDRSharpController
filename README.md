# SDRSharp Controller

This is a plugin for SDRSharp to be able to control it over a USB serial connection. It is inspired from the excellent SDRSharp Net Remote plugin created by Al Brown (https://github.com/EarToEarOak/SDRSharp-Net-Remote).

Following are the main features of this plugin:
<ul>
<li>Commands sent to this plugin are simple key/value text (no JSON formatting).</li>
<li>It supports receiving increase/decrease commands for every setting (i.e. "adjust_audio_gain:+1", "adjust_audio_gain:+5", "adjust_audio_gain:-6). Out of bounds is checked by this plugin. This simplifies implementation of the external controller as it does not need to query the current value of a setting and keep track of it which can get out of sync if the user changes settings using the SDRSharp UI directly.</li>
<li>It can show in its UI what is currently being controlled and renders this with an appropriate UI component. For example if it receives a "show_mode:audio gain" command it will show that this setting is currently being controlled in the "Current Control" section of its UI and will show a track bar reflecting the current audio gain setting. In addition to showing this useful information it allows users to minimize what is shown in the SDRSharp UI to a minimum and only show this plugin if they wish to.</li>
<li>Current settings which can be changed with the plugin but that don't always appear in the SDRSharp UI are shown in the Controller Settings section of the plugin UI. Similarly to the Current Control section, this allows the user to only show the plugin UI if they wish to, thus minimizing screen real-estate used to show this information.</li>
<li>It can store the current frequency, filter mode and bandwidth ("memory:store" command) and restore SDRSharp to these settings ("memory:recall" command). The external controller does not need to retrieve and save anything. The plugin does everything when it receives these simple commands. The currently stored frequency is shown in the Memory section of its UI for reference.</li>
<li>The plugin does not respond to acknowledge that it has received most command - it simply executes them if it can, or otherwise ignores them and does not do anything. This again simplifies implementation on the external controller end and reduces serial communications ("fire and forget", one way communication from the external controller to the plugin for "set" and "adjust" commands).</li>
</ul>
Tested on Windows 10 with SDRSharp version 1919.

<h2>To-Do</h2>

This initial version covers the above-mentioned functionality.  For completeness and to allow more complex devices to be created I intend to add the following functionality in the near future:

*  Add support (similar to SDRSharp Net Remote) to allow an exact value to be set for a setting (i.e. "set_audio_gain:-40") and to retrieve current settings (i.e. "get:audio_gain").

<h2>Installation</h2>
tbd
<h2>Commands</h2>
Inbound commands (commands sent by an external controller to the plugin) are comprised of a Command + ":" + Value, i.e. "adjust_audio_gain:1".  Commands and text values can have underscore characters or spaces separating words and can be a mix of case.  So "adjust audio gain:1" and "Adjust_Audio_Gain:1" will also work.
Following is the full list currently supported commands:
<table>
  <tr>
    <th>Command</th>
    <th>Value</th>
    <th>Purpose</th>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>tuning</td>
    <td>Update the UI to show that tuning is now being adjusted and show the current frequency</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>tuning_step</td>
    <td>Update the UI to show that the tuning step is now being adjusted and show the current tuning step</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>filter_bandwidth</td>
    <td>Update the UI to show that the filter bandwidth is now being adjusted and show the current filter bandwidth</td>
  </tr>
</table>
<h2>Implementation</h2>
The purpose of this SDRSharp plugin is to be able to build physical devices with push buttons, rotary encoders, etc. to control SDRSharp.  <a href="https://www.hackster.io/AlanDeWindt/sdrsharp-controller-83baa8">Here</a> is an example of such a device I built which was my motivation for creating this SDRSharp plugin.
