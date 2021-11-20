namespace DesignPatterns.Creational.Builder.Stepwise.Interfaces;

public interface ISpecifyAirplaneType
{
    ISpecifySeatsCount OfType(AirplaneType type);
}
