
//using System;

//public class GFG
//{
//    public static int Fib(int n)
//    {
//        if (n <= 1)
//        {
//            return n;
//        }
//        else
//        {
//            return Fib(n - 1) + Fib(n - 2);
//        }
//    }

//    // driver code 
//    public static void Main(string[] args)
//    {
//        int n = 9;
//        Console.Write(Fib(n));
//    }
//}  
using System;
class Fibo_Using_DynamicP
{

    static int fib(int n)
    {

        // Declare an array to  
        // store Fibonacci numbers. 
        // 1 extra to handle  
        // case, n = 0 
        int[] f = new int[n + 2];
        int i;

        /* 0th and 1st number of the  
           series are 0 and 1 */
        f[0] = 0;
        f[1] = 1;

        for (i = 2; i <= n; i++)
        {
            /* Add the previous 2 numbers 
               in the series and store it */
            f[i] = f[i - 1] + f[i - 2];
        }

        return f[n];
    }

    public static void Main()
    {
        int n = 10;
        Console.WriteLine(fib(n));
    }
}
