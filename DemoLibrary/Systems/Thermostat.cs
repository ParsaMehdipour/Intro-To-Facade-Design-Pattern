namespace DemoLibrary.Systems;

/// <summary>
/// The Subsystem can accept requests either from the facade or client
/// directly. In any case, to the Subsystem, the Facade is yet another
/// client, and it's not a part of the Subsystem.
/// Some facades can work with multiple subsystems at the same time.
/// These are some of the classes of a complex smart home system.
/// We don't control this code, so we can't simplify it directly.
/// </summary>
public class Thermostat
{
    private int _currentTemperature;

    public void SetTemperature(int temperature)
    {
        _currentTemperature = temperature;
        Console.WriteLine($"Thermostat: Set to {temperature}°C");
    }

    public int GetCurrentTemperature()
    {
        Console.WriteLine("Thermostat: Getting current temperature");
        return _currentTemperature;
    }
}
