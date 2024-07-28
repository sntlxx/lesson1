// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 

void Main ()
{
char[,] matrix = 
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f' }
   
};
string str = "";
foreach(char ch in matrix)
   { 
    str += ch;
   }
System.Console.WriteLine(str);
}
Main();