// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число строк второй матрицы должно совпадать с числом столбцов первой: их {m}");
Console.Write("Введите количество столбцов второй матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[l, m];
int[,] array2 = new int[m, n];
void FillPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillPrintArray(array);
Console.WriteLine();
FillPrintArray(array2);
Console.WriteLine();
int[,] array3 = new int[l, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        array3[i, j] = 0;
        for (int r = 0; r < array.GetLength(1); r++)
        {
            array3[i, j] = array3[i, j] + array[i, r] * array2[r, j];
        }
        Console.Write($"{array3[i, j]} ");
    }
    Console.WriteLine();
}