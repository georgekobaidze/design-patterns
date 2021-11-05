namespace DesignPatterns.Creational.Builder.Classic.Good
{
    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public ICarBuilder SetMake(string make)
        {
            _car.Make = make;
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilder SetManufactureDate(string manufactureDate)
        {
            _car.ManufactureDate = manufactureDate;
            return this;
        }

        public Car Build() => _car;
    }
}
