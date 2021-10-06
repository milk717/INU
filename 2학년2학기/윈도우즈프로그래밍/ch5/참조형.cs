using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class kbs
    {
        public int a = 5;
    }
    class 참조형
    {
        static void Main(string[] args)
        {
            kbs k1 = new kbs();
            kbs k2 = k1;

            Console.WriteLine("k1의 a값은 {0}, k2의 a값은 {1}",k1.a,k2.a);

            k2.a = 12;
            Console.WriteLine("k1의 a값은 {0}, k2의 a값은 {1}", k1.a, k2.a);
        }
    }
}
