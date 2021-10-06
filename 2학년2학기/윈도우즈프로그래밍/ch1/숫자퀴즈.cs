using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch1
{
    class 숫자퀴즈
    {
        static void Main(string[] args)
        {
            Random su = new Random();
            int fix_su = su.Next(1, 100);
            string res = "";
            while (res != "정답") {
                res = GBB.result(fix_su);
                Console.WriteLine(res);
            }
        }
        
    }
}
