﻿// 14.	С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
if(a%b==0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine(a%b);
}