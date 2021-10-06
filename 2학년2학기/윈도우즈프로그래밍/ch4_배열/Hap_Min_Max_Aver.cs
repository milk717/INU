using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch4_배열
{
    class Hap_Min_Max_Aver
    {
        static void Main(string[] args)
        {
            int MAX = 0;
            int MIN = 0;
            int HAP = 0;
            int AVER = 0;

            int[] su = new int[7] { 1, 3, 5, 7, 2, 4, 6 };

            MAX = su[0];
            MIN = su[0];

            for (int i = 0; i<su.Length; i++)
            {
                MAX = (MAX < su[i]) ? su[i] : MAX;
                MIN = (MIN > su[i]) ? su[i] : MIN;
                HAP += su[i];
            }
            AVER = HAP / su.Length;

            Console.WriteLine("합계 {0}\n최대값 {1}\n최소값 {2}\n평균 {3}",HAP,MAX,MIN,AVER);
        }
    }
}
