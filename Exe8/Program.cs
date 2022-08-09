Console.Clear();
int a = 0;
Console.WriteLine("введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (a = 1; a <= n; a++)
{
//Console.WriteLine($"Тест {a}      {n}");
    if ((a % 2) == 0)
        Console.Write($" {a} ");
}
Console.ReadKey();
