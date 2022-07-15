namespace HW._09.Task3;

public class ComputerPrograms : Catalog
{
    private string _catalogName;

    public ComputerPrograms(string programName, string catalogName, int code, string category, string size) : base(
        programName, code, category, size)
    {
        _catalogName = catalogName;
    }

    public void RetrieveInformation()
    {
        Console.WriteLine("This {0} called '{1}'. Category - {2}. It's size around {3} GB.", _catalogName, _name,
            _category, _size);
    }
}