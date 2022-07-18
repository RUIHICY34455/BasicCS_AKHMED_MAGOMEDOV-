// See https://aka.ms/new-console-template for more information
int a=Convert.ToInt32(Console.ReadLine()); 
bool b=a%7==0 && a%23==0; 
//System.Console.WriteLine(b); 
if (b) 
{     System.Console.WriteLine("Кратно"); }
else {     System.Console.WriteLine("Не кратно"); }
