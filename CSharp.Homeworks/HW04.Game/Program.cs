//Написать программу, задающую направление движения игрока в игре. 
//Требование к интерфейсу: 
//• Ввести с клавиатуры символ. 
//• Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо, влево в 
//зависимости от введенного символа (W, S, A, D). Помните, что у нас есть верхний регистр 
//(upper case, к примеру W) и нижний регистр (lower case, к примеру w) 
//• Вывести результат решения на экран. В случае отсутствия необходимости перемещения 
//вывести соответствующее сообщение.

const string up = "W";
const string down = "S";
const string left = "A";
const string right = "D";

for (int i = 0; i <= 5; i++)
{
    Console.WriteLine("Type symbol from keyboard.");
    string letter = Console.ReadLine();
    switch (letter)
    {
        case up:
            Console.WriteLine("The player goes up.");
            break;
        case down:
            Console.WriteLine("The player goes down.");
            break;
        case left:
            Console.WriteLine("The player goes left.");
            break;
        case right:
            Console.WriteLine("The player goes right.");
            break;
        default:
            Console.WriteLine("Something went wrong. Ops...");
            break;
    }
}