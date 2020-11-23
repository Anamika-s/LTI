using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_Day2
{
    class OddOccurrences_Using_XOR_Operartor
    {
        static void Main()
        {
            Console.WriteLine(Convert.ToString(9, toBase: 2));
            Console.WriteLine(Convert.ToString(0, toBase: 2));
            // Output:
            // 11100100
            Console.WriteLine(9^0);
            Console.Read();
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            //int resultunpaired = findUnPaired(A);
            //  //  Console.WriteLine(resultunpaired);
        }
        static int findUnPaired(int [] A)
        {
            int unpaired = 0;
            for(int i=0;i<A.Length-1;i++)
            {
                Console.WriteLine(unpaired);
                Console.WriteLine(A[i]);
                Console.WriteLine(unpaired ^ A[i]);

                unpaired = unpaired ^  A[i];
                //Console.Read();
            }
            return unpaired;
        }
    }
}
