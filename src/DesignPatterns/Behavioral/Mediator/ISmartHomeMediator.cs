namespace DesignPatterns.Behavioral.Mediator;

public interface ISmartHomeMediator
{
    void SendMessage(string message, SmartDevice sender, SmartDevice receiver);
    void BroadcastMessage(string message, SmartDevice sender);
    void AddDevices(params SmartDevice[] devices);
}
