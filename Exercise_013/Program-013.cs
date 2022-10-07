//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int varA;
while (true)
{
    Console.Write("Введите день недели: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine($"Ошибка ввода");
}

if (varA > 0 && varA < 6)
{
    Console.WriteLine($"{varA} -> нет");
}
    if (varA > 5 && varA < 8)
    {
        Console.WriteLine($"{varA} -> да");
    }

