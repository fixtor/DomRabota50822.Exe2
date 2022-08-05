int a; // первое число
int b; // второе число
Console.Write("Введите чилcо a ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
b = Convert.ToInt32(Console.ReadLine());
if (a < b)
    Console.WriteLine("Максимальное число " + b + "\n");
    else 
        Console.WriteLine("Maксимальное число " + a + "\n");
    