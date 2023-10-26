using System;
namespace Inlämningsuppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många minuter är låten");
            int minuter = int.Parse(Console.ReadLine());
            Console.WriteLine("hur många sekunder är låten");
            int sekunder = int.Parse(Console.ReadLine());
            int totalasekunder = minuter * 60 + sekunder;
            int mingräns = 2 * 60 + 45;
            int maxgräns = 4 * 60 + 20;
            if (totalasekunder >= mingräns && totalasekunder <= maxgräns)
            {
                Console.WriteLine("låten får spelas");
            }
            else
            {
                Console.WriteLine("låten får inte spelas");
            }
        }
    }
}
