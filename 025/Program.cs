// 25. Вывести на экран кубы чисел от 1 до N

int N=8;
int i=1;
while(i<=N)
{
    int a=3;
    System.Console.Write($"{i}^{a}={Math.Pow(i,a)}  ");
    i++;
}