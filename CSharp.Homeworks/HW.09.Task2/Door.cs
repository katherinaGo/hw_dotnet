namespace HW._09.Task2;

public class Door
{
    private string _color;

    protected internal Door(string color)
    {
        _color = color;
    }

    public string Color
    {
        get { return _color; }
        set { _color = value ?? throw new ArgumentNullException(nameof(value)); }
    }

    public void ShowData(string color)
    {
        Console.WriteLine("I am  a  door,  my  color  is {0}", color);
    }
}