using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main()
        {
            /* ------------------------------------- */
            Console.WriteLine("-- Lesson 1 -----"); //"Hello World" to the console
            Console.WriteLine("Hello World!");

            /* ------------------------------------- */
            Console.WriteLine("-- Lesson 2 -----"); //First look at types/variables
            string greeting = "Tutorial";
            //Tutorial Version:
            Console.WriteLine($"{greeting} is a go!");
            //Version I see elsewhere
            //Console.WriteLine("Hello {0}!", "World");


            /* ------------------------------------- */
            Console.WriteLine("-- Lesson 3 -----"); //Working with strings, null, empty, etc.
            //String Ops Used in the Tutorial:
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine("\"\" == String.Empty is {0}", "" == String.Empty); //Don't forget to escape the quotes...
            Console.WriteLine("nullString == null is {0}", nullString == null);   //Wouldn't let me just have "string nullString;" - error CS0165: Use of unassigned local variable 'nullString'
            Console.WriteLine("The nullString shows as '{0}' when you do String.IsNullOrEmpty(nullString).",String.IsNullOrEmpty(nullString));

            Console.WriteLine("greeting is {0} characters long.",greeting.Length);

            string greetingTemplate = "Welcome to the [greeting]";
            string templateFilled = greetingTemplate.Replace("[greeting]",greeting);
            Console.WriteLine($"If greetingTemplate is '{greetingTemplate}', and greeting is '{greeting}', then greetingTemplate.Replace(); is '{templateFilled}'");


            /* ------------------------------------- */
            Console.WriteLine("-- Lesson 4 -----"); //Working with Dates and Times
            var currentTime = DateTime.Now;                     //Current Time
            var today = DateTime.Today;                         //Current Date, time is midnight
            var someDate = new DateTime(1980,12,25);            //A DateTime set to 25 Dec 1980, midnight
            var someMoment = new DateTime(1980,12,24,13,22,50); //A DateTime set to 24 Dec 1980 13:22:50
        }
    }
}