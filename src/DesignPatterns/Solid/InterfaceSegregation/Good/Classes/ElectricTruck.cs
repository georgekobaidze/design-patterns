using DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces;
using DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces.CustomInterfaces;

namespace DesignPatterns.Solid.InterfaceSegregation.Good.Classes
{
    // This actually is a decorator pattern
    public class ElectricTruck : IElectricTruck
    {
        private IBaseVehicle _baseVehicle;
        private IElectricVehicle _electricVehicle;
        private ITruck _truck;

        public ElectricTruck(IBaseVehicle baseVehicle, IElectricVehicle electricVehicle, ITruck truck)
        {
            _baseVehicle = baseVehicle;
            _electricVehicle = electricVehicle;
            _truck = truck;
        }

        public void Accelerate()
        {
            _baseVehicle.Accelerate();
        }

        public void AttachToTrailer()
        {
            _truck.AttachToTrailer();
        }

        public void Brake()
        {
            _baseVehicle.Brake();
        }

        public void CalculateBatteryPercentage()
        {
            _electricVehicle.CalculateBatteryPercentage();
        }

        public void DetachFromTrailer()
        {
            _truck.DetachFromTrailer();
        }

        public void RechargeBatteries()
        {
            _electricVehicle.RechargeBatteries();
        }

        public void StartEngine()
        {
            _baseVehicle.StartEngine();
        }

        public void StopEngine()
        {
            _baseVehicle.StopEngine();
        }
    }
}
