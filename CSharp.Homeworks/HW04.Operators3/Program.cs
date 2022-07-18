//Изменить предыдущий алгоритм. Пускай он теперь выводит не только информацию правильно или неправильно, но и дополнительно,
//ожидается число больше или меньше указанного. Требование к интерфейсу.
//• Запрос числа 1
//• Запрос числа 2
//• Запрос результата вычисления
//• Вывод “Правильно” или “Неправильно”
//• Вывод “Должно быть больше” или “Должно быть меньше”

string a1, b1, c;
double a, b, result, inputResult;
bool isParsedA, isParsedB, isParsedResult;

Console.WriteLine("Let's inputResult up two numbers.");

// 1 solution

for (int i = 0; ; i++)
{
    try
    {
        Console.WriteLine("Input 1st number.");
        a1 = Console.ReadLine();
        a = Convert.ToDouble(a1);

        Console.WriteLine("Input 2nd number.");
        b1 = Console.ReadLine();
        b = Convert.ToDouble(b1);

        result = a + b;

        Console.WriteLine("What is the total result? Type please.");
        inputResult = Convert.ToDouble(Console.ReadLine());

        if (inputResult.Equals(result))
        {
            Console.WriteLine("That's correct!");
        }
        else
        {
            Console.WriteLine("Wrong answer!");

            switch (result < inputResult & result != inputResult)
            {
                case true:
                    Console.WriteLine("Your number should be less.");
                    break;
                case false:
                    Console.WriteLine("Your number should be more.");
                    break;
            }
        }
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not a number.\n");
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

    if (isParsedA.Equals(true) && isParsedB.Equals(true))
    {
        result = a + b;
        break;
    }
    else
    {
        Console.WriteLine("It's not a number.\n");
    }
}

for (; ; )
{
    Console.WriteLine("What is the total result? Type please.");
    c = Console.ReadLine();
    isParsedResult = double.TryParse(c, out inputResult);

    if (isParsedResult.Equals(true) && result.Equals(inputResult))
    {
        Console.WriteLine("That's correct!");
    }
    else
    {
        Console.WriteLine("Wrong answer!");

        switch (result < inputResult & result != inputResult)
        {
            case true:
                Console.WriteLine("Your number should be less.");
                break;
            case false:
                Console.WriteLine("Your number should be more.");
                break;
        }
    }
    break;
}