namespace DesignPatterns.Creational.Prototype.Good.CopyConstructors;

public class ContactInfo
{
    public string PhoneNumber;
    public string Address;

    public ContactInfo(string phoneNumber, string address)
    {
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public ContactInfo(ContactInfo other)
    {
        PhoneNumber = other.PhoneNumber;
        Address = other.Address;
    }

    public override string ToString() => $"\tPhone number: {PhoneNumber}\n\tAddress: {Address}";
}
