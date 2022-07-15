namespace HW._09.Task2;

public class House
{
    private int _area;
    private Door _door;

    public House(int area, Door door)
    {
        _area = area;
        _door = door;
    }

    public int Area
    {
        get { return _area; }
        set { _area = value; }
    }
    
    public Door Door
    {
        get { return _door; }
        set { _door = value; }
    }

    public void ShowData(int area)
    {
        Console.WriteLine("I  am  a  house,  my  area  is  {0}  m2.", area);
    }

    public Door GetDoor()
    {
        return _door;
    }
}