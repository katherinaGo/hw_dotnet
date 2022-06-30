//Пускай алгоритм теперь запрашивает оператор (+ или -).
//Требование к интерфейсу.
//• Запрос числа 1
//• Запрос числа 2
//• Запрос оператора
//• Запрос результата вычисления
//• Вывод “Правильно” или “Неправильно”
//• Вывод “Должно быть больше” или “Должно быть меньше”

string a1, b1, c, oprtr;
double a, b, total, inputResult;
double? result = null;
bool isParsedA, isParsedB, isParsedResult, isParsedOprtr;

Console.WriteLine("Let's make some calculations with two numbers.");

for (; ; )
{
    try
    {
        Console.WriteLine("Input 1st number.");
        a1 = Console.ReadLine();
        a = Convert.ToDouble(a1);

        Console.WriteLine("Input 2nd number.");
        b1 = Console.ReadLine();
        b = Convert.ToDouble(b1);
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not a number.\n");
    }
}

for (; ; )
{
    Console.WriteLine("What do you want to do? (a + b) or (a - b). Type + or - .");
    try
    {
        oprtr = Console.ReadLine();

        switch (oprtr)
        {
            case "+":
                result = (a + b);
                break;
            case "-":
                result = (a - b);
                break;
            default:
                Console.WriteLine("Something went wrong. Oops...");
                break;
        }
        if (result != null)
        {
            break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not + or - . Try again.");
    }
}

for (; ; )
{
    try
    {
        Console.WriteLine("What is the total amount? Type please.");
        total = Convert.ToDouble(Console.ReadLine());
        break;
    }
    catch (Exception ex1)
    {
        Console.WriteLine("It's not a number.");
    }
}

if (total == result)
{
    Console.WriteLine("That's correct!");
}
else
{
    Console.WriteLine("Wrong answer!");

    switch (result < total & result != total)
    {
        case true:
            Console.WriteLine("Your number should be less.");
            break;
        case false:
            Console.WriteLine("Your number should be more.");
            break;
        default:
            break;
    }
} 

// 2 solution

for (; ; )
{
    Console.WriteLine("Input 1st number.");
    a1 = Console.ReadLine();
    isParsedA = double.TryParse(a1, out a);

    Console.WriteLine("Input 2nd number.");
    b1 = Console.ReadLine();
    isParsedB = double.TryParse(b1, out b);

    if (isParsedA == true && isParsedB == true)
    {
        break;
    }
    else
    {
        Console.WriteLine("It's not a number.");
    }
}

for (; ; )
{
    Console.WriteLine("What do you want to do? (a + b) or (a - b). Type + or - .");
    oprtr = Console.ReadLine();

    switch (oprtr)
    {
        case "+":
            result = (a + b);
            break;
        case "-":
            result = (a - b);
            break;
        default:
            Console.WriteLine("Something went wrong. Oops...");
            break;
    }
    if (result != null)
    {
        break;
    }
}

for (; ; )
{
    Console.WriteLine("What is the total result? Type please.");
    c = Console.ReadLine();
    isParsedResult = double.TryParse(c, out inputResult);

    if (isParsedResult == true && result == inputResult)
    {
        Console.WriteLine("That's correct!");
        break;
    }
    else if (isParsedResult == true & result != inputResult)
    {
        Console.WriteLine("Wrong answer!");

        switch (result < inputResult)
        {
            case true:
                Console.WriteLine("Your number should be less.");
                break;
            case false:
                Console.WriteLine("Your number should be more.");
                break;
        }
    }
    else if (isParsedResult == false)
    {
        Console.WriteLine("Somethiing went wrond. Oops...");
    }
    break;
}