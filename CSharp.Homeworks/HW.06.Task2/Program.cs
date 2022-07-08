//Дана строка символов. Слова в строке отделяются друг от друга одним пробелом. Кусочек текста можете сгенерировать с сайта Lorem Ipsum (https://loremipsum.io/) 
//Необходимо:
//• Удалить из строки самое длинное слово 
//• Поменять местами самое длинное слово с самым коротким словом. 
//• Посчитать сколько в строке букв, пунктуационных знаков. 
//• Преобразовать строку в одномерный массив, используя пробел. Отсортировать массив по убыванию – первый индекс содержит самое длинное слово,
//последний – самое короткое. 
//Каждый подпункт данной задачи НУЖНО оформить в виде отдельного метода с параметром, где параметр это строка, которая дана в начале задачи. 

string originText = "Lorem ipsum dolor sit amet consectetur, adipiscing elit sed do; eiusmod tempor incididunt ut labore et dolore magna aliqua.";

DeleteLongestWord(originText);
ChangePositionLongestToShortest(originText);
CountCharFromLine(originText);
LineToArrayAndSort(originText);


void DeleteLongestWord(string text)
{
    string[] arrayOfWords = text.Split(' ');
    string longestWord = "";
    int indexOfLongestWord = default;

    Console.WriteLine(originText);

    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        if (arrayOfWords[i].Length >= longestWord.Length)
        {
            longestWord = arrayOfWords[i];
            indexOfLongestWord = i;
        }
    }

    var wordList = arrayOfWords.ToList();
    wordList.Remove(arrayOfWords[indexOfLongestWord]);
    arrayOfWords = wordList.ToArray();

    Console.WriteLine("\nThe longest word \"" + longestWord + "\" was deleted. Now text looks like:");

    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        Console.Write(arrayOfWords[i] + " ");
    }

    Console.WriteLine();
}

void ChangePositionLongestToShortest(string text)
{
    string[] arrayOfWords = text.Split(' ');
    string longestWord = "";
    int indexOfLongestWord = default;
    string shortestWord = "";
    int indexOfShortest = default;

    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        if (arrayOfWords[i].Length > longestWord.Length)
        {
            longestWord = arrayOfWords[i];
            indexOfLongestWord = i;
        }
    }

    shortestWord = longestWord;

    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        if (arrayOfWords[i].Length < shortestWord.Length)
        {
            shortestWord = arrayOfWords[i];
            indexOfShortest = i;
        }
    }

    Console.WriteLine(string.Format("\nThe longest word is \"{0}\", the shortest word is \"{1}\". Now text looks like: ", longestWord, shortestWord));

    arrayOfWords[indexOfLongestWord] = shortestWord;
    arrayOfWords[indexOfShortest] = longestWord;

    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        Console.Write(arrayOfWords[i] + " ");
    }

    Console.WriteLine();
}

void CountCharFromLine(string text)
{
    char[] elementsOfLine = text.ToCharArray();
    int elementsInLine = text.Count();
    int amountOfPunctuations = default;

    for (int i = 0; i < elementsOfLine.Length; i++)
    {
        if (Char.IsPunctuation(elementsOfLine[i]))
        {
            amountOfPunctuations++;
        }
    }

    Console.WriteLine(string.Format("\nThere are {0} letters and signs in the line. {1} from them are punctuation marks.\n", elementsInLine, amountOfPunctuations));
}

void LineToArrayAndSort(string text)
{
    string[] arrayOfWords = text.Split(' ');

    Console.WriteLine("\nNew sorted text order by DESC.");
    for (int i = 0; i < arrayOfWords.Length; i++)
    {
        Array.Sort(arrayOfWords, (x, y) => y.Length.CompareTo(x.Length));
        Console.Write(arrayOfWords[i] + " ");
    }
}