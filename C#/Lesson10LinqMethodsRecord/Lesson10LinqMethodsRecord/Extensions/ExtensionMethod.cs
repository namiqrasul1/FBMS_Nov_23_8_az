using Lesson10LinqMethodsRecord.Students;

namespace Lesson10LinqMethodsRecord.Extensions
{
    internal static class ExtensionMethod
    {
        public static Student GetOlderStudent(this List<Student> students)
        {
            if (students.Any())
            {
                Student result = students.First();

                foreach (Student student in students)
                {
                    if(result.DateOfBirth.CompareTo(student.DateOfBirth) == 1)
                        result = student;
                }
                return result;
            }
            throw new ArgumentException("List is empty");
        }
    }
}
