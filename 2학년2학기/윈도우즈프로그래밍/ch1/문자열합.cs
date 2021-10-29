using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 문자열합
    {
        static void Main(string[] args)
        {
            string s1, s2, s3;
            Console.WriteLine("문자열 s1 입력 : ");
            s1 = Console.ReadLine();
            Console.WriteLine("문자열 s2 입력 : ");
            s2 = Console.ReadLine();
            s3 = s1 + s2;
            Console.WriteLine(s3);
        }
    }
}
