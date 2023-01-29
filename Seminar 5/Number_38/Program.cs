// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = new int[6];
void FillMassiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
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
int max = arr[0];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
   if(arr[i]>max)
   {
    max = arr[i];
   }
   if(arr[i]<min)
   {
    min = arr[i];
   }
}
int z = max - min;
PrintArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементами равна  {z}");