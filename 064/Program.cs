// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

System.Console.WriteLine("Задайте значение:");
int M=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значение:");
int N=Convert.ToInt32(Console.ReadLine());

for (int i=0; i<N; i++)
{
    System.Console.Write($"{M} ");
    M++;
}