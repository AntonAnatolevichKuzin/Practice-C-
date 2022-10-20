/*  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double b1 = GetUserNumber("Введите значение b1: ", "Ошибка. Попробуйте снова.");
double k1 = GetUserNumber("Введите значение k1: ", "Ошибка. Попробуйте снова.");
double b2 = GetUserNumber("Введите значение b2: ", "Ошибка. Попробуйте снова.");
double k2 = GetUserNumber("Введите значение k2: ", "Ошибка. Попробуйте снова.");
double coordX = (b2 - b1)/(k1 - k2);
double coordY = k1*coordX + b1;
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({coordX}; {coordY})");




int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber );
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}