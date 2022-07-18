// 22. Программа проверяет пятизначное число на палиндромом

int Palindrome;
System.Console.WriteLine("Введите пятизначное чило ");

int num;
num=int.Parse(Console.ReadLine());

int a=num%10;
int b=num%100/10;
int c=num/10000;
int d=num/1000%10;

bool Palindrome=a==c && b==d;

if(Palindrome) 
{
    System.Console.WriteLine("Число является палинтромом!");
}
    
else 
{
    System.Console.WriteLine("Число не является палинтромом!");
}
    
   


System.Console.WriteLine($"{a} {b} {c} {d} ");