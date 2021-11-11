namespace DesignPatterns.Creational.Builder.Classic.Good
{
    public interface ICarBuilder
    {
        public ICarBuilder SetMake(string make);
        public ICarBuilder SetModel(string model);
        public ICarBuilder SetManufactureDate(string manufactureDate);
        public Car Build();
    }
}
