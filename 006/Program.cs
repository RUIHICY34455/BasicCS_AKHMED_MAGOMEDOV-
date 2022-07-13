// 6.	Написать программу вычисления значения функции y = f(a)

int y, a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a == 0)
{
    y = 0;
}
else
{
    y = 2 * Math.Abs(a) + 10;
}

System.Console.WriteLine(y);