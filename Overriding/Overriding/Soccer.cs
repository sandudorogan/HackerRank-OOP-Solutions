using System;

namespace Overriding
{
    public class Soccer : Sports
    {
        public override string GetName()
        {
            return "Soccer Class";
        }

        public override void GetNumberOfTeamMembers()
        {
            Console.WriteLine("Each team has 11 players in " + GetName());
        }
    }
}