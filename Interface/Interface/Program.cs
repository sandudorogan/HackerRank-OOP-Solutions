using System;

namespace Interface
{
    public class Program
    {
        private static void Main()
        {
            var myCalculator = new MyCalculator();

            Console.WriteLine("I implemented: ");
            ImplimentationInterfacesNames(myCalculator);

            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(myCalculator.divisor_sum(n));

            Console.ReadKey();
        }

        private static void ImplimentationInterfacesNames(object o)
        {
            var theInterfaces = o.GetType().GetInterfaces();
            foreach (var theInterface in theInterfaces)
                Console.WriteLine(theInterface.Name);
        }
    }
}