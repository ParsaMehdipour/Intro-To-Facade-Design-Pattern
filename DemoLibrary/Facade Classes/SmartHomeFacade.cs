using DemoLibrary.Systems;

namespace DemoLibrary.Facade_Classes;

/// <summary>
/// The Facade class provides a simple interface to the complex logic of one
/// or several subsystems. The Facade delegates the client requests to the
/// appropriate objects within the subsystem. The Facade is also responsible
/// for managing their life cycle. All of this shields the client from the
/// undesired complexity of the subsystem.
/// ...
/// We create a smart home facade class to hide the system's complexity
/// behind a simple interface. It's a trade-off between
/// functionality and simplicity.
/// </summary>
public class SmartHomeFacade
{
    private Light _light;
    private Thermostat _thermostat;
    private SecuritySystem _securitySystem;
    private GarageDoor _garageDoor;

    public SmartHomeFacade(Light light, Thermostat thermostat, SecuritySystem securitySystem, GarageDoor garageDoor)
    {
        _light = light;
        _thermostat = thermostat;
        _securitySystem = securitySystem;
        _garageDoor = garageDoor;
    }

    /// <summary>
    /// The Facade's methods are convenient shortcuts to the sophisticated
    /// functionality of the subsystems. However, clients get only to a
    /// fraction of a subsystem's capabilities.
    /// </summary>
    public void LeaveHome()
    {
        Console.WriteLine("\nExecuting 'Leave Home' scenario:");
        _light.TurnOff();
        _thermostat.SetTemperature(18); // Set to energy-saving temperature
        _securitySystem.Arm();
        _garageDoor.Close();
    }

    public void ReturnHome()
    {
        Console.WriteLine("\nExecuting 'Return Home' scenario:");
        _garageDoor.Open();
        _light.TurnOn();
        _thermostat.SetTemperature(22); // Set to comfortable temperature
        _securitySystem.Disarm();
    }

    public void GoToSleep()
    {
        Console.WriteLine("\nExecuting 'Go To Sleep' scenario:");
        _light.Dim(10); // Dim lights to 10%
        _thermostat.SetTemperature(20); // Set to sleep temperature
        _securitySystem.Arm();
    }
}
