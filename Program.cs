using System.Globalization;

class TestClass
{
    static void Main(string[] args)
    {
        // Convert 12,000 in United Kingdom English (12,000 en-US)
        Convert("12,000", NumberStyles.Float | NumberStyles.AllowThousands, new CultureInfo("en-GB")); 

        // Convert 12,000 in French (12 en-US)
        Convert("12,000", NumberStyles.Float | NumberStyles.AllowThousands, new CultureInfo("fr-FR")); 
        
        // Convert 12,000 in United States English (en-US)
        Convert("12,000", NumberStyles.Float, new CultureInfo("en-US")); 
        

        // Convert 12 425,00 in Swedish () 
        Convert("12 425,00", NumberStyles.Float | NumberStyles.AllowThousands, new CultureInfo("sv-SE")); 
        
        // Convert 12,425.00
        Convert("12,425.00", NumberStyles.Float | NumberStyles.AllowThousands, NumberFormatInfo.InvariantInfo); 
        
        // Convert 631,900 to an Integer in French (631.900 en-US)
        Convert("631,900", NumberStyles.Integer | NumberStyles.AllowDecimalPoint, new CultureInfo("fr-FR")); 
        
        // Convert 631,900 to an Integer in United States English (en-US)
        Convert("631,900", NumberStyles.Integer | NumberStyles.AllowDecimalPoint, new CultureInfo("en-US")); 
        
        // Convert 631,900 to an Integer in United States English (en-US)
        Convert("631,900", NumberStyles.Integer | NumberStyles.AllowThousands, new CultureInfo("en-US")); 
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