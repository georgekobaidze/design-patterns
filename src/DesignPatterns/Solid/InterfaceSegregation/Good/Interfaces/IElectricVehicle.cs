namespace DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces;

public interface IElectricVehicle : IBaseVehicle
{
    void RechargeBatteries();
    void CalculateBatteryPercentage();
}
