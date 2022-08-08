// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


int N=8;

int[] a=new int[N];
Random random = new Random();
for(int i=0; i<a.Length;i++)
    a[i]=random.Next(100,1000);

int num = 0;

for(int i=0;i<a.Length;i++)
    
    if (a[i]%2!=0)
    {
        
        num ++;
        
    }
System.Console.Write($"Количество нечетных чисел: {num} ");

for(int i=0;i<a.Length;i++)    
    if (a[i]%2==0)
    {
        num ++;
    }

System.Console.Write($"Количество четных чисел: {num} ");