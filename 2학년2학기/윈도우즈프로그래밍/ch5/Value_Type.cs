using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class Value_Type
    {
        static void CallByValue(int x)
        {
            Console.WriteLine("함수내로 전달된 값 : {0}", x);
            x = 1000;
            Console.WriteLine("함수내에서 재 지정한 값 : {0}", x);
        }
        static void Main(string[] args)
        {
            int y = 50;
            CallByValue(y);
            Console.WriteLine("Call By Value : {0}",y);
        }
    }
}
