// Написать программу копирования массива

int N=9;

int[] a=new int[N];
Random random = new Random();

for(int i=0; i<a.Length;i++)
    a[i]=random.Next(0,10);


int[] b=new int[a.Length];

Array.Copy(a, b, a.Length);

for(int i=0; i<a.Length;i++)
System.Console.Write($"{a[i]} {b[i]}  ");