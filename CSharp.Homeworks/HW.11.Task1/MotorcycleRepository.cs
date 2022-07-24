using Serilog;
using static HW._11.Task1.Logger;

namespace HW._11.Task1;

public class MotorcycleRepository : IMotorcycleRepository
{
    private static List<Motorcycle> _motorcycles = new List<Motorcycle>();
    private string _nothingWasFound = DateTime.UtcNow + " UTC; Nothing was found";
    private string error = DateTime.UtcNow + " UTC; Something went wrong";

    public Motorcycle? GetMotorcycleByID(Guid id)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                return bike;
            }
        }

        CreateLogger();
        Log.Error(_nothingWasFound);
        return null;
    }

    public void GetAllMotorcycles()
    {
        Console.WriteLine($"There are {_motorcycles.Count} in the list. The list of bikes here: ");
        foreach (Motorcycle bike in _motorcycles)
        {
            Console.Write(bike);
        }

        CreateLogger();
        Log.Information(DateTime.UtcNow + " UTC; All bikes are displayed");
    }

    public Motorcycle CreateMotorcycle(string name, string model, int year, int odometer)
    {
        Motorcycle motorcycle = new Motorcycle(name, model, year, odometer);
        _motorcycles.Add(motorcycle);

        CreateLogger();
        Log.Information(DateTime.UtcNow +
                        $" UTC; Motorcycle '{motorcycle.Id}' with name '{motorcycle.Name}' was created and added to the list");

        return motorcycle;
    }

    public Motorcycle? UpdateMotorcycle(Guid id, string nameChangeTo, string modelChangeTo,
        int yearChangeTo, int odometerChangeTo)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                bike.Name = nameChangeTo;
                bike.Model = modelChangeTo;
                bike.Year = yearChangeTo;
                bike.Odometer = odometerChangeTo;
                return bike;
            }
        }

        CreateLogger();
        Log.Error(error);
        return null;
    }

    public Motorcycle UpdateMotorcycleName(Guid id, string name)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                bike.Name = name;
                return bike;
            }
        }

        CreateLogger();
        Log.Error(error);
        return null;
    }

    public Motorcycle? UpdateMotorcycleModel(Guid id, string model)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                bike.Model = model;
                return bike;
            }
        }

        CreateLogger();
        Log.Error(error);
        return null;
    }

    public Motorcycle? UpdateMotorcycleYear(Guid id, int year)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                bike.Year = year;
                return bike;
            }
        }

        CreateLogger();
        Log.Error(error);
        return null;
    }

    public Motorcycle? UpdateMotorcycleOdometer(Guid id, int odometer)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                bike.Odometer = odometer;
                return bike;
            }
        }

        CreateLogger();
        Log.Error(error);
        return null;
    }

    public void DeleteMotorcycle(Motorcycle motorcycle)
    {
        _motorcycles.Remove(motorcycle);
        CreateLogger();
        Log.Information(DateTime.UtcNow +
                        $" UTC; Motorcycle '{motorcycle.Id}', with name '{motorcycle.Name}' was removed from the list");
    }
}