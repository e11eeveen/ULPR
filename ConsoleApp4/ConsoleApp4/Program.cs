//Код для четвертого задания
int n, четные = 0, нечетные = 0;
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out n);
n *= 10;
for (int i = 0; i < n; i++)
{
    n /= 10;
    if ((n % 10) % 2 == 0) четные++;
    else нечетные++;

}
Console.WriteLine($"четных {четные}, нечетных {нечетные} ");
Console.ReadKey(true);