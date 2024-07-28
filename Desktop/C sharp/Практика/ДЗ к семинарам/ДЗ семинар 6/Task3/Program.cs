// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

void Main()
{
System.Console.WriteLine("Введите строку: ");
string? str = Console.ReadLine(); 

string? reverse =  new string(str!.ToCharArray().Reverse().ToArray());

if(str.Equals(reverse))
{
   System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палиндром");
}
}
Main();
