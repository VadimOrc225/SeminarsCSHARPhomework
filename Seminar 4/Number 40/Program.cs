// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

Console.WriteLine("Ведите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите первое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите первое число ");
int c = Convert.ToInt32(Console.ReadLine());
if(a<b+c&&b<a+c&&c<a+b)
Console.WriteLine("Треуг сущ ");
else
Console.WriteLine("Треуг не сущ ");