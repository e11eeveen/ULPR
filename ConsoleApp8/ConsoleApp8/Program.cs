﻿//Код для второго задания без вариантов
Console.Write("Год: ");
int c = int.Parse(Console.ReadLine());
Console.Write("Месяц: ");
int b = int.Parse(Console.ReadLine());
Console.Write("День: ");
int a = int.Parse(Console.ReadLine());
var dY = new DateTime(c, b, a);
var dG = dY.AddDays((c / 100) - ((c / 100) / 4) - 2);
Console.WriteLine($"По юлианскому календарю – {dY}");
Console.WriteLine($"По григорианскому календарю – {dG}");
