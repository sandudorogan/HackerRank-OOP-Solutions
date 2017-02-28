using System;

namespace Overriding_II
{
    public class MotorCycle : BiCycle
    {
        public MotorCycle()
        {
            Console.WriteLine("Hello I am a motorcycle, I am " + define_me());

            var temp = base.define_me();
            Console.WriteLine("My ancestor is a cycle who is " + temp);
        }

        public sealed override string define_me()
        {
            return "a cycle with an engine.";
        }
    }
}