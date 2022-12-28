Console.Clear();

int vvod(int number)
{
    int count = 0;
    while (number != 0)
    {
        if (number > 0) count++;
        number = int.Parse(Console.ReadLine());
    }
    return count;
}

Console.WriteLine("Введите числа, для прекращения ввода введите - 0");
int res = vvod(int.Parse(Console.ReadLine()));
Console.WriteLine($"Колличество чисел больше 0 равно {res}");
