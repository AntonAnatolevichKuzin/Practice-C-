/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine($"Введите целое число N:  ");
int n = int.Parse(Console.ReadLine() ?? " ");
PrintNaturals(1,n);
Console.Write($"N = {n} -> ");
Console.WriteLine(PrintNaturals(1,n));

string PrintNaturals(int start, int end)
{
    if (start==end)
    {
        return end.ToString();
    }
    return (end + ", " + PrintNaturals(start, end -1));
}