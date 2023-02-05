for (int x5 = 5; x5 < 300; x5++)
{
    int x4 = x5 - 4, x3 = x5 - 3, x2 = x5 - 2, x1 = x5 - 1;
    if (Convert.ToInt64((Math.Pow(x1, 5)) + (Math.Pow(x2, 5)) + (Math.Pow(x3, 5)) + (Math.Pow(x4, 5))) == Convert.ToInt64(Math.Pow(x5, 5)))
        Console.WriteLine($"x1 = {x1}, x2 = {x2}, x3 = {x3}, x4 = {x4}, x5 = {x5}");

}


