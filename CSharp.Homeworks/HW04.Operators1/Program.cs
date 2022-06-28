// Требование к интерфейсу. 
//• Запрос числа 1 (ввод с клавиатуры) 
//• Запрос числа 2 (ввод с клавиатуры) 
//• Вывод суммы этих чисел  
//• В случае не валидного ввода данных (любой символ отличны от числа) – вывод сообщения на 
//экран, о том, что введенный символ не является числом и снова попросить пользователя ввести 
//число

string a1, b1;
int a, b;
Console.WriteLine("Let's sum up two numbers.");

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