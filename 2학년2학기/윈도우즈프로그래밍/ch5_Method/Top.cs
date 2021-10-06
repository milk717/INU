using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class Top
    {
        public int a;
        public int b;
        public int hap()
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Top su = new Top();
            su.a = 3;
            su.b = 6;
            int sum = su.hap();
            Console.WriteLine("{0} + {1} = {2}",su.a,su.b,sum);
        }
    }
}
