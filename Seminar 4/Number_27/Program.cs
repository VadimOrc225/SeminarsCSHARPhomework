Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 10;
int x = N % 10;
int sum = 0;
while (N / count != 0)
{
sum = sum + (N / count) % 10;
count = count * 10;
}
sum = sum + x;
Console.WriteLine($"Сумма цифр числа равна {sum}");