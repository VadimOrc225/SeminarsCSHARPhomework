// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if ((N / 10000 == N % 10) && ((N / 1000) % 10 == (N % 100) / 10))
Console.Write("Да");
else
Console.Write("Нет");