/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array = GetArray(3, 4, 0, 9);
PrintArray(array);
SortArray(array);
Console.WriteLine();
PrintArray(array);


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

void SortArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0) ; i++)
    {
        for (int j = 0; j < inArray.GetLength(1) - 1; j++)
        {
            int minPosition = j;
            for (int n = j +1; n < inArray.GetLength(1); n++)
            {                
                if (inArray[i,n] > inArray[i,minPosition])
                {
                    minPosition = n;
                }                
            }
            int temp = inArray[i, j];
            inArray[i, j] = inArray[i, minPosition];
            inArray[i, minPosition] = temp;
        }
    }
}