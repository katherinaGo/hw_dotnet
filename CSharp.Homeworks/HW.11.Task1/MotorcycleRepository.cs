namespace HW._11.Task1;

public class MotorcycleRepository : IMotorcycleRepository
{
    private static List<Motorcycle> _motorcycles = new List<Motorcycle>();

    public Motorcycle? GetMotorcycleByID(Guid id)
    {
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(id))
            {
                return bike;
            }
        }

        Console.WriteLine("Nothing was found.");
        return null;
    }

    public void GetAllMotorcycles()
    {
        Console.WriteLine($"There are {_motorcycles.Count} in the list. The list of bikes here: ");
        foreach (Motorcycle bike in _motorcycles)
        {
            Console.Write(bike.ToString());
        }
    }

    public Motorcycle CreateMotorcycle(string name, string model, int year, int odometer)
    {
        Motorcycle motorcycle = new Motorcycle(name, model, year, odometer);
        _motorcycles.Add(motorcycle);
        Console.WriteLine(
            $"Motorcycle '{motorcycle.Id}' with name '{motorcycle.Name}' was created and added to the list.");
        return motorcycle;
    }

    public Motorcycle? UpdateMotorcycle(Motorcycle motorcycle, string nameChangeTo, string modelChangeTo,
        int yearChangeTo, int odometerChangeTo)
    {
        Console.Write(
            $"Bike '{motorcycle.Id}', {motorcycle} is going to be updated... Wait a second. It's changed to: \n");
        foreach (Motorcycle bike in _motorcycles)
        {
            if (bike.Id.Equals(motorcycle.Id))
            {
                bike.Name = nameChangeTo;
                bike.Model = modelChangeTo;
                bike.Year = yearChangeTo;
                bike.Odometer = odometerChangeTo;
                return bike;
            }
        }

        Console.WriteLine("Something went wrong.");
        return null;
    }

    public void DeleteMotorcycle(Motorcycle motorcycle)
    {
        _motorcycles.Remove(motorcycle);
        Console.WriteLine($"Motorcycle '{motorcycle.Id}', with name '{motorcycle.Name}' was removed from the list.");
    }
}