using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 1, 4, 3, 2 };

            Console.WriteLine(ArrayPairSum(nums));
            Console.ReadLine();
        }

        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);

            int res = 0;
            int k = 0;
            while (k < nums.Length)
            {
                res += nums[k];
                k += 2;
            }
            return res;
        }
    }
}
