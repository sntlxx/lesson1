// Задать массив из N случайных целых чисел (N вводится с клавиатуры)
// Найти кол-во чисел, которые оканчиваются на 1 и делятся нацело на 7

void Main()
{

    int arraySize = ReadInt("Введите размер массива: ");
    int[] array = GenerateArray(arraySize, 1,10);
    PrintArray(array);

    int[] array2 = GenerateArray(7, 10, 100);
    PrintArray(array2);


void PrintArray(int[] arrayForPrint)
{
    for(int i = 0; i < arrayForPrint.Length; i++)
    System.Console.Write(arrayForPrint[i] + " ");
    System.Console.WriteLine();
}



int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] tempArray = new int[size];
    Random rand = new Random();
    for (int i=0; i < tempArray.Length; i++)
        tempArray[i] = rand.Next(minValue, maxValue);
    return tempArray;
}




int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
  
}
}
Main(); 