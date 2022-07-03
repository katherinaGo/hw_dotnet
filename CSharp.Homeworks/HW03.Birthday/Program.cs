int monthOfBirth, yearOfBirth, age, yearToday, monthToday;
Console.WriteLine("Input your month number of birth.");
monthOfBirth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input year of your birth.");
yearOfBirth = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Remind, please, what the year is today...");
yearToday = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("... and what is the month number now?");
monthToday = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Let's calculate your age.");

age = yearToday - yearOfBirth;

if (monthToday >= monthOfBirth)
{
    Console.WriteLine("Your age is " + age + ".");
}
else
{
    age--;
    Console.WriteLine("Your age is " + age + ". Your birthday is coming... Yahoo!");
}