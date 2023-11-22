using DesignPatterns.Behavioral.Command.Models;

namespace DesignPatterns.Behavioral.Command.WithCommandPattern.ConcreteCommands;

public class TurnOnTelevisionCommand : ICommand
{
    private readonly Television _television;

    public TurnOnTelevisionCommand(Television television)
    {
        _television = television;
    }
    
    public void Execute()
    {
        _television.TurnOn();
    }
}
