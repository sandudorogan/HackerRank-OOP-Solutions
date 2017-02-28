using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAbstractClass
{
    public abstract class Book
    {
        public string title;
        public abstract void SetTitle(string s);

        public string GetTitle()
        {
            return title;
        }
    }

    public class MyBook : Book
    {
        public override void SetTitle(string s)
        {
            title = s;
        }
    }

    public class MainClass
    {
        public static void Main(string[] args)
        {
            String title = Console.ReadLine();
            MyBook new_novel = new MyBook();
            new_novel.SetTitle(title);
            Console.WriteLine("The title is: " + new_novel.GetTitle());
            Console.ReadLine();
        }
    }
}