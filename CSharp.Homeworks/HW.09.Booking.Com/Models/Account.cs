namespace HW._09.Booking.Com.Models;

public class Account
{
    private string _fullName;
    private string _passportNumber;
    private string _phoneNumber;
    private string _login;
    private string _password;
    private Hotel _hotel;
    
    private Apartment _apartment;
    
    public string FullName
    {
        get => _fullName;
        set => _fullName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string PassportNumber
    {
        get => _passportNumber;
        set => _passportNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string PhoneNumber
    {
        get => _phoneNumber;
        set => _phoneNumber = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Account(string fullName, string passportNumber, string phoneNumber, string login, string password)
    {
        _fullName = fullName;
        _passportNumber = passportNumber;
        _phoneNumber = phoneNumber;
        _login = login;
        _password = password;
    }
    
    protected internal string Login
    {
        get => _login;
    }

    protected internal string Password
    {
        get => _password;
    }
    
    public Hotel Hotel
    {
        get => _hotel;
        set => _hotel = value ?? throw new ArgumentNullException(nameof(value));
    }

    public Apartment Apartment
    {
        get => _apartment;
        set => _apartment = value ?? throw new ArgumentNullException(nameof(value));
    }

}
