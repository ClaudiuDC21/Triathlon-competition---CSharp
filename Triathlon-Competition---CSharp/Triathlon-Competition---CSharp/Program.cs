using System;
using Proiect_csharp.Domain;

namespace Proiect_csharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("mergee");
            Competitor competitor = new Competitor("Negru", "Dan", 21, "running");
            Contest contest = new Contest("running", "Istvan Kovacs");
            Console.WriteLine(contest.ToString());
            Console.WriteLine(competitor.ToString());
        }
    }
}