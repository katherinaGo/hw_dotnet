// Требование к интерфейсу. 
//• Запрос числа 1 (ввод с клавиатуры) 
//• Запрос числа 2 (ввод с клавиатуры) 
//• Вывод суммы этих чисел  
//• В случае не валидного ввода данных (любой символ отличны от числа) – вывод сообщения на 
//экран, о том, что введенный символ не является числом и снова попросить пользователя ввести 
//число

string a1, b1;
int a, b;
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

        a = Convert.ToInt32(a1);
        b = Convert.ToInt32(b1);
        Console.WriteLine("The sum is " + (a + b));
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

    isParsed = int.TryParse(a1, out a);
    isParsed2 = int.TryParse(b1, out b);

    if (isParsed == true && isParsed2 == true)
    {
        Console.WriteLine("The sum is " + (a + b));
        break;
    }
    else
    {
        Console.WriteLine("It's not a number.\n");
    }
}