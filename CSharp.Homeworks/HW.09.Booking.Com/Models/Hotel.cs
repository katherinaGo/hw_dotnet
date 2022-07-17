namespace HW._09.Booking.Com.Models;

public class Hotel : RentPlace
{
    private int _amountOfBeds;
    private bool _withBreakfast;

    public Hotel(int amountOfBeds, bool withBreakfast)
    {
        _amountOfBeds = amountOfBeds;
        _withBreakfast = withBreakfast;
    }

    public int AmountOfBeds
    {
        get => _amountOfBeds;
    }

    public bool WithBreakfast
    {
        get => _withBreakfast;
    }
}