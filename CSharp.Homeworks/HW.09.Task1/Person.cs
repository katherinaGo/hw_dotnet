namespace HW._09.Task1;

public class Person
{
    private int _age;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public void SayHello(string name)
    {
        Console.WriteLine("Hello everybody! I am {0}.", name);
    }
}