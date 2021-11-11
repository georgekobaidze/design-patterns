using System;

namespace DesignPatterns.Creational.Prototype.Bad
{
    public class ContactInfo : ICloneable
    {
        public string PhoneNumber;
        public string Address;

        public ContactInfo(string phoneNumber, string address)
        {
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public override string ToString()
        {
            return $"\tPhone number: {PhoneNumber}\n\tAddress: {Address}";
        }

        public object Clone()
        {
            return new ContactInfo(PhoneNumber, Address);
        }
    }
}
