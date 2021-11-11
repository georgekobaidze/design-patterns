namespace DesignPatterns.Creational.Builder.Faceted.Builders
{
    public class PersonBuilder //Facade
    {
        // Reference
        protected Person person = new Person();

        // This is for exposing the PersonJobBuilder type object from PersonBuilder
        public PersonJobBuilder Works => new PersonJobBuilder(person);

        // This is for exposing the PersonAddressBuilder type object from PersonBuilder
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.person;
        }
    }
}
