namespace DesignPatterns.Creational.Builder.Faceted.Builders
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string street)
        {
            person.Street = street;
            return this;
        }

        public PersonAddressBuilder WithPostalCode(string postalCode)
        {
            person.PostalCode = postalCode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.City = city;
            return this;
        }
    }
}
