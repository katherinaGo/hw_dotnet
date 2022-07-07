//Написать программу, которая просит на вход ввести стихотворение в одну строку 
//разделяя строки точкой с запятой;  
//• Разбить введенную строку на массив, используя точку с запятой в качестве разделителя  
//• Заменить букву О на А,
//• Вывести массив построчно, как будто столбиком.

// I never saw a purple cow;I never hope to see one;But I can tell you, anyhow;I’d rather see than be one!

Console.WriteLine("Type the poem please in one line with ; at the end of each line.");
string poem = Console.ReadLine();
string[] arrayOfStrings = poem.Split(';');

for (int i = 0; i < arrayOfStrings.Length; i++)
{
    arrayOfStrings[i] = arrayOfStrings[i].Replace("o", "a");
}

Console.WriteLine("\nNew modified array: ");
for (int i = 0; i < arrayOfStrings.Length; i++)
{
    Console.WriteLine(arrayOfStrings[i]);
}