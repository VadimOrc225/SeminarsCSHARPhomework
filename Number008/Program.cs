Console.Write("Введите Ваше число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 2;   
while (count <= a) 
{
if (count < a-1)
Console.Write($"{count}, ");
else
Console.Write($"{count}");
count = count + 2;
}