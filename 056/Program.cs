// Написать программу, которая обменивает элементы первой строки и последней строки

int[,] arr;//объявляем массив

arr=Create2DArray(3,4);
Print(arr);

Ressiver(arr);

System.Console.WriteLine();
Print(arr);





void Ressiver(int[,] a)
{
    for(int i=0;i<a.GetLength(1);i++) 
        {
            int tmp;
            tmp = a[0,i];
            a[0,i] = a[a.GetLength(0) - 1, i];
            a[a.GetLength(0) - 1, i] = tmp;              
        }
    
    /*for(int j=0;j<a.GetLength(0);j++)
    {
        
        for(int i=0;i<a.GetLength(1);i++) 
        {
            int tmp;
            tmp = a[j,i];
            a[j,i] = a[a.GetLength(0) - 1, i];
            a[a.GetLength(0) - 1, i] = tmp;              
        }
        
    }*/
    
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
