namespace DemoLibrary.Systems;

/// <summary>
/// The Subsystem can accept requests either from the facade or client
/// directly. In any case, to the Subsystem, the Facade is yet another
/// client, and it's not a part of the Subsystem.
/// Some facades can work with multiple subsystems at the same time.
/// These are some of the classes of a complex smart home system.
/// We don't control this code, so we can't simplify it directly.
/// </summary>
public class Light
{
    public void TurnOn() => Console.WriteLine("Light: Turned on");
    public void TurnOff() => Console.WriteLine("Light: Turned off");
    public void Dim(int level) => Console.WriteLine($"Light: Dimmed to {level}%");
}

