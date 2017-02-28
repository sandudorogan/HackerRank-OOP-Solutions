using System;

namespace Overriding
{
    public class Sports
    {
        public virtual string GetName()
        {
            return "Generic Sports";
        }

        public virtual void GetNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has n players in " + GetName());
        }
    }
}