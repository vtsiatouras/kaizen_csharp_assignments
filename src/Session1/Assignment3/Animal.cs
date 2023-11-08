namespace Assignment3;

public abstract class Animal
{
    private string _name;

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void Eat();
}
