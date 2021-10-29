using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 다른네임스페이스;

namespace ch7_상속
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ClassOne.insa();

            //다른네임스페이스.OtherClass.insa();
            OtherClass.insa();

        }
    }

   class ClassOne
    {
        public static void insa()
        {
            Console.WriteLine("안녕..");
        }
    }
}
