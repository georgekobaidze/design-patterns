namespace DesignPatterns.Solid.InterfaceSegregation.Bad;

public interface IVehicle
{
    void StartEngine();
    void StopEngine();
    void Accelerate();
    void Brake();
    void RechargeBatteries();
    void CalculateBatteryPercentage();
    void AttachToTrailer();
    void DetachFromTrailer();
}
