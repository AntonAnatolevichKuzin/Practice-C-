 int varA;
      while(true)
      {
      Console.Write("Введите трёхзначное число: ");
        if(int.TryParse(Console.ReadLine(),out varA))
         break;               
      Console.WriteLine($"Ошибка ввода");
      }

      int f1 = varA/10;
      int f2 = f1%10;

      Console.WriteLine($"{varA} -> {f2}");

