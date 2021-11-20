namespace DesignPatterns.Creational.Prototype.Good.CopyConstructors;

public class Student
{
    public string FullName;
    public string[] Subjects;
    public ContactInfo ContactInfo;

    public Student(string fullName, string[] subjects, ContactInfo contactInfo)
    {
        FullName = fullName;
        Subjects = subjects;
        ContactInfo = contactInfo;
    }

    public Student(Student other)
    {
        FullName = other.FullName;
        Subjects = other.Subjects;
        ContactInfo = new ContactInfo(other.ContactInfo);
    }

    public override string ToString() 
        => $"Full name: {FullName}\n\nContact information:\n{ContactInfo}\n\nSubjects:\n{string.Join(",", Subjects)}\n\n{new string('=', 50)}\n\n";
}
