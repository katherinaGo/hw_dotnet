namespace HW._11.Task1;

public class Motorcycle : BaseEntity
{
    private string _name;
    private string _model;
    private int _year;
    private int _odometer;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Model
    {
        get => _model;
        set => _model = value;
    }

    public int Year
    {
        get => _year;
        set => _year = value;
    }

    public int Odometer
    {
        get => _odometer;
        set => _odometer = value;
    }

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
        return $"Name:'{_name}'; Model: '{_model}', Year of issue: '{_year}', Odometer: '{_odometer}'.\n";
    }
}