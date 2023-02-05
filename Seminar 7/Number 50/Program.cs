// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

Console.WriteLine("Введите позицию Элемента! Номер строки: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию Элемента! Номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x<=m&&x>0&&y<=n&&y>0)
    Console.Write($"Значение элемента {array[x-1, y-1]} ");
else
    Console.Write($"Нет такого элемента (позиция указана неверно). В массиве строк: {m} и столбцов: {n}.");
