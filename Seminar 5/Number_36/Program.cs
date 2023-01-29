// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19

int[] arr = new int[6];
void FillMassiv(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,20);
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
int sum = 0;
for (int i = 1; i < arr.Length; i=i+2)
{
   sum = sum + arr[i];
}

PrintArray(arr);
Console.WriteLine($"Сумма чисел, на нечетных позициях (НЕЧЕТНЫЕ ИНДЕКСЫ) равна  {sum}");