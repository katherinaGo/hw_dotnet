//Необходимо: заполнить один массив случайными(вспомним класс Random) числами, другой -
//введенными с клавиатуры числами, в ячейки третьего записать суммы соответствующих ячеек первых 
//двух. Содержимое массивов вывести на консоль. 
//Дополнение: Все три массива должны иметь одинаковую размерность и тип.

int[] msv1 = new int[6];
int[] msv2 = new int[6];
int[] msv3 = new int[6];

string temp;
int number;
bool isParsed;

Random rand = new Random();

Console.WriteLine("Massive filled with random numbers from 0 to 50;");
for (int i = 0; i < msv1.Length - 1; i++)
{
    Console.Write((msv1[i] = rand.Next(0, 50)) + " ");
}

Console.WriteLine("\nNow let's fill the massive with your numbers!");
for (int i = 0; i < msv2.Length - 1; i++)
{
    Console.WriteLine("Input number:");
    temp = Console.ReadLine();

    isParsed = int.TryParse(temp, out number);
    if (isParsed)
    {
        msv2[i] = number;
    }
}

Console.WriteLine("Your massive: ");
for (int i = 0; i < msv2.Length; i++)
{
    Console.Write(msv2[i] + " ");
}

Console.WriteLine("\nNow you will the 3d massive from 2 previous! Magic!");

for (int i = 0; i < msv3.Length - 1; i++)
{
    msv3[i] = msv1[i] + msv2[i];
    Console.Write(msv3[i] + " ");
}