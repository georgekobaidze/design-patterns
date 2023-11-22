using DesignPatterns.Behavioral.Command.Models;

namespace DesignPatterns.Behavioral.Command.WithoutCommandPattern;

public class RemoteControl
{
    private Television television;
    private StereoSystem stereoSystem;
    private Light light;
    
    public RemoteControl(Television tv, StereoSystem stereo, Light light)
    {
        this.television = tv;
        this.stereoSystem = stereo;
        this.light = light;
    }

    public void PressTelevisionButton()
    {
        television.TurnOn();
    }

    public void PressStereoButton()
    {
        stereoSystem.IncreaseVolume();
    }

    public void PressLightButton()
    {
        light.Toggle();
    }
}
