
internal class StudentService : IStudentService
{
    Student[] Students=new Student[0];
    public void Add(string fullName)
    {
        Array.Resize(ref Students, Students.Length+1);
     
        Students[Students.Length - 1] = new Student { FullName = fullName };

    }
}
