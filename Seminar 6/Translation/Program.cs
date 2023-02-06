Console.WriteLine("Введите числo");
int num = Convert.ToInt32(Console.ReadLine());
string s = "";
while(num>0)
{
s = Convert.ToString(num%2) + s;
num/=2;
}

Console.WriteLine($"В двоичном виде {s}");