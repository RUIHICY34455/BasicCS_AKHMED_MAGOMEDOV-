//55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

int[,] arr;//объявляем массив

arr=Create2DArray(3,4);
Print(arr);

Arithmetical_mean(arr);





void Arithmetical_mean(int[,] a)
{
    
    for(int j=0;j<a.GetLength(1);j++)
    {
        int sum = 0;
        for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        {
            System.Console.WriteLine();
            System.Console.WriteLine(a[i,j]);
            sum = sum + a[i,j];                
        }
        System.Console.WriteLine($"среднее арифметическое = {sum/a.GetLength(0)} ");
    }
}





//int[,] arr2;
//Create2DArray2(4,5,out arr2);





void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
    {
            for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
                System.Console.Write($"{a[i,j],4}");
            System.Console.WriteLine();
    }
}


//1 способ вернуть массив
int[,] Create2DArray(int n,int m,int min=0,int max=100)
{
    int[,] a=new int[n,m];//создаем массив
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
            a[i,j]=random.Next(min,max+1);
    return a;
}

/*2 способ вернуть массив
void Create2DArray2(int n,int m,out int[,] a)
{
    a=new int[n,m];//создаем массив
    Random random=new Random();
    for(int i=0;i<a.GetLength(0);i++)//перебираем строки
        for(int j=0;j<a.GetLength(1);j++)//перебираем столбцы
            a[i,j]=random.Next(0,100);

}*/
