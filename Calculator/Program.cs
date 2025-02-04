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

        while (true)
        {
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int selection))
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

    public static void Main(string[] args)
    {
        Console.WriteLine("Heyho, willkommen bei meinem Taschenrechner");
        Console.WriteLine("Creator: Violet G.");
        Console.WriteLine("GitHub: https://github.com/VioletMondlicht");
        Console.WriteLine("Version 1.1.0");

        while (true)
        {
            int selection = ShowMenu();
            Calculator calc = new();
            calc.GetNum1();
            calc.GetNum2();

            switch (selection)
            {
                case 1:
                    calc.Add();
                    break;
                case 2:
                    calc.Substract();
                    break;
                case 3:
                    calc.Multiply();
                    break;
                case 4:
                    calc.Divide();
                    break;
                case 5:
                    calc.Pow();
                    break;
                case 6:
                    calc.Sqrt();
                    break;
            }
        }
    }
}