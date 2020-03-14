sketch
#Introduction
The aim of this work was to build a framework for indoor monitoring. We used Estimote Beacons, an android app and Azure IoT Hub service to 
automate the data stream and storage.
## The team
Group was composed by three students:
    -[Gabriele ursini](http://linkedin.com/in/gabriele-ursini-08578a1a3)<surname> — <write your part here>
    -[Giovanni Fiordeponti](https://www.linkedin.com/in/giovanni-fiordeponti-070aa3172) — <write your part here>
    -[Nicola Di Santo](https://www.linkedin.com/in/nicola-di-santo-b98647192/) — Azure and Hub configuration, device to cloud message testing and Analytics
# What is a Beacon?
In a nutshell, beacons are hardware devices, sometimes equipped with some additional built-in sensors , which constantly broadcast Bluetooth 
frames through radio signal within range of few square meters. The name “beacon” derives from the lighthouse helping sailors as soon they 
approach its visible area. The same logic is present in our beacons where the lighthouse is the beacons device, the visible light is Bluetooth 
radio signal and the sailors are bluetooth-equipped devices like smartphones (receiver-side). Many beacons work with 
[Bluetooth Low Energy](https://en.wikipedia.org/wiki/Bluetooth_Low_Energy), so 
batteries can last at least five years on average still guaranteeing enough data rate for many IoT applications.

# Bluetooth (Classic) vs Bluetooth low energy:

In Classic (not BLE) Bluetooth we have these features <br>
**Pros**
* It can handle lot of data consuming more power

**Cons**
* Low data transfer rate.
* Short range of operation
* Classic Bluetooth once initiated , it always in wake up mode even not in use raising power consumption.

While Bluetooth Low Energy (BLE or Smart Bluetooth) improved Bluetooth in small data packet transmission situation like this:<br>
**Pros**
* High data transfer rate
* Medium range of operation
* BLE goes to sleep once not in use and wakes up once data/information transfer happens.
* Low power consumption

**Cons**
* Handle very less data

## BLE Beacons vs GPS sensors

We all know how much GPS tracking can be useful and easy to use (consider where you’d be without Google maps) but it’s still not perfect. 
If you are in a building with multiple floors in it, GPS cannot tell you accurately floor or room in which you are standing. Also in places 
like underground car parks, GPS signal can be easily lost.
Here beacons come into play.
First thing is to place beacons in specific high point of the room (the higher the better, cause Bluetooth signal suffers from bodies and 
building penetration resistance). So you need to choose a right spot depending on how much distance range you need to cover. Once beacons
are set you will only need an app with active Bluetooth connection receiving packets containing:

* Beacon SN
* Major ID
* Minor ID
* Sensor Data (temperature, accelerometer…)
* Device Data (battery status, system info …)

The first three fields help the receiver to distinguish between different beacons, sensor data are used in your application and device data 
are useful for debugging and monitoring purpose.

Beacon or device exact position can be triangulated, where distance is retrieved by RSSI level, there are several projects on the web with 
this purpose (e.g. https://proximi.io/accurate-indoor-positioning-bluetooth-beacons/). However the most reliable distance based application 
is the kind based on signal area covered by beacons or at most beacons-receiver point to point distance.

# About Estimote

# Sensors and how we used them

#What is Azure Iot Hub and how does it works?

# how we used it

# conclusion

#resources
  
