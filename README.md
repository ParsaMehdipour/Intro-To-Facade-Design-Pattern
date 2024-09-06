# Intro-To-Facade-Design-Pattern
Facade is a struc­tur­al design pat­tern that pro­vides a sim­pli­fied inter­face to a library, a frame­work, or any other com­plex set of classes. 

</br>

<p align="center">
  <img src="https://github.com/user-attachments/assets/4349308e-dbad-4aa9-b0c9-ceed455948b2" width="800">
</p>

1. The Facade provides convenient access to a particular part of the subsystem’s functionality. It knows where to direct the client’s request and how to operate all the moving parts.

2. An Additional Facade class can be created to prevent polluting a single facade with unrelated features that might make it yet another complex structure. Additional facades can be used by both clients and other facades.

3. The Complex Subsystem consists of dozens of various objects. To make them all do something meaningful, you have to dive deep into the subsystem’s implementation details, such as initializing objects in the correct order and supplying them with data in the proper format. 
Subsystem classes aren’t aware of the facade’s existence. They operate within the system and work with each other directly.

4. The Client uses the facade instead of calling the subsystem
objects directly.
