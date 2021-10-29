using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Exception_Thread
{
    class CarDriver
    {
        public static void Start() { Console.WriteLine("집으로 출발"); }
        public static void GoForward() { Console.WriteLine("100미터 직진"); }
        public static void GoLeft() { Console.WriteLine("50미터 좌회전"); }
        public static void GoRight() { Console.WriteLine("70미터 우회전"); }
        public static void Arrive() { Console.WriteLine("집 도착"); }

        //대리자 생성: 의미상으로 대리운전, class와 같은 레벨로 생성해도 됨 == 네임스페이스 안에 바로
        //대리자에 등록된 순서대로 동작 - 시간차를 제어 할 수 없음이 제약
        public delegate void GoHome();

        static void Main(string[] args)
        {
            Console.WriteLine("[1]메서드 따로 따로 호출");
            CarDriver.GoLeft();
            CarDriver.GoRight();
            Console.WriteLine("\n");

            Console.WriteLine("[2]대리자를 통한 메서드 등록 및 호출");
            GoHome go = new GoHome(CarDriver.Start);    //대리자에 등록
            go += new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoLeft);
            go -= new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.Arrive);
            go();       //대리자에 등록된 것 한 번에 모두 호출
            Console.WriteLine();
            Console.WriteLine("대리자에 등록된 순서대로 동작 - ");
            Console.WriteLine("그러나 시간차를 제어 할 수 없음이 제약임");
            Console.WriteLine("그래서 Thread가 필요함");
        }
    }
}
