// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* Многострочный комментарий
int a=2,b=3;
int s=a+b;
Console.WriteLine(a+"+"+b+"="+s);//склеивание строк
System.Console.WriteLine("{2}+{1}={0}",s,b,a);//строка форматирования
System.Console.WriteLine($"{a}+{b}={s}");//строка интерполяции
*/


// Вывести квадрат числа
int a;
int b;
string? s;
s=Console.ReadLine();
a=Convert.ToInt32(s);
b=a*a;
System.Console.WriteLine($"{a}^2={b}");
