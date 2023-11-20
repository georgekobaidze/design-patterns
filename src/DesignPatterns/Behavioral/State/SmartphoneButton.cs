using System;
using DesignPatterns.Behavioral.State.ConcreteStates;

namespace DesignPatterns.Behavioral.State;

public class SmartphoneButton
{
    private IButtonState _currentState;

    public SmartphoneButton()
    {
        _currentState = new DisabledState();
    }

    public IButtonState State
    {
        get { return _currentState; }
        set
        {
            _currentState = value;
            Console.WriteLine($"Button state changed to {_currentState.GetType().Name}");
        }
    }
    
    public void Press()
    {
        _currentState.Press();
    }
}
