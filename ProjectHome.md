# LightwaveRF Open API #
A simple .net, and Java API for the LightwaveRF WifiLink.

**this is under active development - I am extending this to cover heating scenarios at the moment - any willing developers up for helping are appreciated**
Latest idea is to integrate this with Google Calendar so that events can be created in a custom lightwave calendar which will then actuate devices when the time comes.

Includes test app, and [Command-Line](CommandLine.md) app

New features in the test app in 2.4:
  * [Boiler controls](BoilerControl.md)
  * Energy Meter reading
  * Control your heating automatically given weather
  * Sequences
  * Timers (not totally tested but should work)

API features:
  * room management - and state management of devices given local commands detected.


Send commands for:
  * On/Off Devices (On/Off / Lock)
  * Dimmers
  * Moods
  * Boiler Controls
  * Heating (radiator valves)
  * Sequences (create / run)
  * Relays (Open / Close / Stop)

Receive events when any (IP) device (Iphone/pc) sends commands for:


  * On/Off Devices (On/Off / Lock)
  * Dimmers
  * Moods
  * Heating (radiator valves)

Maintain Radiator state (where radiator does not stay off - refresh the off state from the api to the radaitor)