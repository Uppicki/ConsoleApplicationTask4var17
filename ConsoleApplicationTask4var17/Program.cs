using System;

namespace ConsoleApplicationTask4var17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var un1 = new institutionOfHigherEducation(
                "VSU", 100, 75);
            var un2 = new improvedInstitution(
                "newVSU", 100, 75, 80);
            Console.WriteLine(un1);
            Console.WriteLine(un2);
        }
    }
}