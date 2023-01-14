Console.Write("Введите Ваше число: ");
int a = Convert.ToInt32(Console.ReadLine());
int ost = a % 2;
if (ost == 0)   
Console.Write("Введенное число четное");
else
Console.Write("Введенное число нечетное");