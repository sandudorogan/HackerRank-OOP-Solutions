using System;

namespace Inheritance_I
{
    internal class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Sing()
        {
            Console.WriteLine("I am singing");
        }
    }
}