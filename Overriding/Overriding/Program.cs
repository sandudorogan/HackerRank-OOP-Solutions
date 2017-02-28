using System;

namespace Overriding
{
    internal class Program
    {
        private static void Main()
        {
            var c1 = new Sports();
            var c2 = new Soccer();

            Console.WriteLine(c1.GetName());
            c1.GetNumberOfTeamMembers();
            Console.WriteLine(c2.GetName());
            c2.GetNumberOfTeamMembers();

            Console.ReadKey();
        }
    }
}