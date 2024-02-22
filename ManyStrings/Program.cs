using System;

namespace ManyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "I'm a string";
            string b = "I'm a more complex string";
            b = "Because I have changed";
            string c = "I'm a string just \\chilling\\ here \u2746";


            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
