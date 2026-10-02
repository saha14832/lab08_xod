// Console.WriteLine($"Введи число");
// int N = int.Parse(Console.ReadLine());
// int number = 1;


// while (number <= 10)
// {
//    Console.WriteLine(N * number);
//    number++;
// }



// Console.WriteLine("введи имена");

// string name = Console.ReadLine();
// int coll = 0;


// while (name != "конец")
// {
//    name = Console.ReadLine();
//    coll++;
// }
// Console.WriteLine($"количество имен: {coll}");


// Console.Write("Введите свою фамилию: "); 
// string surname = Console.ReadLine()!.Trim(); 
 
// if (string.IsNullOrEmpty(surname)) { 
//     Console.WriteLine("Фамилия не введена. Завершение работы."); 
//     return; 
// } 
 
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
 
// var assigned = Enumerable.Range(1, 10) 
//     .OrderBy(_ => rnd.Next()) 
//     .Take(2) 
//     .OrderBy(x => x) 
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");





// string correct = "qwerty123";
// int number = 0;



// while (true)
// {
//    Console.Write("веди пароль личного кабинета :");
//    string passw = Console.ReadLine();

//    if (passw == correct)
//    {
//       Console.WriteLine("доступ разрешён");
//       break;
//    }
//    Console.WriteLine("неверный пароль");
//    number++;

// }
// Console.WriteLine($"количество не удач:{number}");




Console.WriteLine($"Введи число");
int N = int.Parse(Console.ReadLine());
int number = 1;


while (number <= N)
{
   Console.WriteLine(number * number);
   number++;
}



string correct = "qwerty123";
int gg = 0;
int tt = 1;


while (true)
{
   Console.Write("Введи пароль личного кабинета :");
   string passw = Console.ReadLine();
   if (tt <= 3)
   {
      if (passw == correct)
      {
         Console.WriteLine("доступ разрешён");
         break;
      }
      Console.WriteLine("неверный пароль");
      gg++;
      tt++;
   }
   else
   {
      Console.WriteLine("стоп");
   }

}
Console.WriteLine($"количество не удач:{gg}");
