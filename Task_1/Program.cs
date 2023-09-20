using System;
double MaxDouble(double[,] arr)
{
    double result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            result = arr[i, j] > result ? arr[i, j] : result;
    return result;
}
int MaxValue(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result = arr[i] > result ? arr[i] : result;
    }
    return result;
}
double MinDouble(double[,] arr)
{
    double result = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            result = arr[i, j] < result ? arr[i, j] : result;
    return result;
}
int MinValue(int[] arr)
{
    int result = arr[0];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        result = arr[i] < result ? arr[i] : result;
    }
    return result;
}

int[] A = new int[5];
double[,] B = new double[3, 4];
Random rnd = new Random();

Console.WriteLine("Write 5 Numbers: ");
for (int i = 0; i < A.Length; i++)
    A[i] = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < B.GetLength(0); i++)
    for (int j = 0; j < B.GetLength(1); j++)
        B[i, j] = rnd.NextDouble() * (7 - 3) + 3;
for (int i = 0; i < A.Length; i++)
    Console.Write($"|{A[i]}|");
Console.WriteLine();
for (int i = 0; i < B.GetLength(0); i++)
{
    for (int j = 0; j < B.GetLength(1); j++)
        Console.Write($"|{B[i, j]}|");
    Console.WriteLine();
}
Console.WriteLine(MaxDouble(B));
Console.WriteLine(MinDouble(B));
Console.WriteLine(MaxValue(A));
Console.WriteLine(MinValue(A));
Console.WriteLine(B.GetLength(0));
Console.WriteLine(B.GetLength(1));