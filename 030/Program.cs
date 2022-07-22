//  30. Написать программу вычисления произведения чисел от 1 до N

int N=7;
long res = 1;
for (int i = 0; i < N; i++, res *= i);
Console.WriteLine(res);