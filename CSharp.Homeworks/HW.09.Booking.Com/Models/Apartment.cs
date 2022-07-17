namespace HW._09.Booking.Com.Models;

public class Apartment : RentPlace
{
    private int _amountOfRooms;
    private int _amountOfBeds;

    public Apartment(int amountOfRooms, int amountOfBeds)
    {
        _amountOfRooms = amountOfRooms;
        _amountOfBeds = amountOfBeds;
    }

    public int AmountOfRooms
    {
        get => _amountOfRooms;
    }

    public int AmountOfBeds
    {
        get => _amountOfBeds;
    }
}