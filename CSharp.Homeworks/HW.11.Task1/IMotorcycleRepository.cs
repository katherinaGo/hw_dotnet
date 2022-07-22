namespace HW._11.Task1;

public interface IMotorcycleRepository
{
    public Motorcycle GetMotorcycleByID(Guid id);

    public void GetAllMotorcycles();

    public Motorcycle CreateMotorcycle(string name, string model, int year, int odometer);

    public Motorcycle UpdateMotorcycle(Motorcycle motorcycle, string name, string model, int year, int odometer);

    public void DeleteMotorcycle(Motorcycle motorcycle);
}