using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ввидите число  N1: ");
            int N1 = int.Parse(Console.ReadLine());
            Console.Write("ввидите число  N2: ");
            int N2 = int.Parse(Console.ReadLine());
            Console.Write("ввидите строку S1: ");
            string S1 = Console.ReadLine();
            Console.Write("ввидите строку S2: ");
            string S2 = Console.ReadLine();
            for (int i = 0; i < N1; i++)
            {
                Console.Write(S1[i]);
            }
            for (int n = S2.Length - N2; n < S2.Length; n++)
            {
                Console.Write(S2[n]);
            }

            Console.ReadKey();
        }
    }
}
