using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Mediator;

public class SmartHomeMediator : ISmartHomeMediator
{
    private List<SmartDevice> _devices = new List<SmartDevice>();

    public void AddDevices(params SmartDevice[] devices)
    {
        _devices.AddRange(devices);
    }

    public void SendMessage(string message, SmartDevice sender, SmartDevice receiver)
    {
        receiver.ReceiveMessage();
    }

    public void BroadcastMessage(string message, SmartDevice sender)
    {
        foreach (var device in _devices)
        {
            // Ensure the sender is not receiving its own message
            if (device != sender)
            {
                device.ReceiveMessage();
            }
        }
    }
}
