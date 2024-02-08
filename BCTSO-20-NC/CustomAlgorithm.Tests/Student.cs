using System.Diagnostics.CodeAnalysis;

namespace CustomAlgorithm.Tests
{
    class StudentEquilityComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y) => x.FullName == y.FullName;
        public int GetHashCode([DisallowNull] Student obj) => obj.FullName.Length;
    }

    public class Student
    {
        public string FullName { get; set; }
        public Student(string fullName)
        {
            FullName = fullName;
        }
        //public override bool Equals(object obj) => new StudentEquilityComparer().Equals(this, obj as Student);
        //public override int GetHashCode() => new StudentEquilityComparer().GetHashCode(this);
    }
}
