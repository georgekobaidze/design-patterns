using System;

namespace DesignPatterns.Behavioral.State.ConcreteStates;

public class PhotoState : IButtonState
{
    private readonly bool _takePhotoWhenPowerButtonIsPressed;
    
    public PhotoState(bool takePhotoWhenPowerButtonIsPressed)
    {
        _takePhotoWhenPowerButtonIsPressed = takePhotoWhenPowerButtonIsPressed;
    }
    
    public void Press()
    {
        if (_takePhotoWhenPowerButtonIsPressed)
            Console.WriteLine("Button is pressed: taking a photo.");
        else
        {
            Console.WriteLine("Button is pressed: tuning the phone off.");
        }
    }
}
