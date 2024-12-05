using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;
                Console.WriteLine("ente com numero par: ");
                int x = int.Parse(Console.ReadLine());

                if (x % 2 == 0 ) {
                    Console.WriteLine("par!");
                }
                else
                {
                    Console.WriteLine("impar!");
                }
            }
        }
    }
}