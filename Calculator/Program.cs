using System;

namespace Calculator;

public class Programm
{
    public static int ShowMenu()
    {
        Console.WriteLine("Menü:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraktion");
        Console.WriteLine("3. Multiplikation");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Potenzieren");
        Console.WriteLine("6. n-te Wurzel ziehen");
        Console.WriteLine("7. Exit");

        int selection;
        while (true)
        {
            string input = Console.ReadLine();


            if (!int.TryParse(input, out selection))
            {
                Console.WriteLine("Bitte Zahlen von 1 - 7 auswählen!");
                continue;
            }
            if (selection >= 8)
            {
                Console.WriteLine("Bitte nur Zahlen 1 - 7 eingeben!");
                continue;
            }
            if (selection == 7)
            {
                Console.WriteLine("Auf Widersehen!");
                Environment.Exit(0);
            }
            return selection;
        }
    }

    public static double GetNum1()
    {
        while (true)
        {
            double num;
            Console.WriteLine("Gebe die erste Zahl ein:");
            string numinput = Console.ReadLine();
            if (!double.TryParse(numinput, out num))
            {
                Console.WriteLine("Bitte nur Zahlen verwenden!");
                continue;
            }
            else return num;
        }
    }

    public static double GetNum2()
    {
        while (true)
        {
            double num;
            Console.WriteLine("Gebe die zweite Zahl ein:");
            string numinput = Console.ReadLine();
            if (!double.TryParse(numinput, out num))
            {
                Console.WriteLine("Bitte nur Zahlen verwenden!");
                continue;
            }
            else return num;
        }
    }

    public static double? Calculate(int selection, double x, double y)
    {
        switch (selection)
        {
            case 1:
                return x + y;
            case 2:
                return x - y;
            case 3:
                return x * y;
            case 4:
                return x / y;
            case 5:
                return Math.Pow(x, y);
            case 6:
                return Math.Pow(y, (1 / x));
        }
        return null;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Heyho, willkommen bei meinem Taschenrechner");
        Console.WriteLine("Creator: Violet G.");
        Console.WriteLine("GitHub: https://github.com/VioletMondlicht");
        Console.WriteLine("Version 1.1.0");

        while (true)
        {
            int selection = ShowMenu();

            double num1 = GetNum1();
            double num2 = GetNum2();

            if (selection == 4 && num2 == 0)
            {
                Console.WriteLine("Division durch 0 nicht möglich!");
                continue;
            }

            double? result = Calculate(selection, num1, num2);
            if (result == null)
            {
                Console.WriteLine("Unbekannter Fehler.");
            }
            else
            {
                if (double.IsInfinity((double)result))
                    Console.WriteLine("Ergebnis zu lang.");
                else
                    Console.WriteLine($"Dein Ergebnis ist: {result}");
            }
        }
    }
}