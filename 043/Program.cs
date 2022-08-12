// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("Введите число: ");
string? N= Console.ReadLine(); 
System.Console.WriteLine($"Введите {N} чисел: ");
string? s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss,int.Parse);

int sum;
sum = 0;

for(int i=0;i<a.Length;i++)
    if (a[i]>0)
    {
        sum++;
    }
   
System.Console.Write(sum);
    