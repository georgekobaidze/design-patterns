namespace DesignPatterns.Creational.Prototype.Good.Serialization
{
    public class ContactInfo
    {
        public string PhoneNumber;
        public string Address;

        public ContactInfo() { } // Needed for serializer

        public ContactInfo(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"\tPhone number: {PhoneNumber}\n\tAddress: {Address}";
        }
    }
}
