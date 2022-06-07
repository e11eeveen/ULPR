Random gen = new Random();
Console.WriteLine("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int j = 0; j < n; j++)
{
    array[j] = gen.Next(0, 15);
    Console.WriteLine(array[j]);
}
for (int i = 0; i < n; i++)
{
    if (array[i] % 3 == 0)
    {
        if (array[i] % 7 != 0)
        {
            sum = sum + 1;
        }
    }
}
Console.WriteLine("Сумма: ");
Console.WriteLine(sum);
