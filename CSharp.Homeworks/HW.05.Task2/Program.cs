//Необходимо: заполнить(вводом с клавиатуры) численный массив(размерность 10) за исключением 
//последнего элемента. Вывести заполненный массив на экран.  

//Запросить еще одно значение (также вводом через клавиатуру) и его позицию в массиве (также 
//вводом через клавиатуру). В cуществующий массив вставить указанное число в заданную позицию,
//подвинув элементы после него. 

int[] msv1 = new int[10];

string temp;
int inputNumber = default;
int inputPosition;
bool isParsed;

Console.WriteLine("Now let's fill the massive with your numbers!");
for (int i = 0; i < msv1.Length - 1; i++)
{
    Console.WriteLine("Input number:");
    temp = Console.ReadLine();

    isParsed = int.TryParse(temp, out inputNumber);
    if (isParsed)
    {
        msv1[i] = inputNumber;
    }
    else
    {
        Console.WriteLine("Can't fill in the massive with this number.");
    }
}

Console.WriteLine("Your massive: ");
for (int i = 0; i < msv1.Length; i++)
{
    Console.Write(msv1[i] + " ");
}

Console.WriteLine("\nInput one more number to fill the massive in: ");
for (int i = 0; i < msv1.Length; i++)
{
    temp = Console.ReadLine();
    isParsed = int.TryParse(temp, out inputNumber);

    if (isParsed)
    {
        break;
    }
    else
    {
        Console.WriteLine("Invalid  number. Try again.");
    }
}

Console.WriteLine("What position do you want to set this number? From 0 to " + (msv1.Length) + ".");
for (; ; )
{
    temp = Console.ReadLine();
    isParsed = int.TryParse(temp, out inputPosition);

    if (inputPosition < 1 || inputPosition > msv1.Length)
    {
        Console.WriteLine("This number is not valid. Massive has positions from 1 to " + (msv1.Length) +
            ". Input another valid number.");
    }
    else
    {
        break;
    }
}

if (inputPosition.Equals(msv1.Length))
{
    msv1[inputPosition - 1] = inputNumber;
}
else
{
    int previousElement = inputNumber;

    for (int i = inputPosition - 1; i < msv1.Length; i++)
    {
        int currentElement = msv1[i];
        msv1[i] = previousElement;
        previousElement = currentElement;
    }
}

for (int i = 0; i < msv1.Length; i++)
{
    Console.Write(msv1[i] + " ");
}