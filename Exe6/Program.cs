Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.WriteLine("четное");
else
    Console.WriteLine("не четное");
Console.ReadKey();