/* Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] array = GetArray(6, 0, 10);
PrintArray(array);
double maxNumber = GetMaxNumber(array);
double minNumber = GetMinNumber(array);
Console.Write($" -> {maxNumber - minNumber}");





double GetMinNumber(double[] array)
{
    double minNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {                
        if(array[i] < minNumber)
        {
            minNumber = array[i];            
        }
    }
    return minNumber;
}


double GetMaxNumber(double[] array)
{
    double maxNumber = array[0];
    for(int i = 0; i < array.Length; i++)
    {                
        if(array[i] > maxNumber)
        {
            maxNumber = array[i];                        
        }
    }
    return maxNumber;
}


void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble() * 100;
    }

    return res;
}