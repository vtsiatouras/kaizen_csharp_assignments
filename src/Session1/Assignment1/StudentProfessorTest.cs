namespace Assignment1;

static class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Console.WriteLine("");

        Student student = new Student();
        student.SetAge(10);
        student.Greet();
        student.ShowAge();

        Console.WriteLine("");

        Teacher teacher = new Teacher();
        teacher.SetAge(30);
        teacher.Greet();
        teacher.Explain();
    }
}
