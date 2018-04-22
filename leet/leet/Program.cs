using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet
{
    class Program
    {
        public static void Main ()
        {
            int num = Int32.Parse(Console.ReadLine());
            int[] res;
            res = CountBits(num);
            for (int i = 0; i <= num; ++i)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadLine();
        }

            public static int[] CountBits(int num)
            {
                int[] res = new int[num + 1];

                int offs = 0;
                int N = 0;
                res[0] = 0;
                for (N = 1; N <= num; N++)
                {
                    if ((N & (N - 1)) == 0) offs = N;
                    res[N] = res[N - offs] + 1;
                }

                return res;
            }
        
    }
}
