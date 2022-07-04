//Написать программу, задающую направление движения игрока в игре. 
//Требование к интерфейсу: 
//• Ввести с клавиатуры символ. 
//• Определить, необходимо ли нам переместить фигуру вверх, вниз, вправо, влево в 
//зависимости от введенного символа (W, S, A, D). Помните, что у нас есть верхний регистр 
//(upper case, к примеру W) и нижний регистр (lower case, к примеру w) 
//• Вывести результат решения на экран. В случае отсутствия необходимости перемещения 
//вывести соответствующее сообщение.

string letter;

for (; ; )
{
    Console.WriteLine("Type symbol from keyboard");
    letter = Console.ReadLine();
    switch (letter.ToLower())
    {
        case "w":
            Console.WriteLine("The player goes up.");
            break;
        case "s":
            Console.WriteLine("The player goes down.");
            break;
        case "a":
            Console.WriteLine("The player goes left.");
            break;
        case "d":
            Console.WriteLine("The player goes right.");
            break;
        default:
            Console.WriteLine("You don't need to do anywhere.");
            break;
    }
}