namespace HW._09.Task2;

public class SmallApartment : House
{
    private const int AreaOfSmallApart = 50;

    public SmallApartment() : base(AreaOfSmallApart, new Door("purple"))
    {
    }
}