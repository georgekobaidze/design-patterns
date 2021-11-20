namespace DesignPatterns.Creational.Builder.Faceted.Builders;

public class PersonBuilder //Facade
{
    // Reference
    protected Person person = new();

    // This is for exposing the PersonJobBuilder type object from PersonBuilder
    public PersonJobBuilder Works => new(person);

    // This is for exposing the PersonAddressBuilder type object from PersonBuilder
    public PersonAddressBuilder Lives => new(person);

    public static implicit operator Person(PersonBuilder personBuilder) => personBuilder.person;
}
