Console.Clear();
Console.Write("Введите чилcо a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
    Console.WriteLine("Максимальное число " + b);
    else 
        Console.WriteLine("Maксимальное число " + a);
Console.ReadKey();
