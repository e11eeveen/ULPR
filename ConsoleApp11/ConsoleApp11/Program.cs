﻿//Код для пятого задания без вариантов
Console.WriteLine("Какой год: ");
int x = int.Parse(Console.ReadLine());
for (int i = 1; i <= 12; i++)
{
    DateTime d = new DateTime(x, i, DateTime.DaysInMonth(x, i));
    Console.WriteLine($"{d.Month} месяц: {d.Day - (7 + (int)d.DayOfWeek - 4) % 7}, четверг.");
}
