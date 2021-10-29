using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class Total
    {
        static void Main(string[] args)
        {
            int n = 0;
            int cnt_h = 0, cnt_j = 0, sum_h = 0, sum_j = 0 ;
            do
            {
                Console.Write("정수 입력 : ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 == 0)
                {
                    cnt_j++;
                    sum_j += n;
                }
                else if (n % 2 == 1)
                {
                    cnt_h++;
                    sum_h += n;
                }
            } while (n != -1);
            Console.WriteLine("********************");
            Console.WriteLine("데이터 갯수 {0}",cnt_j+cnt_h);
            Console.WriteLine("짝수의 합 {0}",sum_j);
            Console.WriteLine("짝수의 갯수 {0}", cnt_j);
            Console.WriteLine("홀수의 합 {0}", sum_h);
            Console.WriteLine("홀수의 갯수 {0}", cnt_h);
        }
    }
}
