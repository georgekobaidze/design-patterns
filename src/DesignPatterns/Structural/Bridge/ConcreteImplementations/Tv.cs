using DesignPatterns.Structural.Bridge.Bridge;

namespace DesignPatterns.Structural.Bridge.ConcreteImplementations;

public class Tv : IDevice
{
    private int _channelId = 0;
    private int _volume = 20;
    private bool _isTurnedOn = false;

    public int GetCurrentChannelId() => _channelId;

    public int GetVolume() => _volume;

    public bool IsTurnedOn() => _isTurnedOn;

    public void SetChannel(int channelId) => _channelId = channelId;

    public void SetVolume(int volume) => _volume = volume;

    public void TurnOff() => _isTurnedOn = false;

    public void TurnOn() => _isTurnedOn = true;
}
