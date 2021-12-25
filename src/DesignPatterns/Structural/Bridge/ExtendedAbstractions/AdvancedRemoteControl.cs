using DesignPatterns.Structural.Bridge.Bridge;

namespace DesignPatterns.Structural.Bridge.ExtendedAbstractions;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device)
    {
    }

    public void Mute() => _device.SetVolume(0);
}
