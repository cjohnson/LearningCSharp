class TestClass
{
    static void Main(string[] args)
    {
        double dNumber = 23.15;

        // Double to Integer(32) conversion
        try 
        {
            int iNumber = System.Convert.ToInt32(dNumber);
            System.Console.WriteLine(iNumber);
        }
        catch (System.OverflowException) 
        {
            System.Console.WriteLine("Overflow in double to int conversion.");
        }

        // Double to Boolean conversion
        bool bNumber = System.Convert.ToBoolean(dNumber);
        System.Console.WriteLine(bNumber);

        // Double to String Conversion
        string strNumber = System.Convert.ToString(dNumber);
        System.Console.WriteLine("\"{0}\"", strNumber);

        // String to Character Conversion
        try 
        {
            char chrNumber = System.Convert.ToChar(strNumber[0]);
            System.Console.WriteLine(chrNumber);
        }
        catch (System.ArgumentNullException)
        {
            System.Console.WriteLine("String is null");
        }
        catch (System.FormatException)
        {
            System.Console.WriteLine("String length is greater than 1.");
        }

        int newInteger = 0;
        try
        {
            System.Console.WriteLine("Enter an integer:");
            newInteger = System.Convert.ToInt32(
                System.Console.ReadLine()
            );
        }
        catch(System.ArgumentNullException)
        {
            System.Console.WriteLine("String is null.");
        }
        catch(System.FormatException)
        {
            System.Console.WriteLine("String does not consist of an " +
                "optional sign followed by a series of digits.");
        }
        catch(System.OverflowException)
        {
            System.Console.WriteLine("Overflow in string to int conversion");
        }

        System.Console.WriteLine("Your integer as a double is {0}.", System.Convert.ToDouble(newInteger));
    }
}