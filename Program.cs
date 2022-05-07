class TestClass
{
    static void Main(string[] args)
    {
        // Convert first string into long type
        long num = Int64.Parse(args[0]);
        System.Console.WriteLine(num);

        // Use long type to parse, aliasing Int64.
        num = long.Parse(args[0]);
        System.Console.WriteLine(num);

        // Use Convert class method ToInt64 to do the same as the previous two.
        num = Convert.ToInt64(args[0]);
        System.Console.WriteLine(num);
    }
}