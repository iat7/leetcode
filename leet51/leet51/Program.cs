using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leet51
{
    class Program
    {
        public static IList<IList<string>> SolveNQueens(int n)
        {
            List<IList<string>> queens = new List<IList<string>>();
            Dfs(queens, new int[n], 0); //стартовая вершина - пустая доска
            return queens;
        }

        private static void Dfs(List<IList<string>> hole, int[] res, int row)
        {
            if (row == res.Length) //  целевая вершина — любая позиция с восемью ферзями (
                                   //правило получения вершины-преемника гарантирует, что ферзи не бьют друг друга)
            {
                List<string> currentList = new List<string>();



                for (int j = 0; j < res.Length; j++)
                {
                    StringBuilder sb = new StringBuilder();
                   // for (int k = 0; k < res.Length; k++)
                     //   if (res[j] == k) sb.Append("Q");
                       // else sb.Append(".");
                    string s = new string(res.Select(x => x == j ? 'Q' : '.').ToArray());
                    currentList.Add(s);
                }

                hole.Add(currentList);
                return;
            }
            //Позицию на доске будем представлять как список Y-координат поставленных ферзей. - массив res[]

            for (int i = 0; i < res.Length; i++)
            {
                bool bAvail = true;
                bAvail = !res
                    .Select((y, index) => new { Value = y, Index = index })
                    .Any(x => x.Value == i || Math.Abs(x.Value - i) == row - x.Index);
               // for (int j = 0; j < row; j++)
                 //   if (res[j] == i || Math.Abs(res[j] - i) == row - j)
                   //     bAvail = false;
                if (bAvail)
                {
                    int[] res2 = new int[res.Length];
                    Array.Copy(res, res2, res.Length);
                    res2[row] = i;
                    Dfs(hole, res2, row + 1);
                }
            }
            return;
        }

        static void Main(string[] args)
        {
            IList<IList<string>> res = SolveNQueens(8);
            int numOfDesk = 1;
            foreach (IList<string> desk in res)
            {
                Console.WriteLine("Solution #"+numOfDesk);
                foreach (string s in desk)
                {
                    Console.WriteLine(s);

                }
                numOfDesk++;
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
