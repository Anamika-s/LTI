using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        // Intellisense
        static void Main()
        {
            int x, y;
            x = 10;
            y = 20;
            int ch = 3;
            if(ch==1)
            Console.WriteLine("Sum of {0} and {1} is {2} ", x,y,(x+y));
            else if(ch==2)
            Console.WriteLine("Difference of {0} and {1} is {2}",x,y,(x - y));
            else if(ch==3)
            Console.WriteLine("Product of {0} and {1} and {2} " , x,y ,x * y);
            else if(ch==4)
            Console.WriteLine("Quotient of " + x + " and " + y + " is  " + x / y);
            else
                Console.WriteLine("Invaid Statement");
        }
    }
}
