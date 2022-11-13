/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int m = GetNumberFromUser("Введите число M: ", "Ошибка ввода!");
int n = GetNumberFromUser("Введите число N: ", "Ошибка ввода!");
Console.WriteLine($"m = {m}; n = {n} -> {FunctionAkk(m, n)}");



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

int FunctionAkk(int m, int n)
{
    if (m == 0 && n > 0) return (n + 1);
    else if (n == 0 && m > 0) return FunctionAkk(m - 1, 1);
    else return FunctionAkk(m - 1, FunctionAkk(m, n - 1));
}
