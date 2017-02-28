using System;
using System.Collections;

namespace InstanceOf
{
    public class Student
    {
    }

    public class Rockstar
    {
    }

    public class Hacker
    {
    }

    public class Program
    {
        public static string Count(ArrayList myList)
        {
            int a = 0, b = 0, c = 0;
            foreach (var element in myList)
            {
                if (element is Student)
                    a++;

                if (element is Rockstar)
                    b++;

                if (element is Hacker)
                    c++;
            }

            var ret = Convert.ToString(a) + " " + b + " " + c;
            return ret;
        }

        private static void Main()
        {
            var myList = new ArrayList();
            var t = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                if (s.Equals("Student"))
                    myList.Add(new Student());

                if (s.Equals("Rockstar"))
                    myList.Add(new Rockstar());

                if (s.Equals("Hacker"))
                    myList.Add(new Hacker());
            }

            Console.Write(Count(myList));
            Console.ReadLine();
        }
    }
}