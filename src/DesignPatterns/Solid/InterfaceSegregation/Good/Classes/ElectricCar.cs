using DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces;

namespace DesignPatterns.Solid.InterfaceSegregation.Good.Classes
{
    public class ElectricCar : IBaseVehicle, IElectricVehicle
    {
        public void Accelerate()
        {
            // Accelerate
        }

        public void Brake()
        {
            // Brake
        }

        public void CalculateBatteryPercentage()
        {
            // Calculate
        }

        public void RechargeBatteries()
        {
            // Recharge
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
}
