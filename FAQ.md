# Questions #

## 1. What is 'Maintain Radiator Off' / Keep Radiator State ##
The older LigtWaveRF radiator valves, and iTemp Terrier valves only stay off for a number of minutes after receiving an 'open window' command - this option will set the api to resend any off signals for a radiator. The state can be changed by sending an on command to a radiator (even from an iPhone on the local network) - or after a time period elapses.
This method retains a list of the valves that are currently in the off state, and resends the off commands to them.

## 2. What is the 'Detected Commands' box in the test app ##
This textbox shows all the commands sent on the network to the wifilink. - if you want to copy a command that another device (eg. iPhone) sends then send it from the iPhone, and you will see it in here. you can test this new command using the 'Raw' tab to send a Raw message. if you have a command you would like to add to the API - then either post a patch, or request it in the issues.

## 3. How can I control my boiler without a boiler control ##
see [Boiler Control](BoilerControl.md)

## 4. I can't program - how can I use the API ##
try the [command-line app](CommandLine.md) - it will allow you to make simple batch scripts, or scheduled tasks in windows to do things.