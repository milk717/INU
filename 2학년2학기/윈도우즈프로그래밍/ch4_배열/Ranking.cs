using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Ranking
    {
        static void Main(string[] args)
        {
            int[] Num = new int[5] { 33, 22, 44, 55, 11 };
            int[] Rank = new int[5] { 0, 0, 0, 0, 0 };
            for(int i= 0;  i < Num.Length; i++)
            {
                for(int j = 0; j<Num.Length; j++)
                {
                    if (Num[i] < Num[j]) Rank[i]++;
                }
            }
            for (int i = 0; i < Num.Length; i++)
            {
                Console.WriteLine("점수 {0} 는 {1} 등임",Num[i],Rank[i]+1);
            }
        }
    }
}
