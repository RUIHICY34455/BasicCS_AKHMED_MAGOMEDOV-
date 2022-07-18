// 21. Задать номер четверти, показать диапазоны для возможных координат

int num;

num=int.Parse(Console.ReadLine());

switch(num)
{
    case 1:
        System.Console.WriteLine("x=от 0 до +Ꝏ, y=от 0 до +Ꝏ");
        break;
    case 2:
        System.Console.WriteLine("x=от -Ꝏ до 0, y=от 0 до +Ꝏ");
        break;
    case 3:
        System.Console.WriteLine("x=от -Ꝏ до 0, y=от -Ꝏ до 0");
        break;
    case 4:
        System.Console.WriteLine("x=от 0 до +Ꝏ, y=от -Ꝏ до 0");
        break;
    default:
        System.Console.WriteLine("wrong");
        break;
}
