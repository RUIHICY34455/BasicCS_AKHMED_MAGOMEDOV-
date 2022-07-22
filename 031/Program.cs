// 31. Показать кубы чисел, заканчивающихся на четную цифру

int N=8;
int i=1;
while(i<=N)
{
    int a=3;
    double sum = Math.Pow(i,a);
    if(sum%2==0) System.Console.WriteLine(sum);
    i++;
}