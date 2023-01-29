
Console.WriteLine("Введите массив чисел через запятую");
string s = Console.ReadLine();
string[] nums = s.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] n = nums.Select(Int32.Parse).ToArray();
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
        sum = sum + n[i];
    }
}

Console.WriteLine($"Сумма положительных элементов равна {sum}");