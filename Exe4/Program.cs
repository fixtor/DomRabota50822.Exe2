Console.Clear();
int max;
Console.Write("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чиcло b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чиcло c ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
    max = a;
else
    max = b;
if (max < c)
    max = c;
Console.WriteLine("максимальное число: " + max);
Console.ReadKey();