//Пускай теперь алгоритм не выводит ответ сам, а запрашивает ответ и потом проверяет его на правильность.
//Требование к интерфейсу.
//• Запрос числа 1
//• Запрос числа 2
//• Запрос результата вычисления
//• Вывод “Правильно” или “Неправильно”

string a1, b1;
double a, b, result, sum;
Console.WriteLine("Let's sum up two numbers.");

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

        Console.WriteLine("What is the sum? Type please.");
        sum = Convert.ToDouble(Console.ReadLine());

        if (sum == result)
        {
            Console.WriteLine("That's correct!");
        }
        else
        {
            Console.WriteLine("Wrong answer!");
        }
        break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("It's not a number.\n");
    }
}