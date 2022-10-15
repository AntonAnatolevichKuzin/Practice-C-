/*  Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] array = GetArray(8, 99, 1000);
PrintArray(array);
int evenNumbers = GetEvenNumbers(array);
Console.Write($" -> {evenNumbers}");


// Methods

int GetEvenNumbers(int[] array)
{
    int evenNumbers = 0;
    foreach(int el in array)
    {
        if(el%2 == 0) evenNumbers++;        
    }
    return evenNumbers;
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