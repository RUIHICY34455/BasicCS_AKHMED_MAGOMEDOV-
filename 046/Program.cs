// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.WriteLine("Введите число: ");

int num;
num=int.Parse(Console.ReadLine());

int fib1 = 0;
int fib2 = 1;
int fib_sum;
fib_sum=0;

int i=0;
while (i<num)
{
    fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    System.Console.WriteLine($"{fib1} {fib2}");
    i++;
}
/*for(int i=0;i<num;i++)

    fib_sum = fib1 + fib2;
    fib1 = fib2;
    fib2 = fib_sum;
    System.Console.WriteLine($"{fib1} {fib2}");
    */