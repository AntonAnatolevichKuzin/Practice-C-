/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] array = GetArray(5, 5, -10, 10);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца: ");
double sra = SRA(array);

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

double SRA(int[,] inArray)
{    
    double sra = 0;
    for(int j = 0; j < inArray.GetLength(1); j++)
    {
        int sum = 0;        
        for(int i =0; i <inArray.GetLength(0); i++)
        {            
            sum +=  inArray[i, j];            
        }
        sra = Math.Round((double)sum / inArray.GetLength(0), 2);
        Console.Write($" {sra} ");
    }
    return sra;
}