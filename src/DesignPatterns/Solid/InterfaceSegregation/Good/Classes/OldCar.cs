using DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces;

namespace DesignPatterns.Solid.InterfaceSegregation.Good.Classes;

public class OldCar : IBaseVehicle
{
    public void Accelerate()
    {
        // Accelerate
    }

    public void Brake()
    {
        // Brake
    }

    public void StartEngine()
    {
        // Start Engine
    }

    public void StopEngine()
    {
        // Stop Engine
    }
}
