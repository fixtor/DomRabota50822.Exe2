Console.Clear();
Random rnd = new Random();
int n = rnd.Next(20, 90);
Console.WriteLine("n: " + n + "\n");
Console.WriteLine("Проверим деление. Введите случайное число: ");
int d = Convert.ToInt32(Console.ReadLine());
string mes1 = (n % d == 0) ? "Делится" : "не делится";
Console.WriteLine("Число {0} {1}", n, mes1);
Console.ReadKey();