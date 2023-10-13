namespace Assignment3;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a name for the dog:");
        string dogName = Console.ReadLine() ?? "";

        Dog dog = new Dog();
        dog.SetName(dogName);
        
        Console.WriteLine($"Dog's name: {dog.GetName()}");
        dog.Eat();
    }
}
