﻿// 4.	По заданному номеру дня недели вывести его название

int a;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
if (a == 1)
{
    System.Console.WriteLine("Понедельник");
}
if (a == 2)
{
    System.Console.WriteLine("Вторник");
}
if (a == 3)
{
    System.Console.WriteLine("Среда");
}
if (a == 4)
{
    System.Console.WriteLine("Четверг");
}
if (a == 5)
{
    System.Console.WriteLine("Пятница");
}
if (a == 6)
{
    System.Console.WriteLine("Суббота");
}
if (a == 7)
{
    System.Console.WriteLine("Воскресенье");
}

