//Пускай алгоритм теперь запрашивает оператор (+ или -).
//Требование к интерфейсу.
//• Запрос числа 1
//• Запрос числа 2
//• Запрос оператора
//• Запрос результата вычисления
//• Вывод “Правильно” или “Неправильно”
//• Вывод “Должно быть больше” или “Должно быть меньше”

string a1, b1;
double a, b, total;
double? result = null;
char oprtr = ' ';
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

        for (; ; )
        {
            Console.WriteLine("What do you want to do? (a + b) or (a - b). Type + or - .");
            try
            {
                oprtr = Convert.ToChar(Console.ReadLine());

                switch (oprtr)
                {
                    case '+':
                        result = (a + b);
                        break;
                    case '-':
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

        Console.WriteLine("What is the total amount? Type please.");
        total = Convert.ToDouble(Console.ReadLine());

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
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not a number.\n");
    }
}