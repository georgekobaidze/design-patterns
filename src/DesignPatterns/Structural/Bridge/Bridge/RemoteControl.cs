namespace DesignPatterns.Structural.Bridge.Bridge;

public abstract class RemoteControl
{
    protected readonly IDevice _device;

    public RemoteControl(IDevice device) => _device = device;

    public void TogglePower()
    {
        if (_device.IsTurnedOn())
            _device.TurnOn();
        else _device.TurnOff();
    }

    public void DecreaseVolume() => _device.SetVolume(_device.GetVolume() - 1);
    public void IncreaseVolume() => _device.SetVolume(_device.GetVolume() + 1);

    public void SetChannel(int channelId) => _device.SetChannel(channelId);
    public void NextChannel() => _device.SetChannel(_device.GetCurrentChannelId() + 1);
    public void PreviousChannel() => _device.SetChannel(_device.GetCurrentChannelId() - 1);
}
