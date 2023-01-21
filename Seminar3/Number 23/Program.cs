// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= N)
{
    int rezult = Convert.ToInt32(Math.Pow(count,3));
    Console.WriteLine(rezult);
    count++;
}
