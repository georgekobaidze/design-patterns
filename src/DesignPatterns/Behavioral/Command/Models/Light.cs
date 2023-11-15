using System;

namespace DesignPatterns.Behavioral.Command.Models;

public class Light
{
    public void Toggle()
    {
        Console.WriteLine("Toggling lights.");
    }
}
