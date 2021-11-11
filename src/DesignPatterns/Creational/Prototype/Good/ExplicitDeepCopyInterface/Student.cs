namespace DesignPatterns.Creational.Prototype.Good.ExplicitDeepCopyInterface
{
    public class Student : IPrototype<Student>
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

        public Student DeepCopy()
        {
            return new Student(FullName, Subjects, ContactInfo.DeepCopy());
        }

        public override string ToString()
        {
            return $"Full name: {FullName}\n\nContact information:\n{ContactInfo}\n\nSubjects:\n{string.Join(",", Subjects)}\n\n{new string('=', 50)}\n\n";
        }
    }
}
