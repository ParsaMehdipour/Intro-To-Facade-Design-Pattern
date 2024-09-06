using DemoLibrary.Facade_Classes;
using DemoLibrary.Systems;

// Application classes don't depend on the many classes
// provided by the complex smart home system. Also, if you decide to
// switch to a different smart home system, you only need to rewrite the facade class.
// ..............
// The client code may have some of the subsystem's objects already
// created. In this case, it might be worthwhile to initialize the
// Facade with these objects instead of letting the Facade create
// new instances.


Light light = new();
Thermostat thermostat = new();
SecuritySystem securitySystem = new();
GarageDoor garageDoor = new();

SmartHomeFacade smartHome = new SmartHomeFacade(light, thermostat, securitySystem, garageDoor);

smartHome.LeaveHome();
smartHome.ReturnHome();
smartHome.GoToSleep();

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();