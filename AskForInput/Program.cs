using System;

namespace AskForInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro:");
            int valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero real:");
            float real = float.Parse(Console.ReadLine());

            Console.WriteLine($"A soma dos números é {valor + real}");

            


            
        }
    }
}
