/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int num1 = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
if (num1 < num2)
{
    Console.WriteLine($"M = {num1}; N = {num2} -> {SumNaturals(num1, num2)}");
}
else
{
    Console.WriteLine($"Вывод невозможен, {num1} больше {num2}");
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int SumNaturals(int start, int end)
{
    if (start == end)
    {
        return start;
    }

    return (start  + SumNaturals(start + 1, end));
}