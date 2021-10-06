using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 두수의합
    {
        static void Main(string[] args)
        {
            string s1, s2;
            int hap = 0;
            Console.WriteLine("하나의 수  s1 입력 : ");
            s1 = Console.ReadLine();
            Console.WriteLine("또 하나의 수  s2 입력 : ");
            s2 = Console.ReadLine();
            hap = Convert.ToInt32(s1) + Convert.ToInt32(s2);
            Console.WriteLine("{0}과 {1}의 합은 = {2}",s1,s2,hap);
        }
    }
}
