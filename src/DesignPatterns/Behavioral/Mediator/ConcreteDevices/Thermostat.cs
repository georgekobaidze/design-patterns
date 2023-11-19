using System;

namespace DesignPatterns.Behavioral.Mediator.ConcreteDevices;

public class Thermostat : SmartDevice
{
    public Thermostat(ISmartHomeMediator mediator, string name) : base(mediator, name)
    {
    }
    
    public override void SendMessage(string message, SmartDevice receiver)
    {
        Console.WriteLine($"[{Name}] --->>> [{receiver.Name}]: \"{message}\"");
    }

    public override void BroadcastMessage(string message)
    {
        Console.WriteLine($"[{Name}]: \"{message}\"");
        Mediator.BroadcastMessage(message, this);
    }

    public override void ReceiveMessage()
    {
        Console.WriteLine($"[{Name}]: \"Copy that!\"");
    }
}
