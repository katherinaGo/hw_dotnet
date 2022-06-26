// Task 2 a

double a, b, c, discr, result, x1, x2;
bool isZero = true;

Console.WriteLine("Type the 1st number. Note: It can't be 0(zero).");
a = Convert.ToDouble(Console.ReadLine());

while (isZero == true)
{
    if (a != 0)
    {
        isZero = false;
        break;
    }
    else
    {
        isZero = true;
        Console.WriteLine("Input the 1st number. Note: It can't be 0(zero).");
        a = Convert.ToDouble(Console.ReadLine());
    }
}

Console.WriteLine("Type the 2st number.");
b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type the 3st number.");
c = Convert.ToDouble(Console.ReadLine());

discr = b * b - 4 * a * c;
x1 = (-b + Math.Sqrt(discr)) / (2 * a);
x2 = (-b - Math.Sqrt(discr)) / (2 * a);

Console.WriteLine("Our formula ax^2 + bx + c = 0 has the following values: " + a + "x^2 + " + b + "x + " + c + " = 0; Let's find x;\n");

switch (discr)
{
    case < 0:
        Console.WriteLine("Discriminant = " + discr + " means there are not square roots.\n");
        break;
    case 0:
        Console.WriteLine("Discriminant = 0 means there is only one root can be found.\n");
        Console.WriteLine("x = " + x1);
        break;
    default:
        Console.WriteLine("Discriminant = " + discr + " means there are two roots.\n");
        Console.WriteLine("x1 = " + x1 + ", x2 = " + x2);
        break;
}