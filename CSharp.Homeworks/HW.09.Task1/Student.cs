namespace HW._09.Task1;

public class Student : Person
{
    public void GoToClasses()
    {
        Console.WriteLine("I’m going to class.");
    }

    public void ShowAge(int age)
    {
        Console.WriteLine("My age is: {0} years old.\n", age);
    }
}