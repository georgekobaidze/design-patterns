namespace DesignPatterns.Creational.Builder.Classic.Bad;

public class BadCarBuilder
{
    private Car _car = new();

    public BadCarBuilder SetMake(string make)
    {
        _car.Make = make;
        return this;
    }

    public BadCarBuilder SetModel(string model)
    {
        _car.Model = model;
        return this;
    }

    public BadCarBuilder SetManufactureDate(string manufactureDate)
    {
        _car.ManufactureDate = manufactureDate;
        return this;
    }

    public Car Build() => _car;

    // Do NOT ever, ever, EVER implement a builder pattern that way!
}
