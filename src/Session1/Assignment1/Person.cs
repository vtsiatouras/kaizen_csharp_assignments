namespace Assignment1;

public class Person
{
    private int _age;

    public void Greet()
    {
        Console.WriteLine("Hello!");
    }
    
    public void SetAge(int age)
    {
        _age = age;
    }

    public void ShowAge()
    {
        Console.WriteLine($"My age is: {_age} years old");
    }
}
