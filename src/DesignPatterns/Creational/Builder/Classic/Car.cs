namespace DesignPatterns.Creational.Builder.Classic
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string ManufactureDate { get; set; }

        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nManufacture Date: {ManufactureDate}";
        }
    }
}
