if(args.Length > 0)
{
    foreach (var arg in args)
    {
        System.Console.WriteLine($"Argument={arg}");
    }
}
else
{
    System.Console.WriteLine("No arguments");
}