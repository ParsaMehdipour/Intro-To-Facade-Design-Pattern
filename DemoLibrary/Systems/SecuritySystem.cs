namespace DemoLibrary.Systems;

/// <summary>
/// The Subsystem can accept requests either from the facade or client
/// directly. In any case, to the Subsystem, the Facade is yet another
/// client, and it's not a part of the Subsystem.
/// Some facades can work with multiple subsystems at the same time.
/// These are some of the classes of a complex smart home system.
/// We don't control this code, so we can't simplify it directly.
/// </summary>
public class SecuritySystem
{
    private bool _amred;

    public void Arm()
    {
        _amred = true;
        Console.WriteLine("Security System: Armed");
    }

    public void Disarm()
    {
        _amred &= false;
        Console.WriteLine("Security System: Disarmed");
    }

    public bool IsArmed()
    {
        Console.WriteLine("Security System: Checking if armed"); return _amred;
    }
}
