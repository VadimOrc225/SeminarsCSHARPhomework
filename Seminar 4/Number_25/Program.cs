Console.WriteLine("Введите основание степени ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите показатель степени ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
int z = N;
while (count<a)
{
z = z * N;
count++;
}
Console.WriteLine($"Ответ: {z}");