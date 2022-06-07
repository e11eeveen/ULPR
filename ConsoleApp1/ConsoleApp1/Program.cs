Console.WriteLine("Введите длину ребра");
double a = double.Parse(Console.ReadLine());
double V = Math.Pow(a, 3);
double S = a * a * 6;
Console.WriteLine($"{V}, {S}");