 /* Напишите программу, которая принимает на вход число и выдаёт 
 сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{number} -> ");
int result = 0;
int count = 1;
SummNumber(number);
Console.Write($"{result}");



int SummNumber(int number)
{ 
    while(number > 0)
    {        
        count = number%10;
        result = result + count;
        number = number/10;
    }
    return result;
}

