using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Exception_Thread
{
    class DelegateDemo
    {
        static void Hi()
        {
            Console.WriteLine("Hello...");
        }

        delegate void SayDelegate();        //매개변수 반환값 없는 대리자 생성

        static void Main(string[] args)
        {
            SayDelegate insa = new SayDelegate(Hi);     //매개변수 사용
            insa();     //Hi 함수를 insa 델리게이트 이름으로 대신해서 호출
        }
    }
}
