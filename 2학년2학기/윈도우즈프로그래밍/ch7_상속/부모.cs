using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7_상속
{
    class 부모
    {
        public void Say()
        {
            Console.WriteLine("부모가 말하다.");
        }
    }
    class 자식: 부모
    {
        public new void Say()
        {
            Console.WriteLine("자식이 말하다.");
        }
        public void Hi()
        {
            Console.WriteLine("자식이 인사하다.");
        }
    }
}
