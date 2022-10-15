/*  Задайте одномерный массив, заполненный случайными числами. Найдите 
сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] array = GetArray(8, -100, 100);
PrintArray(array);
int sumNumbers = GetSumNumbers(array);
Console.Write($" -> {sumNumbers}");




int GetSumNumbers(int[] array)
{
    int sumNumbers = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sumNumbers = sumNumbers + array[i];
    }
    return sumNumbers;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }

    return res;
}