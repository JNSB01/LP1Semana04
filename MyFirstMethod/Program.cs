using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Receives 2 numbers from player and calls functions CountTo10 and CountToN
        /// twice (counting to 10 twice, and once for every given number)
        /// </summary>
        /// <param name="args">Arguments given on console</param>
        static void Main(string[] args)
        {
            string aux = Console.ReadLine();
            int nCount = Convert.ToInt32(aux);
            string aux2 = Console.ReadLine();
            int nCount2 = Convert.ToInt32(aux2);

            CountTo10();
            CountTo10();
            CountToN(nCount);
            CountToN(nCount2);
            CountToN(3,6);
        }
        /// <summary>
        /// Counts to 10
        /// </summary>
        private static void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                CountToN(10);
            }
        }

        /// <summary>
        /// Counts to number given by user
        /// </summary>
        /// <param name="n">Number given by user to which the method counts
        /// </param>
        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Counts the numbers between the given parametres
        /// </summary>
        /// <param name="n1">lower limit where the method starts counting
        /// </param>
        /// <param name="n2">higher limit to which the method counts</param>
        private static void CountToN(int n1, int n2)
        {
            for (int i = n1; i < n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}