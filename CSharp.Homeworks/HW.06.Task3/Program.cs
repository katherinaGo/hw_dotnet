//Дана строка, которая содержит числа в перемешку с символами. Также данная строка содержит 
//один математический символ такой как +, -, *, /  
//Необходимо склеить цифры в одно число до математического знака и склеить цифры в одно 
//число после математического знака. Дальше, используя математический знак - сделать 
//соответсвующую операцию - сложение, вычитание, умножение или деление.

string text = "gdfgdf234dg54gf*23oP42";
string numbersBefore = "";
string numbersAfter = "";
char operatorSign = '0';

for (int i = 0; i < text.Length; i++)
{
    if (operatorSign.Equals('0') && Char.IsNumber(text[i]))
    {
        numbersBefore = numbersBefore + text[i];
    }

    if (!operatorSign.Equals('0') && Char.IsNumber(text[i]))
    {
        numbersAfter = numbersAfter + text[i];
    }

    if (text[i].Equals('*') || text[i].Equals('/') || text[i].Equals('+') || text[i].Equals('-'))
    {
        operatorSign = text[i];
    }
}

Console.WriteLine("The result of math  action: {0} * {1} = {2}", numbersBefore, numbersAfter, (Convert.ToInt32(numbersBefore)
    * Convert.ToInt32(numbersAfter)));