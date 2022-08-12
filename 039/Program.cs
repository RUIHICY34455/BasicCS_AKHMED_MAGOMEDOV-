// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int N=9;

int[] a=new int[N];
Random random = new Random();
int sum;

sum = 0;
for(int i=0; i<a.Length;i++)
    a[i]=random.Next(0,10);

/*for(int i=0; i<a.Length;i++)
    System.Console.Write($"{a[i]}  ");
*/
for(int i=1; i<a.Length;i+=2)
    sum=sum+a[i];

System.Console.Write($"{sum} ");










/*
    System.Console.Write($"{a[i]}  ");
    /*for(int j=1; j<a.Length;i++)
    sum=sum+a[j];*/
    /*if (i%2!=0)
    {
        sum=sum+a[i];
    }*/


  

