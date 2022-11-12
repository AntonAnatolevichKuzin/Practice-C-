/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[,] array = GetArray(4, 4);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int number = 1;
    int[,] result = new int[m, n];
    int i = 0;
    int j = 0;
    while (number < (result.GetLength(0) * result.GetLength(1)) + 1)
    {
        result[i, j] = number;
        number++;
        if (i <= j + 1 && i + j < result.GetLength(0) - 1) j++;
        else if (i < j && i + j >= result.GetLength(1) - 1) i++;
        else if (i >= j && i + j > result.GetLength(0) - 1) j--;
        else i--;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}