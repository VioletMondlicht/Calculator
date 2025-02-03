using System;

namespace Calculator;

public class Programm
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Heyho, willkommen bei meinem Taschenrechner");
        Console.WriteLine("Creator: Violet G.");
        Console.WriteLine("GitHub: https://github.com/VioletMondlicht");
        Console.WriteLine("Version 1.1.0");

        while (true)
        {
            Console.WriteLine("Menü:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potenzieren");
            Console.WriteLine("6. n-te Wurzel ziehen");
            Console.WriteLine("7. Exit");

            string input = Console.ReadLine();

            int selection;
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
                return;
            }
            else
            {
                double result = 0;

                while (true)
                {
                    double num1;
                    Console.WriteLine("Gebe die erste Zahl ein:");
                    string numinput1 = Console.ReadLine();
                    if (!double.TryParse(numinput1, out num1))
                    {
                        Console.WriteLine("Bitte nur Zahlen verwenden!");
                        continue;
                    }
                    else
                    {
                        while (true)
                        {
                            double num2;
                            Console.WriteLine("Gebe die zweite Zahl ein:");
                            string numinput2 = Console.ReadLine();
                            if (!double.TryParse(numinput2, out num2))
                            {
                                Console.WriteLine("Bitte nur Zahlen verwenden!");
                                continue;
                            }
                            else
                            {
                                switch (selection)
                                {
                                    case 1:
                                        result = Add(num1, num2);
                                        break;
                                    case 2:
                                        result = Subtract(num1, num2);
                                        break;
                                    case 3:
                                        result = Multiply(num1, num2);
                                        break;
                                    case 4:
                                        if (num2 == 0)
                                        {
                                            Console.WriteLine("Bitte nicht durch 0 dividieren!");
                                            continue;
                                        }
                                        else
                                        {
                                            result = Divide(num1, num2);
                                            break;
                                        }
                                    case 5:
                                        result = Pow(num1, num2);
                                        break;
                                    case 6:
                                        result = Sqrt(num1, num2);
                                        break;
                                    default:
                                        Console.WriteLine("Eingabe nicht erkannt. Bitte starten Sie neu.");
                                        continue;
                                }
                                break;
                            }
                        }
                        if (double.IsInfinity(result))
                        {
                            Console.WriteLine("Ergebnis zu lang.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Dein Ergebnis ist: {result}");
                            break;
                        }
                    }
                    double Add(double x, double y) => x + y;
                    double Subtract(double x, double y) => x - y;
                    double Multiply(double x, double y) => x * y;
                    double Divide(double x, double y) => x / y;
                    double Pow(double x, double y) => Math.Pow(x, y);
                    double Sqrt(double x, double y) => Math.Pow(y, (1 / x));

                }
                continue;
            }
        }
    }
}