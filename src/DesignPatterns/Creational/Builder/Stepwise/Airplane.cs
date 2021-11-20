namespace DesignPatterns.Creational.Builder.Stepwise;

public class Airplane
{
    public AirplaneType Type { get; set; }
    public int SeatsCount { get; set; }

    public override string ToString() => $"Airplane type: {Type}\nSeats count: {SeatsCount}";
}
