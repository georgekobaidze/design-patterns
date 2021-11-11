namespace DesignPatterns.Creational.Builder.Stepwise.Interfaces
{
    public interface ISpecifySeatsCount
    {
        IBuildAirplane WithSeatsNumber(int count);
    }
}
