// 13.	Удалить вторую цифру трёхзначного числа

int a=Convert.ToInt32(Console.ReadLine());
int d0=a%10;
System.Console.WriteLine(d0);
int na=a/100;
System.Console.WriteLine(na);
a=na*10+d0;
System.Console.WriteLine(a);
