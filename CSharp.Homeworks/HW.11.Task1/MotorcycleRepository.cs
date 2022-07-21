namespace HW._11.Task1;

public class MotorcycleRepository : IMotorcycleRepository
{
    private static List<Motorcycle> _motorcycles = new List<Motorcycle>();

    public Motorcycle GetMotorcycleByID(Motorcycle motorcycle, Guid idOfBike)
    {
        for (int i = 0; i < _motorcycles.Count; i++)
        {
            if ( _motorcycles.ElementAt(i).Equals(motorcycle))
            {
                Console.WriteLine($"Motorcycle with ID '{motorcycle.Id}' is found. It's name '{motorcycle.Name}'.");
            }
        }
        return motorcycle;
    }

    public void GetAllMotorcycles()
    {
        Console.WriteLine($"There are {_motorcycles.Count} in the list. The list of bikes here: ");
        foreach (Motorcycle bike in _motorcycles)
        {
            Console.Write(bike.ToString());   
        }
    }

    public void CreateMotorcycle(string name, string model, int year, int odometr)
    {
       Motorcycle motorcycle = new Motorcycle(name, model, year, odometr);
       _motorcycles.Add(motorcycle);
       Console.WriteLine($"Motocycle '{motorcycle.Id}' with name '{motorcycle.Name}' was created and added to the list.");
    }

    public void UpdateMotorcycle()
    {
        throw new NotImplementedException();
    }

    public void DeleteMotorcycle(Motorcycle motorcycle)
    {
        _motorcycles.Remove(motorcycle);
        Console.WriteLine($"Motocycle '{motorcycle.Id}', with name '{motorcycle.Name}' was removed from the list.");
    }
}
