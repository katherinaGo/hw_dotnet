//Самостоятельно(не прибегая к товарищу Google) реализуйте Reverse массива.  
//После, используя dotPeek, декомпилируйте класс Array (находится в самой главной сборке mscorlib 
//под неймспейсом System.Array) и исследуйте, как работает метод Reverse

int[] msv1 = new int[6];
Random rand = new Random();
int[] msvTemp = new int[msv1.Length];
int a = msvTemp.Length;

Console.WriteLine("Our filled massive: ");
for (int i = 0; i < msv1.Length; i++)
{
    Console.Write((msv1[i] = rand.Next(0, 10)) + " ");
}

for (int i = 0; i < msv1.Length; i++)
{
    msvTemp[i] = msv1[i];
}

for (int i = 0; i < msvTemp.Length; i++)
{
    a--;
    msv1[i] = msvTemp[a];
}

Console.WriteLine("\nOur new reversed massive: ");
for (int i = 0; i < msv1.Length; i++)
{
    Console.Write(msv1[i] + " ");
}