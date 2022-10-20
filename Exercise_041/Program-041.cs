/*  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
int[] array = GetArray(size, -100000, 100000);
PrintArray(array);
int positiveNumber = PositiveNumber(array);
Console.Write($" -> {positiveNumber}");


// Methods

int PositiveNumber(int[] arrey)
{
    int number = 0;
    for (int i = 0; i < size; i++)
    {
        if(arrey[i] > 0) number++;
    }
    return number;
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
        Console.Write("Введите значение элемента массива: ");
        res[i] = int.Parse(Console.ReadLine() ?? "");
    }

    return res;
}