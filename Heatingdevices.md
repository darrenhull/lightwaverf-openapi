# Introduction #

This page captures info on the LightwaveRF heating devices, so we can derive what the protocol is


# Details #

I currently have a TRV.

Getting temperature:

```
101,!R1F*r
```
(Room1 Get temperature)

the response is in JSON format:

```
*!{"trans":62,"mac":"##:##:##","time":1412277443,"prod":"valve","serial":"######","signal":0,"type":"temp","batt":2.50,"ver":56,"state":"run","cTemp":21.5,"cTarg":22.0,"output":100,"nTarg":18.0,"nSlot":"06:00","prof":4}
```

representing an object containing the current temperature, battery level, target temperature etc...

Setting the temperature:
```
101,!R1DhF*tP22.0
```

Setting the valve position, appears to be the same command but with a different range
```
103,!R1DhF*tP56.0
```

Commands to set schedules:

setting up a schedule from 06:30 -> 22:45 on monday and Friday 21DegC

and 14:15 -> 22:15 tues->thurs for 21DegC

```
106,!R1DhF*s=N4,B30,Y15.0,T21.0,S14:15,E22:15
105,!R1DhF*s=N3,B30,Y15.0,T21.0,S14:15,E22:15
104,!R1DhF*s=N2,B30,Y15.0,T21.0,S14:15,E22:15
103,!R1DhF*s=N5,B30,Y15.0,T21.0,S6:30,E22:45
102,!R1DhF*s=N1,B30,Y15.0,T21.0,S6:30,E22:45
```