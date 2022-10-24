/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
*/

Console.Clear();
Console.Write("Введите номер строки: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(6, 6, 0, 10);
SearchElement(array);
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

void SearchElement(int[,] inArray)
{
    if (rows > inArray.GetLength(0) ^ columns > inArray.GetLength(1)) Console.Write($"Нет элемента с такими индексами");
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == rows - 1 && j == columns - 1) Console.Write($"Значение элемента с такими индексаими -> {inArray[i, j]} ");
        }
    }
    Console.WriteLine();

}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}    ");
        }
        Console.WriteLine();
    }
}