#region Перегрузка методов
Console.WriteLine("***** Fun with Method Overloading *****");
Console.WriteLine($"Summ: \t{Calculator.Add(10, 10)}");
Console.WriteLine($"Summ: \t{Calculator.Add(4.6, 7.9)}");
Console.WriteLine($"Summ: \t{Calculator.Add(900_000_000, 900_000_000_000)}");


#endregion
public class Calculator
{
    public static int Add(int x, int y)
    { return x + y; }

    public static long Add(long x, long y)
    { return x + y; }

    public static double Add(double x, double y)
    { return x + y; }
}