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
int[] arr = GetArraySumString(4, array);
PrintArray2(arr);



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
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int result = 0;
        for (int n = 0; n < size; n++)
        {
            
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result = result + array[i, j];
            }

            res[n] = result;
        }
        
    }

    return res;
}

void PrintArray2(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}
