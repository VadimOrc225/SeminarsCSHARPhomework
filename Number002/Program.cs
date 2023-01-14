Console.Write("Введите значение a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)   
Console.Write($"max = {a}");
if (b > a)
Console.Write($"max = {b}");
if (b == a)
Console.Write("Введенные числа равны");