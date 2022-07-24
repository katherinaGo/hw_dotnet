namespace HW._11.Task1;

public interface IMotorcycleRepository
{
    public Motorcycle GetMotorcycleByID(Guid id);

    public void GetAllMotorcycles();

    public Motorcycle CreateMotorcycle(string name, string model, int year, int odometer);

    public Motorcycle UpdateMotorcycle(Guid id, string name, string model, int year, int odometer);

    public Motorcycle UpdateMotorcycleName(Guid id, string name);

    public Motorcycle UpdateMotorcycleModel(Guid id, string model);

    public Motorcycle UpdateMotorcycleYear(Guid id, int year);

    public Motorcycle UpdateMotorcycleOdometer(Guid id, int odometer);

    public void DeleteMotorcycle(Motorcycle motorcycle);
}