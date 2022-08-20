// С клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

System.Console.Write("Введите строку: ");
string? str = Console.ReadLine();
System.Console.WriteLine(str);
 
 Tochka(str);

void Tochka (string a)
{
    int count = 0;
    for(int i=0; i < a.Length; i++)
    {
        
        
        if (a[i] != '.')
            {
                
                //System.Console.Write(a[i]); проверял правильно считывает символы
                count++;
               
                
            }
            
        else
            break;
        
    }
     System.Console.Write($"Количество символов до точки {count}");
}

/* при выполнении кода высвечивает желтыи следующее: 
"warning CS8604: Возможно, аргумент -ссылка, допускающий значение NULL, для параметра "a" в "void Tochka(string a)". [C:\Users\gadzh\Desktop\скан\geekbr\Ba 
sicCS_projects\Example\string3\string3.csproj]"
Почему?*/