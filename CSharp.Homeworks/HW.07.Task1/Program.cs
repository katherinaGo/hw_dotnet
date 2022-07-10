//Дана символьная строка, содержащая хотя бы один символ '?'.
//Удалить все символы '!' или '.', расположенные до первого символа '?' и заменить все пробелы,
//расположенные за первым символом '?', на символ подчёркивания '_'. 
//Исходная строка: “1a!2.3!!..4.!.? 6 7!.. ?” 
//В данной задаче используйте StringBuilder.

using System.Text;

string text = "1a!2.3!!.. 4.!.? 6 7! .. ?";
StringBuilder sb = new StringBuilder(text);
int indexFirstQuestMark = 0;

DeleteSymbols();
ReplaceSpaces();

void DeleteSymbols()
{
    Console.WriteLine("Let's remove '!' and '.' before '?' here '" + sb + "'");

    for (int i = 0; i < sb.Length; i++)
    {
        if (sb[i].Equals('!') || sb[i].Equals('.'))
        {
            sb.Remove(i, 1);
            i--;
        }

        if (sb[i].Equals('?'))
        {
            indexFirstQuestMark = i;
            break;
        }
    }
    Console.WriteLine("Result: " + sb);

}

void ReplaceSpaces()
{
    Console.WriteLine("Let's replace ' ' to '_' after first '?'.");

    for (int i = indexFirstQuestMark; i < sb.Length; i++)
    {
        if (sb[i].Equals(' '))
        {
            sb.Replace(' ', '_', i, 1);
        }
    }
    Console.WriteLine("Result: " + sb);
}