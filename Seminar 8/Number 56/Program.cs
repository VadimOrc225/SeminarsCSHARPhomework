// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
int[] arraySum = new int[m]; // дополнительный массив для сумм по строкам
void FillPrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillPrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    arraySum[i] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        arraySum[i] = arraySum[i] + array[i, j]; // накапливаем сумму в элемент дополнительного массива 
    }
    
}
int minSum = arraySum[0];
int minIndexStr = 0;
for (int i = 1; i < arraySum.Length; i++)
    {
    if(arraySum[i]<minSum)
{
    minSum = arraySum[i];
    minIndexStr = i;
}
    }
    string indexStr = string.Empty;
for (int i = 0; i < arraySum.Length; i++) // цикл для проверки на наличие других строк с этой суммой
    {
    if(arraySum[i] == minSum && i!=minIndexStr)
{
    indexStr = Convert.ToString(minIndexStr+1) + "," + Convert.ToString(i+1);
}
    }
if (indexStr == "")
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndexStr + 1}");
else
Console.WriteLine($"Номера строк с наименьшей суммой элементов: {indexStr}"); 