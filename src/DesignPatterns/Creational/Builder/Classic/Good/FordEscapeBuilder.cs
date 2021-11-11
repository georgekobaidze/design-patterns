namespace DesignPatterns.Creational.Builder.Classic.Good
{
    public class FordEscapeBuilder
    {
        private ICarBuilder _builder;
        public FordEscapeBuilder(ICarBuilder builder)
        {
            _builder = builder;
        }

        public Car Build() => _builder
                .SetMake("Ford")
                .SetModel("Escape")
                .SetManufactureDate("05/05/2011")
                .Build();

    }
}
