//Код для пятого задания
int a;
float S = 0;
int n = 0;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out a);
while (a > 0)
{
    S = S + a;
    ++n;
    Console.WriteLine("Введите следующее число");
    int.TryParse(Console.ReadLine(), out a);
}
Console.WriteLine($"Ответ {S / n} ");
return 0;