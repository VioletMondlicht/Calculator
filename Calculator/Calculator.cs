namespace Calculator;

public class Calculator
{
    private string sResult = "Ihr Ergebnis ist: ";
    private string sInfinityError = "Ausgabe zu lang.";
    private double Result { get; set; }
    private double X { get; set; }
    private double Y { get; set; }

    public void GetNum1()
    {
        while (true)
        {
            Console.WriteLine("Gebe die erste Zahl ein:");
            string numinput = Console.ReadLine();
            double num;
            if (!double.TryParse(numinput, out num))
            {
                Console.WriteLine("Bitte nur Zahlen verwenden!");
                continue;
            }
            X = num;
            return;
        }
    }
    public void GetNum2()
    {
        while (true)
        {
            Console.WriteLine("Gebe die zweite Zahl ein:");
            string numinput = Console.ReadLine();
            double num;
            if (!double.TryParse(numinput, out num))
            {
                Console.WriteLine("Bitte nur Zahlen verwenden!");
                continue;
            }
            Y = num;
            return;
        }
    }
    public void Add()
    {
        Result = X + Y;
        PrintResult();
    }
    public void Substract()
    {
        Result = X - Y;
        PrintResult();
    }
    public void Multiply()
    {
        Result = X * Y;
        PrintResult();
    }
    public void Divide()
    {
        if (Y == 0)
        {
            Console.WriteLine("Bitte nicht mit 0 dividieren");
        }
        else
        {
            Result = X / Y;
            PrintResult();
        }
    }
    public void Pow()
    {
        Result = Math.Pow(X, Y);
        PrintResult();
    }
    public void Sqrt()
    {
        Result = Math.Pow(Y, (1 / X));
        PrintResult();
    }
    public void PrintResult()
    {
        if (double.IsInfinity(Result))
        {
            Console.WriteLine($"{sInfinityError}");
        }
        else Console.WriteLine($"{sResult} {Result}");
    }
}