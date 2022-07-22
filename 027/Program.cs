// 27. Возведите число А в натуральную степень B используя цикл

int A=8;
int B=5;
int i=1;
int sum=1; 

while(i<=B)
{
    sum=sum*A;
    i++;
}


System.Console.WriteLine(sum);