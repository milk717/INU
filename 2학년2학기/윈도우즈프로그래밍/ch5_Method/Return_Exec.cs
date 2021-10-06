using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch5_Method
{
    class Return_Exec
    {
        public static int toDoller(int won)
        {
            return won / 1100;
        }
        public static int toYen(int won)
        {
            return won / 10;
        }
        static void Main(string[] args)
        {
            int won = 0;
            Console.WriteLine("환산할 금액을 입력하세요");
            won = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("달러로 환산한 금액은 {0}",toDoller(won));
            Console.WriteLine("엔화로 환산한 금액은 {0}", toYen(won));
        }
    }
}
