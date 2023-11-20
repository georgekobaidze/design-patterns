using System;

namespace DesignPatterns.Behavioral.State.ConcreteStates;

public class EnabledState : IButtonState
{
    public void Press()
    {
        Console.WriteLine("Button pressed: turning the phone off.");
    }
}
