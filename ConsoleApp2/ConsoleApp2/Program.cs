Console.WriteLine("Введите различные x и y соответственно");
double x = double.Parse(Console.ReadLine());
double y = double.Parse(Console.ReadLine());
double polsum = (x + y) / 2;
double proizv = x * y * 2;
if (x > y)
{
    x = proizv;
    y = polsum;
}
else
{
    x = polsum;
    y = proizv;
}
Console.WriteLine($"x равен {x}; y равен {y}");