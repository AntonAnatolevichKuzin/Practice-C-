//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int varA;
while (true)
{
    Console.Write("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine($"Ошибка ввода");
}


if (varA < 100)
{
    Console.WriteLine($"{varA} -> третьей цифры нет");
}
else
{
    if (varA < 1000)
    {
        Console.WriteLine($"{varA} -> {(varA%100)%10}");
    }
    else
    {
        if (varA < 10000)
        {
            Console.WriteLine($"{varA} -> {(varA%100)/10}");
        }
        else
        {
            Console.WriteLine($"{varA} -> {(varA%1000)/100}");
        }
    }
}