using System;

class TimeConverter
{
    static void Main()
    {
        Console.WriteLine("Конвертер времени");
        Console.WriteLine("Выберите режим:");
        Console.WriteLine("1. 12-часовой формат в 24-часовой");
        Console.WriteLine("2. 24-часовой формат в 12-часовой");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Convert12To24();
                break;
            case 2:
                Convert24To12();
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }
    }

    static void Convert12To24()
    {
        Console.Write("Введите время в 12-часовом формате (например, 02:30 PM): ");
        string inputTime = Console.ReadLine();

        DateTime time;
        if (DateTime.TryParse(inputTime, out time))
        {
            Console.WriteLine("Время в 24-часовом формате: " + time.ToString("HH:mm"));
        }
        else
        {
            Console.WriteLine("Неверный формат времени.");
        }
    }

    static void Convert24To12()
    {
        Console.Write("Введите время в 24-часовом формате (например, 14:30): ");
        string inputTime = Console.ReadLine();

        DateTime time;
        if (DateTime.TryParse(inputTime, out time))
        {
            Console.WriteLine("Время в 12-часовом формате: " + time.ToString("hh:mm tt"));
        }
        else
        {
            Console.WriteLine("Неверный формат времени.");
        }
    }
}
