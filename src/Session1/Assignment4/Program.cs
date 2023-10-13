namespace Assignment4;

static class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(0);
        
        Console.WriteLine("Enter the amount of gas to refuel:");
        Int32.TryParse(Console.ReadLine(), out int gasAmount);

        car.Refuel(gasAmount);
        car.Drive();
    }
}
