//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] arr = new int[12];
int[] arr2 = new int[12];
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

for (int i = 0; i < 12; i++)
{
    
        arr2[i] = arr[i]*-1;
       
}
PrintArray(arr);
PrintArray(arr2);
