/*  Напишите цикл, который принимает на вход два числа (A и B) и возводит
число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.Write("Введите число a:  ");
string userInput1 = Console.ReadLine() ?? "";
int userNumber1 = int.Parse(userInput1);

Console.Write("Введите степень числа:  ");
string userInput2 = Console.ReadLine() ?? "";
int userNumber2 = int.Parse(userInput2);

int result = userNumber1;
Exponentiate(userNumber2);

Console.WriteLine($"{userNumber1}, {userNumber2} -> {result}");


int Exponentiate(int userNumber2)
{
    int count = 1;
    while (count < userNumber2)
    {
        result = result * userNumber1;
        count++;
    }
    return result;
}

