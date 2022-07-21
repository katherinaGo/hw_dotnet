namespace HW._11.Task1;

public interface IMotorcycleRepository
{
    public Motorcycle GetMotorcycleByID(Motorcycle motorcycle, Guid idOfBike);

    public void GetAllMotorcycles();

    public void CreateMotorcycle(string name, string model, int year, int odometr);

    public void UpdateMotorcycle();

    public void DeleteMotorcycle(Motorcycle motorcycle);

}