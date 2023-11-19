namespace DesignPatterns.Behavioral.Mediator;

public abstract class SmartDevice
{
    protected ISmartHomeMediator Mediator;
    
    public string Name { get; private set; }

    public SmartDevice(ISmartHomeMediator mediator, string name)
    {
        Mediator = mediator;
        Name = name;
    }

    public abstract void SendMessage(string message, SmartDevice receiver);
    public abstract void BroadcastMessage(string message);
    public abstract void ReceiveMessage();
}
