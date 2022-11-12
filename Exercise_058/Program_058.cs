/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] matrix1 = GetArray(4, 2, 0, 9);
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = GetArray(2, 4, 0, 9);
PrintArray(matrix2);
int[,] matrix3 = MatrixMultiplikation(matrix1, matrix2);
Console.WriteLine();
PrintArray(matrix3);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] MatrixMultiplikation(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine($"Умножение невозможно");     
    }
    int[,] array = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            array[i, j] = 0;
            for (int n = 0; n < matrix1.GetLength(1); n++)
            {
                array[i, j] += matrix1[i, n] * matrix2[n, j];
            }
        }
    }
    return array;
}