 Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
int[] arr = new int[12];

void Zapolnenie(int[] array)
{
    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-9,9);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Zapolnenie(arr);
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < 12; i++)
{
    if (arr[i] < 0)
    {
        sum1 = sum1 + arr[i];
    }
    else
    {
        sum2 = sum2 + arr[i];
    }
}
PrintArray(arr);
Console.Write($"Сумма отрицательных: {sum1}; ");
Console.Write($"Сумма положительных: {sum2}");
