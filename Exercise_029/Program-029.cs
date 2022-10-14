/* Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] array = GetInputNumbers(8);
GetOutputNumbers(8);
Console.Write($"{array[7]} -> [");
GetOutputNumbers(8);
Console.Write(array[7] + "]");

// Методы

int GetOutputNumbers(int Size)
    {    
      for (int i = 0; i < 7; i++)
      {
        Console.Write(array[i] + ", ");
      }   
      return array[7];
    }
 


  static int[] GetInputNumbers(int Size)
  {
    int[] num = new int[Size];
    for (int i = 0; i < Size; i++)
      {
        Console.Write($"Введите {i +1} число массива: ");
        num[i] = int.Parse(Console.ReadLine() ?? "");
      }

    return num;
  }