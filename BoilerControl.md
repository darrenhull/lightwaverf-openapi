# Introduction #

I got frustrated waiting for boiler control to be available - after waiting a whole year for it, I gave up on that and started applying what already exists to my central heating system.

Follow this at your own risk - and anything that happens is not my responsibility...


# Details #

Central heating control units work on 240V AC - so be careful, below are the steps I followed to get boiler control with existing LightWaveRF units:

  1. Bought LightWaveRF in-line relay
  1. Switched off mains to the central heating.
  1. Identified wiring to the thermostat for the central heating
  1. Cut one of the wires to the thermostat, and wired it to either side of the relay
  1. Fed central heating mains from the central heating 'chocolate block' to the lightwaverf relay.
  1. Switched on mains to the central heating
  1. Held down 'learn' on the relay
  1. Sent the boiler on command from my android phone.

Now I can switch the heating on and off from anywhere,

optionally - you could fit one side of the relay to bypass the thermostat (force-on) and once side to keep in line with the thermostat - then the relay commands would have the following meaning:

Open (or On)   : force heating on,
Close (or Off) : thermostatic normal heating,
Stop           : heating forced off.