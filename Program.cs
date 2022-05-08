public class Functions
{
    public static long Factorial(int n)
    {
        if ((n < 0) || (n > 20))
        {
            return -1;
        }

        long tempResult = 1;
        for (int i = 1; i <= n; ++i)
        {
            tempResult *= i;
        }
        return tempResult;
    }
}
class TestClass
{
    static int Main(string[] args)
    {
        if (args.Length == 0)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            System.Console.WriteLine("Usage: Factorial <number>");
            return 1;
        }

        int num;
        bool test = int.TryParse(args[0], out num);
        if (!test)
        {
            System.Console.WriteLine("Please enter a numeric argument.");
            System.Console.WriteLine("Usage: Factorial <number>");
            return 1;
        }

        long result = Functions.Factorial(num);

        if (result == -1)
            System.Console.WriteLine("Input must be >= 0 and <= 20.");
        else
            System.Console.WriteLine($"The Factorial of {num} is {result}.");

        return 0;
    }
}