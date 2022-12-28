// y = k1 * x + b1, y = k2 * x + b2;
Console.Clear();
double straight(double i)
{
    return i;
}

Console.WriteLine("Введите k1");
double k1 = straight(double.Parse(Console.ReadLine()));

Console.WriteLine("Введите k2");
double k2 = straight(double.Parse(Console.ReadLine()));

Console.WriteLine("Введите b1");
double b1 = straight(double.Parse(Console.ReadLine()));

Console.WriteLine("Введите b2");
double b2 = straight(double.Parse(Console.ReadLine()));

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Прямые пересекуться в точке ({x};{y})");