namespace DesignPatterns.Solid.InterfaceSegregation.Good.Interfaces;

public interface ITruck : IBaseVehicle
{
    void AttachToTrailer();
    void DetachFromTrailer();
}
