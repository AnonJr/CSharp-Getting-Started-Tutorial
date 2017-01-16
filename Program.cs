using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            //Tutorial Version:
            string userName = "Tutorial";
            Console.WriteLine($"{userName} is a go:");

            //Version I see elsewhere:
            //Console.WriteLine("Hello {0}!", "Test");

            //String Ops Used in the Tutorial:
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine("\"\" == String.Empty is {0}", "" == String.Empty); //Don't forget to escape the quotes...
            Console.WriteLine("nullString == null is {0}", nullString == null); //Wouldn't let me just have "string nullString;" - error CS0165: Use of unassigned local variable 'nullString'
        }
    }
}