namespace DesignPatterns.Creational.Prototype.Good.ExplicitDeepCopyInterface;

public class ContactInfo : IPrototype<ContactInfo>
{
    public string PhoneNumber;
    public string Address;

    public ContactInfo(string phoneNumber, string address)
    {
        PhoneNumber = phoneNumber;
        Address = address;
    }

    public ContactInfo DeepCopy() => new(PhoneNumber, Address);

    public override string ToString() => $"\tPhone number: {PhoneNumber}\n\tAddress: {Address}";
}
