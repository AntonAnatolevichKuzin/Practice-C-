/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
элементов: 1 строка 
*/

int[,] array = GetArray(4, 4, 0, 9);
PrintArray(array);
int[] res = GetArraySumString(4, array);
int number = NumberMinString (res);
Console.WriteLine($"Наименьшая сумма элементов на {number} строке.");



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

int[] GetArraySumString(int size, int[,] array)
{
    int[] res = new int[size];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        res[n] = sum;
        n++;
    }
    return res;
}

int NumberMinString(int[] res)
{
    int min = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        if (res[i] < res[min]) min = i;        
    }
    min = min + 1;
    return min;
}