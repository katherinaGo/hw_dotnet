namespace HW._09.Booking.Com.Models;

public class RentPlace
{
    protected string _name;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }
}