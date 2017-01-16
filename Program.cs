using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            //Tutorial Version:
            string greeting = "Tutorial";
            Console.WriteLine($"{greeting} is a go:");

            //Version I see elsewhere
            //Console.WriteLine("Hello {0}!", "Test");

            //String Ops Used in the Tutorial:
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine("\"\" == String.Empty is {0}", "" == String.Empty); //Don't forget to escape the quotes...
            Console.WriteLine("nullString == null is {0}", nullString == null); //Wouldn't let me just have "string nullString;" - error CS0165: Use of unassigned local variable 'nullString'
            Console.WriteLine("The nullString shows as '{0}' when you do String.IsNullOrEmpty(nullString).",String.IsNullOrEmpty(nullString));

            Console.WriteLine("greeting is {0} characters long.",greeting.Length);

            string greetingTemplate = "[greeting] is a go:";
            string templateFilled = greetingTemplate.Replace("[greeting]",greeting);
            Console.WriteLine($"If greetingTemplate is '{greetingTemplate}', and greeting is '{greeting}', then greetingTemplate.Replace(); is '{templateFilled}'");
        }
    }
}