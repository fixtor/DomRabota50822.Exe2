Console.Clear();
Console.Write("Введите чилcо a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чилcо b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чилcо c ");
int c = Convert.ToInt32(Console.ReadLine());
if (a < b && a < c)
{
    if (b < c)
        Console.WriteLine("максимальное число: " + c);
    else Console.WriteLine("максимальное число: " + b);
}
else Console.WriteLine("максимальное число: " + a);