﻿// 32. Задать массив из 8 целых элементов и вывести их на экран

int N=8;

int[] a=new int[N];
Random random = new Random();
for(int i=0; i<a.Length;i++)
    a[i]=random.Next(0,100);
for(int i=0; i<a.Length;i++)
    System.Console.Write($"{a[i],2}");















/* значимые типы (value type)
int a; 
double b;
float c;
bool d;

// ссылочные типы (reference type)
string s;
int[] ar;
Random random;
*/