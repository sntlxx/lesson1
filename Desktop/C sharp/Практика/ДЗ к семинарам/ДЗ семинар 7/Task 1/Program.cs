// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы

void Main()
 {
 Console.WriteLine("Введите начальное значение M:");
 int M = Convert.ToInt32(Console.ReadLine());
 
 Console.WriteLine("Введите конечное значение N:");
 int N = Convert.ToInt32(Console.ReadLine());

 if(M > N)
 {
 Console.WriteLine("Начальное значение не может быть больше конечного. Введите числа заново.");
 return;
 }
 
 PrintNumbers(M, N);
 }

void PrintNumbers(int first, int second)
 {
 if (first > second) 
{
    return;
}
 Console.Write(first+ " ");
 PrintNumbers(first+ 1, second);
 }



Main();