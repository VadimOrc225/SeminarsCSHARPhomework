// // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [N];
for (int i = 2; i < N; i++)
    {
            arr[0] = 0;
            arr[1] = 1;
            arr[i] = arr[i-2] + arr[i-1];
    }  
       
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
