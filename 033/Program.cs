// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран




int N=8;

int[] a=new int[N];
Random random = new Random();
for(int i=0; i<a.Length;i++)
    a[i]=random.Next(0,2);
for(int i=0; i<a.Length;i++)
    System.Console.Write($"{a[i],2} ");





/*arr = new int[n];
Console.Write("Полученный массив arr: ");
for (int i = 0; i < arr.Length; i++)
    arr[i] = Convert.ToInt32(!((i + 1 > a) && (i + 1 < b)));
Console.WriteLine(String.Join(", ", arr));*/




/*int n = 0, a = 0, b = 0;
int[] arr = null;*/