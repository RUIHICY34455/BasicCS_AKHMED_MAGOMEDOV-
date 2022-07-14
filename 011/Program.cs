// 11.	Показать вторую цифру трёхзначного числа

int a=Convert.ToInt32(Console.ReadLine());
// if (a>=100 || a<=100)
if(Math.Abs(a)>=100)
{
    System.Console.WriteLine(a%100/10);
}
else
{
    System.Console.WriteLine("Число имеет меньше трех цифр");
}