using System;

var arr = new int[5, 5];
Random rnd = new Random();
int sum = 0;
bool start = false;
bool end = false;
for (int i = 0; i < arr.GetLength(0); i++)
    for (int j = 0; j < arr.GetLength(1); j++)
        arr[i, j] = rnd.Next(-100, 100);
int max = arr[0, 0];
int min = arr[0, 0];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]}\t");
        if (arr[i, j] > max)
        {
            max = arr[i, j];
        }
        if (arr[i, j] < min)
        {
            min = arr[i, j];
        }
    }
    Console.WriteLine();
}
Console.WriteLine($"Максимум: {max} - Минимум: {min}");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (start)
        {
            if (max == arr[i, j] || min == arr[i, j])
            {
                end = true;
                break;
            }
            sum += arr[i, j];
            //Console.Write($"{arr[i, j]}\t");//JustforDebug
        }
        else if (max == arr[i, j] || min == arr[i, j])
            start = true;
    }
    if (end) { break; }
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов между максимумом и минимумом: {sum}");