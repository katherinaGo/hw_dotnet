//Используя цикл FOR и тип Char вывести английский алфавит в обратном порядке. Помните, что буквы 
//– это всего лишь порядковые номера таблицы Юникод (https://unicode-table.com/ru/)

for (int i = 90; i >= 65; i--)
{
    Console.Write(Char.ConvertFromUtf32(i) + " ");
}