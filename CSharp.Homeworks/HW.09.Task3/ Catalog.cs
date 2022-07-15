namespace HW._09.Task3;

public class Catalog
{
    protected string _name;
    protected int _code;
    protected string _category;
    protected string _size;

    public Catalog(string name, int code, string category, string size)
    {
        _name = name;
        _code = code;
        _category = category;
        _size = size;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Code
    {
        get => _code;
        set => _code = value;
    }

    public string Category
    {
        get => _category;
        set => _category = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Size
    {
        get => _size;
        set => _size = value;
    }

    public void Play()
    {
    }

    public void RetrieveInformation()
    {
    }
}