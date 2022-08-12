// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N=123;

int[] a=new int[N];
Random random = new Random();
for(int i=0; i<a.Length;i++)
    a[i]=random.Next(100,1000);

int k;

k = 0;
for (int i = 10; i < 100; i++)
        k++;

System.Console.Write($"{k} ");