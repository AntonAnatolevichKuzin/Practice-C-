/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] array = GetArray(3, 3, 3, 10, 99);
int[] temp = ConvertArrayThreeToOne(array);
CorrectArray(temp);
ConvertArrayOneToThree(array, temp);
PrintArray(array);


int[,,] GetArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] res = new int[m, n, k];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int z = 0; z < k; z++)
            {
                res[i, j, z] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return res;
}

int[] ConvertArrayThreeToOne(int[,,] array)
{
    int[] temporary = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                temporary[n] = array[i, j, z];
                n++;
            }
        }
    }
    return temporary;
}

void CorrectArray(int[] temporary)
{
    for (int i = 0; i < temporary.GetLength(0); i++)
    {
        int temp = temporary[i];
        if (i > 0)
        {
            for (int n = 0; n < i; n++)
            {
                while (temp == temporary[n])
                {
                    temporary[i] = new Random().Next(10, 100);
                    n = 0;
                    temp = temporary[i];
                }
                temp = temporary[i];

            }
        }
    }
}

void ConvertArrayOneToThree(int[,,] array, int[] temp)
{
    int[,,] res = new int[array.GetLength(0), array.GetLength(1), array.GetLength(2)];
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = temp[count];
                count++;
            }
        }
    }

}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int z = 0; z < inArray.GetLength(2); z++)
            {
                Console.WriteLine($"{inArray[i, j, z]} ({i}, {j}, {z}) ");
            }
        }
        Console.WriteLine();
    }
}
