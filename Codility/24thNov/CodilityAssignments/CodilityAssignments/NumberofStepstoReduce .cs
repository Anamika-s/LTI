using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityAssignments
{
    class Soultion { 
    static int NumberofStepstoReduce(String s)
    {
        // if the size of binary is 1 
        // then the number of actions will be zero 
        if (s.Length == 1)
            return 0;

        // initializing the number of actions as 0 at first 
        int count_ = 0;
        char[] s1 = s.ToCharArray();
        for (int i = s.Length - 1; i > 0;)
        {
            // start traversing from the last digit 
            // if its 0 increment the count and decrement i 
            if (s1[i] == '0')
            {
                count_++;
                i--;
            }

            // if s[i] == '1' 
            else
            {
                count_++;

                // stop until you get 0 in the binary 
                while (s1[i] == '1' && i > 0)
                {
                    count_++;
                    i--;
                }
                if (i == 0)
                    count_++;

                // when encounter a 0 replace it with 1 
                s1[i] = '1';
            }
        }
        return count_;
    }

    // Driver code 
    public static void Main(String[] args)
    {
        String s;
        s = "10000100000";

        Console.WriteLine(NumberofStepstoReduce(s));
    }
} 
  
}
