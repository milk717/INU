using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Exception_Thread
{
    delegate void SimpleDelegate1();        //매개변수 없는 델리게이트
    delegate void SimpleDelegate2(int i);       //매개변수 있는 델리게이트
    class aaaa
    {
        public void Gun()
        {
            Console.WriteLine("Gun 총알 발사");
        }
        public void Missile(int x)
        {
            Console.WriteLine("Missile {0} 개 발사",x);
        }
        static void Main(string[] args)
        {
            aaaa dele = new aaaa();     //클래스 인스턴스 dele 생성
            SimpleDelegate1 s1 = new SimpleDelegate1(dele.Gun);
            SimpleDelegate2 s2 = new SimpleDelegate2(dele.Missile);
            s1();
            s2(3);
        }
    }
}
