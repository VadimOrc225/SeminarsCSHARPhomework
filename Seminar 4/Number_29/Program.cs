int[] arr = new int[8];

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Zapolnenie(int[] array)
{
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,100);
    }
}

Zapolnenie(arr);
PrintArray(arr);