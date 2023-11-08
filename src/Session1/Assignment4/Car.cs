namespace Assignment4;

public class Car : IVehicle
{
    private int _gasAmount;

    public Car(int gasAmount)
    {
        _gasAmount = gasAmount;
    }

    public void Drive()
    {
        if (_gasAmount > 0)
        {
            Console.WriteLine("Driving...");
        }
    }

    public bool Refuel(int gasAmount)
    {
        _gasAmount += gasAmount;

        return true;
    }
}
