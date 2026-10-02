Console.WriteLine($"Введи число");
int N = int.Parse(Console.ReadLine());
int number = 1;


while (number <= 10)
{
   Console.WriteLine(N * number);
   number++;
}



Console.WriteLine("введи имена");

string name = Console.ReadLine();
int coll = 0;


while (name != "конец")
{
   name = Console.ReadLine();
   coll++;
}
Console.WriteLine($"количество имен: {coll}");


