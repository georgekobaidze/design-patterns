namespace DesignPatterns.Solid.InterfaceSegregation.Bad
{
    public class Vehicle : IVehicle
    {
        public void StartEngine()
        {
            // Start Engine
        }

        public void StopEngine()
        {
            // Stop Engine
        }
        public void Accelerate()
        {
            // Accelerate
        }

        public void CalculateBatteryPercentage()
        {
            // Calculate
        }

        public void RechargeBatteries()
        {
            // Recharge
        }

        public void Brake()
        {
            // Brake
        }

        public void AttachToTrailer()
        {
            // Attach
        }

        public void DetachFromTrailer()
        {
            // Detach
        }
    }
}
