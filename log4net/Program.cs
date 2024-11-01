//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace log4net
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
using log4net;
using System;
public class LoggingExample
{
    public static void Divide(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException ex)
        {
            Logger.LogError("Attempted to divide by zero.", ex);
           

            Console.WriteLine("\n");
            Console.WriteLine("DivideByZeroException caught and logged.");
        }
    }
    public static void Main()
    {
        Divide(10, 0);
        Console.ReadLine();
    }
}