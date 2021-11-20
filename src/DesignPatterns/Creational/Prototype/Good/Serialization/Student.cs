namespace DesignPatterns.Creational.Prototype.Good.Serialization;

public class Student
{
    public string FullName;
    public string[] Subjects;
    public ContactInfo ContactInfo;

    public Student() { } // Needed for serializer

    public Student(string fullName, string[] subjects, ContactInfo contactInfo)
    {
        FullName = fullName;
        Subjects = subjects;
        ContactInfo = contactInfo;
    }

    public override string ToString() 
        => $"Full name: {FullName}\n\nContact information:\n{ContactInfo}\n\nSubjects:\n{string.Join(",", Subjects)}\n\n{new string('=', 50)}\n\n";
}
