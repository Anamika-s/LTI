using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Codility_Day2
{
    class BinaryGap
    {
        static void Main()
        {
            int result = solution(20);
            Console.WriteLine(result);
        }

        private static int solution(int v)
        {
            var binary = Convert.ToString(v, 2);
            Console.WriteLine(binary);
            var regex = new Regex("(?<=1)(0+)(?=1)");
            int result = regex.Matches(binary)
                .Cast<Match>()
                .Select(x => x.Length)
                .DefaultIfEmpty(0)
                .Max();
            return result;
        }
    }
}
