using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class 빈도수_최빈값
    {
        static void Main(string[] args)
        {
            int intMax = 0;
            int intIndex = 0;
            int[] in_num = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] count = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


            for (int i = 0; i < in_num.Length; i++)
            {
                in_num[i] = i;
            }

            for (int i = 0; i<in_num.Length; i++)
            {
                Console.Write("숫자 0부터 9사이 값 10개 입력 : ");
                intIndex = Convert.ToInt32(Console.ReadLine());
                count[intIndex]++;
            }

            Console.WriteLine("입력값\t빈도수");
            for (int i = 0; i < in_num.Length; i++)
            {
                Console.WriteLine("{0}\t{1}",in_num[i],count[i]);
                intMax = (intMax < count[i] ? count[i] : intMax);
                intIndex = (intMax < count[i] ? i : intIndex);
            }
            Console.WriteLine("최빈값은 {0}이(가) {1}번 나타남",intIndex,intMax);
        }
    }
}
