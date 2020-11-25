//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Codility_Day4
//{
//    class GenomicRangeQuery
//    {
//        static void Main()
//        {
//            string S = "CAGCCTA";
//            int[] P = new int[] { 2, 5, 0 };
//            int[] Q = new int[] { 4, 5, 6 };

//            var result = solution(S, P, Q);
//            foreach(var temp in result)
//                Console.WriteLine(temp);
//        }

//        public static int[] solution(string S, int[] P, int[] Q)
//        {
//            var nucleo = new int[S.Length + 1, 4];
//            for (var count = 0; count < S.Length; count++)
//            {
//                if (count > 0)
//                {
//                    for (var index = 0; index < 4; index++)
//                    {
//                        nucleo[count + 1, index] += nucleo[count, index];
//                    }
//                }
//                switch (S[count])
//                {
//                    case 'A':
//                        nucleo[count + 1, 0]++;
//                        break;
//                    case 'C':
//                        nucleo[count + 1, 1]++;
//                        break;
//                    case 'G':
//                        nucleo[count + 1, 2]++;
//                        break;
//                    case 'T':
//                        nucleo[count + 1, 3]++;
//                        break;
//                }
//            }

//             for(int i= 0;i<8;i++)
//            {
//                for(int j=0;j<4;j++)
//                {
//                    Console.Write(nucleo[i,j] + "  ");
//                }
//                Console.WriteLine();
//            }
//            var result = new int[P.Length];
//            for (var count = 0; count < P.Length; count++)
//            {
//                if (P[count] == Q[count])
//                {
//                    switch (S[P[count]])
//                    {
//                        case 'A':
//                            result[count] = 1;
//                            break;
//                        case 'C':
//                            result[count] = 2;
//                            break;
//                        case 'G':
//                            result[count] = 3;
//                            break;
//                        case 'T':
//                            result[count] = 4;

//                            break;
//                    }
//                }
//                else
//                {
//                    for (var index = 0; index < 4; index++)
//                    {
//                        if ((nucleo[Q[count] + 1, index] - nucleo[P[count], index]) > 0)
//                        {
//                            result[count] = index + 1;
//                            break;
//                        }
//                    }
//                }
//            }

//            return result;

//            // write your code in C# 6.0 with .NET 4.5 (Mono)
//        }
//    }
//}