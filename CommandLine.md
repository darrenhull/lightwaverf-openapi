The command line interface is installed with the API - in Program files\LightwaveRF Open API\

It can be used for example to schedule events with windows scheduler (start - control panel - scheduled tasks in xp, or start - type task scheduler in windows 7) - then you can set up automatic schedules to do things when you are on holiday for example.

```
Usage:
switch device on or off   : LightwaveConsole Device    <room> <device> <state>
dim device                : LightwaveConsole Dim       <room> <device> <state>
radiator on/off           : LightwaveConsole Heat      <room> <state>
All radiators             : LightwaveConsole AllHeat   <state>
Central Heating / Boiler  : LightwaveConsole Boiler    <state>
Hot Water                 : LightwaveConsole HotWater  <state>
All in room off           : LightwaveConsole Room      <room>
Set mood in room          : LightwaveConsole Mood      <room> <mood>
Store mood in room        : LightwaveConsole StoreMood <room> <mood>
Send Raw data to wifi     : LightwaveConsole Raw       <datatosend>
listen for other commands : LightwaveConsole Listen

eg:
LightwaveConsole Device 1 1 1
LightwaveConsole Dim 1 1 100
LightwaveConsole Heat 1 0
LightwaveConsole AllHeat 0
LightwaveConsole Room 1
LightwaveConsole Mood 1 1
LightwaveConsole StoreMood 1 1
LightwaveConsole Raw 533!R1D1F1

```