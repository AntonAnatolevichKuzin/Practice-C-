/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int number;

while (true)
{
    Console.Write("Введите пятизначное число: ");
    if (int.TryParse(Console.ReadLine(), out number))
        if (number < 100000 && number > 9999)
            break;
    Console.WriteLine($"Ошибка ввода");
}

int n1 = number / 10000;
int n2 = number / 1000 % 10;
int n3 = number / 100 % 10;
int n4 = number / 10 % 10;
int n5 = number % 10;


if (n1 != n5 && n2 != n4)
{
    Console.Write($"{number} -> нет");
}
else
{
    Console.Write($"{number} -> да");
}

