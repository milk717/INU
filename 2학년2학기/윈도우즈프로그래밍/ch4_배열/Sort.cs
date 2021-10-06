using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] a = new int[4] { 1, 3, 2, 4 };
            Console.WriteLine("정렬 전 데이터");
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write("{0} ",a[i]);
            }
            for(int j = 0; j<a.Length-1; j++)
            {
                for(int i = j+1; i<= a.Length-1; i++)   //현재탐색할거 다음꺼~마지막꺼 하나전
                {
                    if(a[j] < a[i])
                    {
                        int tmp = a[i];
                        a[i] = a[j];
                        a[j] = tmp;
                    }
                }
            }
            Console.WriteLine("정렬 후 데이터");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
    }
}
