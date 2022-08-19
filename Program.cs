void task41()
{
    Console.WriteLine("Сколько чисел вы хотите ввести?");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;

    for(int i = 0; i < m; i++)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        if(number > 0) count++;
    }
    Console.WriteLine($"Было введено {count} чисел(-ла) больше нуля");
}
task41();

void task43()
{
    int k1 = 0;
    int b1 = 2;
    int k2 = 1;
    int b2 = 1;

    if (k1 == k2)
    {
        Console.WriteLine("Нет точки пересечения, прямые параллельны");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        double y2 = k2 * x + b2;
        Console.WriteLine($"Координаты точки пересечения А({Math.Round(x, 2)}, {Math.Round(y)})");
        Console.WriteLine($"Координаты точки пересечения А({Math.Round(x, 2)}, {Math.Round(y2)})");
    }
}
task43();