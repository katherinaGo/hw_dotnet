namespace HW._09.Task2;

public class Person
{
    private string _name;
    private House _house;

    public Person(string name)
    {
        _name = name;
    }

    public string Name
    {
        get { return _name; }
    }

    public House House
    {
        get { return _house; }
        set { _house = value; }
    }

    public void ShowData()
    {
        Console.WriteLine("My name is {0}. Area of my house is {1}. Color of my door is {2}.",
            _name, _house.Area, _house.Door.Color);
    }
}