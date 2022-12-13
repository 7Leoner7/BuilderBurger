using System;

namespace BuilderBurger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder= new Builder();
            Director dir = new Director(builder);
            
            string result = dir.Create().ToString();
            Console.WriteLine(result);
        }
    }
}
