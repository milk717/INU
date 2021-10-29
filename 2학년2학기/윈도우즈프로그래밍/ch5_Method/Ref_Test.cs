using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class Ref_Test
    {
        static void CallByRef(ref int x)
        {
            Console.WriteLine("함수내로 전달된 값 : {0}",x);
            x = 1000;
            Console.WriteLine("함수내 재 지정한 값 : {0}", x);
        }

        static void Main(string[] args)
        {
            int y = 50;
            CallByRef(ref y);
            Console.WriteLine("Call By Ref : {0}",y);
        }
    }
}
