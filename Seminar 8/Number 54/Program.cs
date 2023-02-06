// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
void FillPrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 15);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}

FillPrintArray(array);
Console.WriteLine("Упорядоченный по убыванию значений элементов в строках массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int max = array[i,j];
        for (int count = j+1; count < array.GetLength(1); count++)
        {
                       
            if (array[i,count] > max)
            {
            max = array[i,count];
            array[i,count] = array[i,j];
            array[i,j] = max;
            }
        }    
    
    Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
