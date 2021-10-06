using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch3_제어문
{
    class 가위바위보
    {
        static void Main(string[] args)
        {
            int[] comCnt = { 0,0, 0, 0 };
            int[] myCnt = { 0, 0, 0 };
            int myInput, comInput, win;

            while (true)
            {
                Console.Write("1, 2, 3 중 하나의 수 입력 : ");
                myInput = Convert.ToInt32(Console.ReadLine());
                if (myInput == -1)
                {
                    Console.WriteLine("총 게임 횟수 {0}번", comCnt[0]);
                    Console.WriteLine("컴의 가위 = {0}, 컴의 바위 = {1}, 컴의 보 = {2}", comCnt[1], comCnt[2], comCnt[3]);
                    Console.WriteLine("서로 비김 = {0}, 내가 승 = {1}, 내가 패 = {2}", myCnt[1], myCnt[0], myCnt[2]);
                    break;
                }
                Random now = new Random();
                comInput = now.Next(1, 4);
                comCnt = computerCount(comCnt, comInput);
                win = whoWin(myInput, comInput);    //1: 내가이김, 2: 비김, 3: 컴이 이김
                switch (win)
                {
                    case 1:
                        Console.WriteLine("내가 이김");
                        myCnt[0]++;
                        break;
                    case 2:
                        Console.WriteLine("서로 비김");
                        myCnt[1]++;
                        break;
                    case 3:
                        Console.WriteLine("내가 패");
                        myCnt[2]++;
                        break;
                }
                Console.WriteLine("컴의 선택은 {0}", comInput);
                Console.WriteLine("------------------------------------");
            }
            
        }
        public static int[] computerCount(int[] cnt, int what)
        {
            cnt[0]++;
            cnt[what]++;
            return cnt;
        }
        public static int whoWin(int my, int com)
        {
            if (my == com) return 2;

            if (my < 3) my++;
            else my = 1;

            if (my == com) return 3;
            else return 1;
        }
    }
}
