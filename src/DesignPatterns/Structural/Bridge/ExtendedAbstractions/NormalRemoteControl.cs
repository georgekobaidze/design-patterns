using DesignPatterns.Structural.Bridge.Bridge;

namespace DesignPatterns.Structural.Bridge.ExtendedAbstractions;

public class NormalRemoteControl : RemoteControl
{
    public NormalRemoteControl(IDevice device) : base(device)
    {
    }
}
