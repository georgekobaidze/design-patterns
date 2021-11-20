using System;

namespace DesignPatterns.Creational.Prototype.Bad;

public class Student : ICloneable
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

    public override string ToString() 
        => $"Full name: {FullName}\n\nContact information:\n{ContactInfo}\n\nSubjects:\n{string.Join(",", Subjects)}\n\n{new string('=', 50)}\n\n";

    public object Clone() => new Student(FullName, Subjects, (ContactInfo)ContactInfo.Clone());
}
