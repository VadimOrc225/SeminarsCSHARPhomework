// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

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
int z = 0;
for (int i = 0; i < 12; i++)
{
    if (arr[i] == x)
    {
      z = 1;
    }
    
}

PrintArray(arr);
if (z == 1)
    {
      Console.WriteLine("да");
    }
else 
    Console.WriteLine("нет");

