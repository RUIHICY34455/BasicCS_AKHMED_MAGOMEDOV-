// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

System.Console.WriteLine("Задайте значение:");
int M=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задайте значение:");
int N=Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i=0; i<N; i++)
{
    sum=sum+M;
    M++;
}
System.Console.WriteLine(sum);