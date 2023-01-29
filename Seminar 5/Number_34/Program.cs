// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] arr = new int[6];
void FillMassiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
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

FillMassiv(arr);
int z = 0;
for (int i = 0; i < arr.Length; i++)
{
    if ((arr[i] % 2) == 0)
    {
      z++;
    }
    
}

PrintArray(arr);
Console.WriteLine($"Положительных чисел в массиве {z}");
