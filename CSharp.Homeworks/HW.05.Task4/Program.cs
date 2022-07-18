//Пользователь вводит число (положительное> 0) с клавиатуры.Найти сумму чисел от 1 до введенного
//числа.К примеру,
//3 => 1 + 2 + 3 = 6 
//5 => 1 + 2 + 3 + 4 + 5 = 15 

int number;
string temp;
bool isParsed;
int[] massive;
int sum;

for (; ; )
{
    Console.WriteLine("Input any positive number > 0.");
    temp = Console.ReadLine();
    isParsed = int.TryParse(temp, out number);
    if (isParsed.Equals(true) & number > 0)
    {
        Console.WriteLine("Let' count all numbers from 1 to your number " + number + ": ");
        break;
    }
    else
    {
        Console.WriteLine(" Number doesn't match the rules.");
    }
}

massive = new int[number];
int startElement = 1;

for (int i = 0; i < massive.Length; i++)
{
    massive[i] = startElement++;
    Console.Write(massive[i] + " ");
}

// 1st solution

sum = (number * (number + 1)) / 2;
Console.WriteLine("\nSum of all numbers = " + sum + ".");

// 2nd solution

int total = default;

for (int i = 0; i < massive.Length; i++)
{
    total = total + massive[i];
}

Console.WriteLine("Sum of all numbers = " + total + ".");