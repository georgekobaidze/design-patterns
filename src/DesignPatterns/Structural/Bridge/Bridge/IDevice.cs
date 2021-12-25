namespace DesignPatterns.Structural.Bridge.Bridge;

public interface IDevice
{
    bool IsTurnedOn();
    void TurnOn();
    void TurnOff();
    void SetVolume(int volume);
    int GetVolume();
    void SetChannel(int channelId);
    int GetCurrentChannelId();
}
