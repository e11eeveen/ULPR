//Код для первого задания без вариантов
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        DateTime dt;
        Console.WriteLine("Введите день");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите месяц");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите год");
        int c = int.Parse(Console.ReadLine());
        string date = $"{c}, {b}, {a}";
        int countDaysOfEndOfYear;
        GregorianCalendar calendar = new GregorianCalendar();
        if (DateTime.TryParse(date, out dt))
        {
            Console.WriteLine(calendar.GetDayOfYear(dt));
            if (calendar.IsLeapYear(c))
            {
                countDaysOfEndOfYear = 366 - calendar.GetDayOfYear(dt);

            }
            else
            {
                countDaysOfEndOfYear = 365 - calendar.GetDayOfYear(dt);
            }
            Console.WriteLine(countDaysOfEndOfYear);
        }
        else
        {
            Console.WriteLine("Неверная дата ");
        }
    }
}
