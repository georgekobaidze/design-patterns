using DesignPatterns.Behavioral.Command.Models;

namespace DesignPatterns.Behavioral.Command.WithCommandPattern.ConcreteCommands;

public class IncreaseVolumeCommand : ICommand
{
    private readonly StereoSystem _stereoSystem;

    public IncreaseVolumeCommand(StereoSystem stereoSystem)
    {
        _stereoSystem = stereoSystem;
    }
    
    public void Execute()
    {
        _stereoSystem.IncreaseVolume();
    }
}
