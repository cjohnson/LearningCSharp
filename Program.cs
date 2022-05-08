using System;
using System.Globalization;

class TestClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("NumberStyles.AllowDecimalPoint");
        Convert("63.00", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("63.00", NumberStyles.AllowDecimalPoint, new CultureInfo("en-US")); 
        Console.WriteLine();
        
        Console.WriteLine("NumberStyles.AllowExponent");
        Convert("63e2", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("63e2", NumberStyles.AllowExponent, new CultureInfo("en-US")); 
        Console.WriteLine();

        Console.WriteLine("NumberStyles.AllowLeadingWhite");
        Convert("  23", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("  23", NumberStyles.AllowLeadingWhite, new CultureInfo("en-US")); 
        Console.WriteLine();
      
        Console.WriteLine("NumberStyles.AllowTrailingWhite");
        Convert("23  ", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("23  ", NumberStyles.AllowTrailingWhite, new CultureInfo("en-US")); 
        Console.WriteLine();
       
        Console.WriteLine("NumberStyles.AllowLeadingSign");
        Convert("+23", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("+23", NumberStyles.AllowLeadingSign, new CultureInfo("en-US")); 
        Console.WriteLine();
        
        Console.WriteLine("NumberStyles.AllowTrailingSign");
        Convert("23+", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("23+", NumberStyles.AllowTrailingSign, new CultureInfo("en-US")); 
        Console.WriteLine();

        Console.WriteLine("NumberStyles.AllowParentheses");
        Convert("(23)", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("(23)", NumberStyles.AllowParentheses, new CultureInfo("en-US")); 
        Console.WriteLine();

        Console.WriteLine("NumberStyles.AllowThousands");
        Convert("12,000", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("12,000", NumberStyles.AllowThousands, new CultureInfo("en-US")); 
        Console.WriteLine();
        
        Console.WriteLine("NumberStyles.AllowCurrencySymbol");
        Convert("$23", NumberStyles.None, new CultureInfo("en-US")); 
        Convert("$23", NumberStyles.AllowCurrencySymbol, new CultureInfo("en-US")); 
        Console.WriteLine();
    }

    private static void Convert(string value, NumberStyles style,
                                IFormatProvider provider)
    {
        try
        {
            long number = Int64.Parse(value, style, provider);
            Console.WriteLine("Converted '{0}' to {1}", value, number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Unable to convert '{0}'.", value);
        }
        catch (OverflowException)
        {
            Console.WriteLine("'{0}' is out of range of the Int64 type.", value);
        }
    }
}