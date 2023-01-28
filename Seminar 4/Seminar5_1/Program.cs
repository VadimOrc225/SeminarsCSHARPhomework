string s = "abcd";
// string s = "Hello World";
// string s1 = "Hello";
// string s2 = "World";

// int[] nums = {1, 2, 3, 4, 5};

// string s3 = s1 + " " + s2;

// string s4 = string.Concat(s1, s2);

// string s5 = string.Join(" ", nums);
// 
// string s = "1, 2, 3, 4, 5, 6, 7";

// foreach (var item in s)
// {
//     Console.WriteLine(item);
// }
// Console.WriteLine(s5);

string s = "1, 2, 3, 4, 5, 6, 7.";

string[] nums = s.Split(new char[]{' ', '.', ','}, StringSplitOptions.RemoveEmptyEntries);

int[] n = nums.Select(Int32.Parse).ToArray();

foreach (var item in nums)
{
    Console.WriteLine(item);
}

string s1 = "10 21 35 45 57 68 79";
int[] num1 = Array.ConvertAll(s1.Split(), int.Parse);
