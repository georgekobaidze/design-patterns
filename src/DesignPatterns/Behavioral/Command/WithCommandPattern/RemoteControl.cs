namespace DesignPatterns.Behavioral.Command.WithCommandPattern;

public class RemoteControl
{
    private ICommand _command;

    public void SetUpCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}
