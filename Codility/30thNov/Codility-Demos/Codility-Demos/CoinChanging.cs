using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Demos
{
    class CoinChanging
    {

        // All denominations of Indian Currency  
        static int[] deno = new[] {1, 2, 5, 10, 20,
    50, 100, 500, 1000};

        static void Main()
        {
            Console.WriteLine("ENter the Maount");
            int n = 170;
            findMin(deno, n);

        }
        static void findMin(int[] deno, int n)
        {
            int l = deno.Length;
            List<int> res = new List<int>();
            // Initialize result  

            Array.Sort(deno);
            // Traverse through all denomination  
            for (int i = l - 1; i >= 0; i--)
            {
                // Find denominations  
                while (n >= deno[i] && n >= 0)
                {
                    n -= deno[i];
                    res.Add(deno[i]);
                }
            }

            // Print result  
            for (int i = 0; i < res.Count; i++)
            {
                Console.WriteLine(res[i]);
            }
        }

    }
}
