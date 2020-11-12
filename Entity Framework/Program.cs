using System;
using System.Runtime.CompilerServices;

namespace EntityFrameworkOgolla
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.Title = "Entity Framework Intro";
            Console.WriteLine(Console.Title + ": Hello World!!!");
            
            p.ManipulateDB();

            Console.ReadLine();
        }

        private void ManipulateDB()
        { }
    }
}
