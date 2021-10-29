using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ch4_배열
{
    class 문자열비교2
    {
        static void Main(string[] args)
        {
            string[] s1 = new string[] { "kbs" };
            string[] s2 = new string[] { "kbs" };

            if (s1 == s2)
            {
                Console.WriteLine("s1 과 s2 는 같다");
            }
            else
            {
                Console.WriteLine("s1 과 s2 는 다르다");
            }
        }
    }
}
