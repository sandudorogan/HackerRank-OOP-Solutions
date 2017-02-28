using System;
using System.Collections;

namespace Iterator
{
    internal class Program
    {
        private static IEnumerator Func(ArrayList myList)
        {
            var it = myList.GetEnumerator();
            while (it.MoveNext())
                if (it.Current is string)
                    break;

            return it;
        }

        private static void Main()
        {
            var myList = new ArrayList();
            var n = Convert.ToInt32(Console.ReadLine());
            var m = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < n; i++)
                myList.Add(Convert.ToInt32(Console.ReadLine()));

            myList.Add("###");
            for (var i = 0; i < m; i++)
                myList.Add(Console.ReadLine());

            var it = Func(myList);
            while (it.MoveNext())
                Console.WriteLine(it.Current.ToString());

            Console.ReadLine();
        }
    }
}