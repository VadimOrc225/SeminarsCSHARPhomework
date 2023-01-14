Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение c: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > max)
max = b;
if (c > max)   
max = c;

Console.Write($"Максимальное число: {max}");