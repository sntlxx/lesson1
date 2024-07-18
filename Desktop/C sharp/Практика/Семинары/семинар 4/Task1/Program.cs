void Main()
{
while(true)
{
    Console.Write("Введите число или нажмите 'q', чтобы завершить программу: ");
    string input = Console.ReadLine(); 
 
 if (input == "q") 
 {
 break; 
 }

 bool isNumber = int.TryParse(input, out int number); 
 
 if (!isNumber) 
 {
 Console.WriteLine("Вы ввели не число. Попробуйте снова.");
 continue; 
 }
 
 int sum = 0; 
 
 while (number > 0) 
 {
 sum += number % 10; 
 number /= 10; 
 }

 if (sum % 2 == 0) 
 {
 Console.WriteLine("Сумма цифр четная. Программа завершена.");
 break; 
 }
 }
 }

Main();