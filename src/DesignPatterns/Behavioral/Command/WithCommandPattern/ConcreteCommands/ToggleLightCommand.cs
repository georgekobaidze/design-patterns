using DesignPatterns.Behavioral.Command.Models;

namespace DesignPatterns.Behavioral.Command.WithCommandPattern.ConcreteCommands;

public class ToggleLightCommand : ICommand
{
    private readonly Light _light;

    public ToggleLightCommand(Light light)
    {
        _light = light;
    }
    
    public void Execute()
    {
        _light.Toggle();
    }
}
