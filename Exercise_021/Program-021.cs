/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int a1, a2, a3, b1, b2, b3;
a1 = Coordinates("Введите координату X первого числа: ");
a2 = Coordinates("Введите координату Y первого числа: ");
a3 = Coordinates("Введите координату Z первого числа: ");
b1 = Coordinates("Введите координату X второго числа: ");
b2 = Coordinates("Введите координату Y второго числа: ");
b3 = Coordinates("Введите координату Z второго числа: ");

double distance = Distance(a1, a2, a3, b1, b2, b3);

Console.WriteLine(distance);

// Методы

static int Coordinates(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

static double Distance(int a1, int a2, int a3, int b1, int b2, int b3)
{
    double result = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2) + Math.Pow(b3 - a3, 2));
    return result;
}