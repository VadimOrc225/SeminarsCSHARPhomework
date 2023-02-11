// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = new int[4, 4];
int k = 1;
int j = 0, i = 0;

while (j < array.GetLength(1)) // идем направо
    {
        if(array[i, j]==0)
        {array[i, j] = k;
        k=k+1; j=j+1;}
        else
        break;
        }
    i=i+1;j=j-1;
    
while (i < array.GetLength(0)) // идем вниз
    {
        if(array[i, j]==0)
        {array[i, j] = k;
        k=k+1; i=i+1;}
        else
        break;
    }
    j = j-1;i=i-1;

while (j >= 0) // идем налево
    {
       if(array[i, j]==0)
       {array[i, j] = k;
       k=k+1; j=j-1;}
       else
       break;
        
    }
    i = i - 1; j = j +1;
 
   while (i > 0) // идем наверх
    {
        if(array[i, j]==0)
        {array[i, j] = k;
        k=k+1; i=i-1;}
       else
       break;
    }
    j = j+1; i = i+ 1;
while (j < array.GetLength(1)) // идем направо
{
        if(array[i, j]==0)
        {array[i, j] = k;
        k=k+1; j=j+1;}
        else
        break;
}     
        i=i+1; j = j-1;

while (i < array.GetLength(0)-1) // идем вниз
    {
        if(array[i, j]==0)
        {array[i, j] = k;
        k=k+1; i=i+1;}
        else
        break;
    }
    j = j-1; i = i-1;
    
    while (j >= 0) // идем налево
    {
       if(array[i, j]==0)
       {array[i, j] = k;
       k=k+1; j=j-1;}
       else
       break;
        
    }
    i = i - 1; j = j +1;

for (int x = 0; x < array.GetLength(0); x++)
{
    for (int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write($"{array[x, y]} ");
    }
    Console.WriteLine();
}