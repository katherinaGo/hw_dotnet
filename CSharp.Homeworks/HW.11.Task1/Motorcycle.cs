namespace HW._11.Task1;

public class Motorcycle : BaseEntity
{
    private string _name;
    private string _model;
    private int _year;
    private int _odometer;

    public string Name => _name;

    public string Model => _model;

    public int Year => _year;

    public int Odometer => _odometer;

    public Motorcycle(string name, string model, int year, int odometer)
    {
         Id = Guid.NewGuid();
        _name = name;
        _model = model;
        _year = year;
        _odometer = odometer;
    }

    public override string ToString()
    {
        return String.Format("Name:'{0}'; Model: '{1}', Year of issue: '{2}', Odometr: '{3}'.\n", _name, _model, _year, _odometer);
    }
}