# SDRSharp Controller
<p>This is a plugin for SDRSharp to be able to control it over a USB serial connection. It is inspired from the excellent SDRSharp Net Remote plugin created by Al Brown (https://github.com/EarToEarOak/SDRSharp-Net-Remote).
<p>Following are the main features of this plugin:
<ul>
<li>Commands sent to this plugin are simple key/value text (no JSON formatting).</li>
<li>It supports receiving increase/decrease commands for most setting (i.e. "adjust_audio_gain:+1", "adjust_audio_gain:+5", "adjust_audio_gain:-6). Out of bounds is checked by this plugin. This simplifies implementation of the external controller as it does not need to query the current value of a setting and keep track of it which can get out of sync if the user changes settings using the SDRSharp UI directly.</li>
<li>It can show in its UI what is currently being controlled and renders this with an appropriate UI component. For example if it receives a "show_mode:audio gain" command it will show that this setting is currently being controlled in the Current Control section of its UI and will show a track bar reflecting the current audio gain setting. In addition to showing this useful information it allows users to minimize what is shown in the SDRSharp UI to a minimum and only show this plugin if they wish to.</li>
<li>Current settings which can be changed with the plugin but that don't always appear in the SDRSharp UI are shown in the Controller Settings section of the plugin UI. Similarly to the Current Control section, this allows the user to only show the plugin UI if they wish to, thus minimizing screen real-estate used to show this information.</li>
<li>It can store the current frequency, filter mode and bandwidth ("memory:store" command) and restore SDRSharp to these settings ("memory:recall" command). The external controller does not need to retrieve and save anything. The plugin does everything when it receives these simple commands. The currently stored frequency is shown in the Memory section of its UI for reference.</li>
<li>The plugin does not respond to acknowledge that it has received most command - it simply executes them if it can, or otherwise ignores them and does not do anything. This again simplifies implementation on the external controller end and reduces serial communications ("fire and forget", one way communication from the external controller to the plugin for "show_mode", "memory", "set_*" and "adjust_*" commands).</li>
</ul>
<p>Tested on Windows 10 with SDRSharp version 1919.
<h2>Installation Instructions</h2>
<ol>
<li>Create a folder called "SDRSharp Controller" in the "Plugins" folder of SDRSharp.</li>
<li>Download the "SDRSharp.SDRSharpController.dll" file from the "Installation" folder of this repository and place it in the "SDRSharp Controller" folder created in the step above.</li>
<li>Start SDRSharp.  The plugin should be listed and available for use.</li>
</ol>
<h2>Activation Instructions</h2>
<p>To activate the plugin you will need to do the following in the Serial Connection section of the UI:
<ol>
<li>In the drop-down field, select the serial port that the external controller is connected to</li>
<li>Check/select the Connect checkbox</li>
</ol>
<p>Note:  If the serial port that the external controller is connected to does not appear in the drop-down field, stop and re-start SDRSharp.  It might also be helpful to check that your external controller is listed in the Windows Device Manager under "Ports (COM & LPT)".
<h2>Commands</h2>
<p>Inbound commands (commands sent by an external controller to the plugin) are comprised of a Command + ":" + Value, i.e. "adjust_audio_gain:1".  Commands and text values can have an underscore character or a space separating words and can be a mix of case.  So "adjust audio gain:1" and "Adjust_Audio_Gain:1" will also work.
<p><b>IMPORTANT:</b>  The plugin initiates a handshake as soon as the Connect checkbox is checked.  If the handshake fails then the plugin will automatically disconnect from the serial port.  Please see the "connection_status:established" command below for further details.
<p>Following is the full list of currently supported commands:
<table>
  <tr>
    <th>Command</th>
    <th>Value</th>
    <th>Purpose</th>
  </tr>
  <tr>
    <td>connection_status</td>
    <td>established</td>
    <td>When a serial port is selected in the UI and then the Connect checkbox is checked, the plugin will immediately send a "connection_request" text string to the external controller connected to the selected serial port.  The external controller should monitor for this message and send back "connection_status:established" immediately.  If the plugin does not receive this command back within a second it will assume that whatever is connected to the selected serial port is not a compatible controller and it will automatically un-select the Connect checkbox and terminate the serial connection.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>tuning</td>
    <td>Update the UI to show that tuning is now being adjusted and show the current frequency.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>tuning_step</td>
    <td>Update the UI to show that the tuning step is now being adjusted and show the current tuning step.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>filter_bandwidth</td>
    <td>Update the UI to show that the filter bandwidth is now being adjusted and show the current filter bandwidth.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>mode</td>
    <td>Update the UI to show that the filter / demodulation mode is now being adjusted and show the current mode.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>audio_gain</td>
    <td>Update the UI to show that the audio gain / volume is now being adjusted and show the current audio gain.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>zoom</td>
    <td>Update the UI to show that the FFT zoom is now being adjusted and show the current zoom setting.</td>
  </tr>
  <tr>
    <td>show_mode</td>
    <td>squelch_threshold</td>
    <td>Update the UI to show that the squelch threshold is now being adjusted and show the current squelch threshold setting.  Note that squelch is available for NFM, WFM and AM modes only.  If another mode is currently active a "Not available" message will appear in the UI.</td>
  </tr>
  <tr>
    <td>memory</td>
    <td>store</td>
    <td>Stores the current frequency, mode and filter bandwidth and displays the stored frequency in the Memory section of the UI.</td>
  </tr>
  <tr>
    <td>memory</td>
    <td>recall</td>
    <td>Sets SDRSharp to the previously stored frequency, mode and filter bandwidth (what was stored when the "memory:store" command was received).  If a "memory:store" command was not received yet then nothing will happen.</td>
  </tr>
  <tr>
    <td>set_tuning</td>
    <td>Integer between 1 and 999999999999</td>
    <td>Sets SDRSharp to the frequency received.  If an out-of-bounds value has been received it will ignore the command.</td>
  </tr>
  <tr>
    <td>adjust_tuning</td>
    <td>Negative or positive integer</td>
    <td>First computes the amount of frequency to adjust by multiplying the integer received by the current tuning step, and then adds (if a positive integer was received) or substracts (if a negative integer was received) this value from the current frequency.  If the integer received would result in an out-of-bounds condition then the frequency is set to 1 if a negative integer was received, otherwise 999999999999 if a positive integer was received.</td>
  </tr>
  <tr>
    <td>adjust_tuning_step</td>
    <td>Negative or positive integer</td>
    <td>Changes to a previous or next available tuning step based on the integer received.  I.e. if the current tuning step is set to 1000 and "adjust_tuning_step:1" is received then the tuning step will be set to 2500 which is the next highest tuning step available after 1000.  If the current tuning step is set to 1000 and "adjust_tuning_step:2" is received then the tuning step will be set to 3000 which is two tuning steps above 1000.  Similarly, if the current tuning step is set to 1000 and "adjust_tuning_step:-1" is received then the tuning step will be set to 500 which is the first tuning step available below 1000.  If the integer received would result in an out-of-bounds condition then the tuning step will be set to 1 if a negative integer was received, otherwise 1000000 if a positive integer was received.  Note that if the Snap feature is currently set in SDRSharp then SDRSharp will also adjust the frequency to "snap" it to the step selected which will also be reflected in the Controller Settings section of the UI.</td>
  </tr>
  <tr>
    <td>adjust_mode</td>
    <td>Negative or positive integer</td>
    <td>Changes to a previous or next available mode based on the integer received.  I.e. if the current mode is set to WFM and "adjust_mode:1" is received then the mode will be set to AM which is the next mode available after WFM.  Similarly, if the current mode is set to WFM and "adjust_mode:-1" is received then the mode will be set to NFM which is the previous mode available before WFM.  If the integer received would result in an out-of-bounds condition then the first mode (NFM) will be set if a negative integer was received, otherwise the last mode (RAW) if a positive integer was received.</td>
  </tr>
  <tr>
    <td>set_audio_gain</td>
    <td>Integer between -60 and 20</td>
    <td>Sets SDRSharp to the audio gain / volume level received.  If an out-of-bounds value has been received then it will ignore the command.</td>
  </tr>
  <tr>
    <td>adjust_audio_gain</td>
    <td>Negative or positive integer</td>
    <td>Adjusts the audio gain / volume level by the amount received in the integer.  I.e. if the current audio gain is set to -40 and "adjust_audio_gain:10" is received then it will set the audio gain to -30 (-40 + 10).  If the integer received would result in an out-of-bounds audio gain then the audio gain will be set to -60 if a negative integer was received, otherwise 20 if a positive integer was received.</td>
  </tr>
  <tr>
    <td>set_squelch_threshold</td>
    <td>Integer between 0 and 100</td>
    <td>Sets SDRSharp to the squelch threshold received.  If an out-of-bounds value has been received or the current mode is not NFM, WFM or AM (only modes for which squelch is available) then the command is ignored.</td>
  </tr>
  <tr>
    <td>adjust_squelch_threshold</td>
    <td>Negative or positive integer</td>
    <td>Adjusts the squelch threshold by the amount received in the integer.  I.e. if the current squelch threshold is set to 15 and "adjust_squelch_threshold:5" is received then it will set the squelch threshold to 20 (15 + 5).  Similarly, if the current squelch threshold is set to 15 and "adjust_squelch_threshold:-5" is received then it will set the squelch threshold to 10 (15 - 5).  If the integer received would result in an out-of-bounds squelch threshold then the squelch threshold is set to 0 if a negative integer was received, otherwise 100 if a positive integer was received.</td>
  </tr>
  <tr>
    <td>set_zoom</td>
    <td>Integer between 0 and 60</td>
    <td>Sets SDRSharp to the FFT zoom level received.  If an out-of-bounds value has been received then the command is ignored.</td>
  </tr>
  <tr>
    <td>adjust_zoom</td>
    <td>Negative or positive integer</td>
    <td>Adjusts the FFT zoom level by the amount received in the integer.  I.e. if the current zoom is set to 30 and "adjust_zoom:5" is received then it will set the zoom to 35 (30 + 5).  Similarly, if the current zoom is set to 30 and "adjust_zoom:-5" is received then it will set the zoom to 25 (30 - 5).  If the integer received would result in an out-of-bounds zoom then the zoom is set to 0 if a negative integer was received, otherwise 60 if a positive integer was received.</td>
  </tr>
  <tr>
    <td>set_filter_bandwidth</td>
    <td>Integer between 10 and 250000</td>
    <td>Sets SDRSharp to the filter bandwidth received.  If an out-of-bounds value has been received then the command is ignored.</td>
  </tr>
  <tr>
    <td>adjust_filter_bandwidth</td>
    <td>Negative or positive integer</td>
    <td>Adjusts the filter bandwidth by the amount received.  I.e. if the current filter bandwidth is set to 1000 and "adjust_filter_bandwidth:100" is received then it will set the filter bandwidth to 1100 (1000 + 100).  Similarly, if the current filter bandwidth is set to 1000 and "adjust_filter_bandwidth:-100" is received then it will set the filter bandwidth to 900 (1000 - 100).  If the integer received would result in an out-of-bounds filter bandwidth then the filter bandwidth is set to 10 if a negative integer was received, otherwise 250000 if a positive integer was received.</td>
  </tr>
</table>
<h2>To-Do</h2>
<p>The following commands have yet to be implemented:
<ul>
<li>set_tuning_step</li>
<li>set_mode</li>
<li>"get" commands that will send back current settings to the external controller (similar to what is supported in the SDRSharp Net Remote plugin)</li>
</ul>
<h2>Example Implementation</h2>
<p><a href="https://www.hackster.io/AlanDeWindt/sdrsharp-controller-83baa8">Here</a> is an example of a device I created which uses this plugin.
