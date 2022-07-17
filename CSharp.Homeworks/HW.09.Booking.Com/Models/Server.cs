namespace HW._09.Booking.Com.Models;

public class Server
{
    public void CreateAccount(Account account)
    {
        Console.WriteLine("Your account is created.");
        Console.WriteLine("Full name is {0}, passport number is {1}, phone number: {2}",
        account.FullName, account.PassportNumber, account.PhoneNumber);
    }

    public void LoginToAccount(Account account, string login, string password)
    {
        if (!string.IsNullOrWhiteSpace(login) && !string.IsNullOrWhiteSpace(password) )
        {
            if (account.Login.Equals(login) && account.Password.Equals(password))
            {
            Console.WriteLine("You are logged in.");
            }
            else
            {
            Console.WriteLine("Wrong login or password. Try again.");
            }
        }
        else
        {
        Console.WriteLine("Login should contain at least 2 symbols.");
        Console.WriteLine("Password should contain at least 8 symbols.");
        }
    }

    public void Search(string city, string ddmm, int amountOfDays, int amountOfPeople)
    {
        Console.WriteLine("Hotels and apartments are found in {0} on {1} for {2} days, for {3} person(s).",
            city, ddmm,amountOfDays, amountOfPeople);
    }

    public void BookAndPurchase(Account account, bool isPaidByCash, Hotel hotel)
    {
        string withBreakfast;
        if (hotel.WithBreakfast.Equals(true))
        {
            withBreakfast = "Breakfast included.";
        }
        else
        {
            withBreakfast = "Breakfast is not included.";
        }
        
        Console.WriteLine("{0} booked hotel with {1} beds. {2} ", account.FullName, hotel.AmountOfBeds, withBreakfast);
        isPaidByCashOrCard(account, isPaidByCash);
    }

    public void BookAndPurchase(Account account, bool isPaidByCash, Apartment apartment)
    {
        Console.WriteLine("{0} booked apartment with {1} room(s) with {2} bed(s). ",
            account.FullName, apartment.AmountOfRooms, apartment.AmountOfBeds);
        isPaidByCashOrCard(account, isPaidByCash);
    }

    private void isPaidByCashOrCard(Account account, bool isPaidByCash)
    {
        if (isPaidByCash.Equals(true))
        {
            Console.WriteLine("{0} paid by cash.", account.FullName);
        }
        else
        {
            Console.WriteLine("{0} paid by card.", account.FullName);
        }
    }
}