// 17. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int dayOfWeek;

// dayOfWeek=Convert.ToInt32(Console.ReadLine());
dayOfWeek=int.Parse(Console.ReadLine());

/* 
if(DayOfWeek==1) System.Console.WriteLine("Monday");
if(DayOfWeek==2) System.Console.WriteLine("Tuesday");
*/

switch(dayOfWeek)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;
    case 3:
        System.Console.WriteLine("Wednesday");
        break;
    case 4:
        System.Console.WriteLine("Thursday");
        break;
    case 5:
        System.Console.WriteLine("Friday");
        break;
    case 6:
        System.Console.WriteLine("Saturday");
        break;
    case 7:
        System.Console.WriteLine("Sunday");
        break;
    default:
        System.Console.WriteLine("wrong");
        break;
}