// Требование к интерфейсу. 
//• Запрос числа 1 (ввод с клавиатуры) 
//• Запрос числа 2 (ввод с клавиатуры) 
//• Вывод суммы этих чисел  
//• В случае не валидного ввода данных (любой символ отличны от числа) – вывод сообщения на 
//экран, о том, что введенный символ не является числом и снова попросить пользователя ввести число

string a1, b1;
double a, b;
bool isParsed, isParsed2;
Console.WriteLine("Let's sum up two numbers.");

// 1st solution

for (int i = 0; ; i++)
{
    try
    {
        Console.WriteLine("Input 1st number.");
        a1 = Console.ReadLine();

        Console.WriteLine("Input 2nd number.");
        b1 = Console.ReadLine();

        a = Convert.ToDouble(a1);
        b = Convert.ToDouble(b1);
        Console.WriteLine("The result is " + (a + b));
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not a number.\n");
    }
}

// 2nd solution
for (; ;)
{
    Console.WriteLine("Input 1st number.");
    a1 = Console.ReadLine();

    Console.WriteLine("Input 2nd number.");
    b1 = Console.ReadLine();

    isParsed = double.TryParse(a1, out a);
    isParsed2 = double.TryParse(b1, out b);

    if (isParsed.Equals(true) && isParsed2.Equals(true))
    {
        Console.WriteLine("The sum is " + (a + b));
        break;
    }
    else
    {
        Console.WriteLine("It's not a number.\n");
    }
}