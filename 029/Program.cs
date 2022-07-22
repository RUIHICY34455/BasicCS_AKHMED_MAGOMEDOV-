// 29. Подсчитать сумму цифр в числе

int a = 123456;
int s = 0;
while (a > 0)
{
    s = s + a % 10;
    a = a /10 ;
 }

 Console.WriteLine(s);





