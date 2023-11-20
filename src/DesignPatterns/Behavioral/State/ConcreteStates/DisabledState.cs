using System;

namespace DesignPatterns.Behavioral.State.ConcreteStates;

public class DisabledState : IButtonState
{
    public void Press()
    {
        Console.WriteLine("Button pressed: turning the phone on");
    }
}
