using System;

namespace DesignPatterns.Creational.Prototype.Bad;

public class ContactInfo : ICloneable
{
    public string PhoneNumber;
    public string Address;

    public ContactInfo(string phoneNumber, string address)
    {
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public override string ToString() => $"\tPhone number: {PhoneNumber}\n\tAddress: {Address}";

    public object Clone() => new ContactInfo(PhoneNumber, Address);
}
