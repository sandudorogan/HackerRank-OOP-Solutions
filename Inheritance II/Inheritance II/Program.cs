using System;

namespace Inheritance_II
{
    internal class Program
    {
        private static void Main()
        {
            // Create a new Adder object
            var a = new Adder();

            // Print the name of the superclass on a new line
            Console.WriteLine("My superclass is: " + a.GetType().BaseType?.Name);

            // Print the result of 3 calls to Adder's `add(int,int)` method as 3 space-separated integers:
            Console.WriteLine(a.add(10, 32) + " " + a.add(10, 3) + " " + a.add(10, 10) + "\n");

            Console.Read();
        }
    }
}