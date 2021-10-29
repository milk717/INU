using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch9_Exception_Thread
{
    class 예외처리
    {
        static void Main(string[] args)
        {
            //int i = 3;
            //int j = 1;      //1로 수정 후
            //int k = 0;
            ////k = 3 / 0;      //[1] 컴파일 에러 : 컴파일러가 찾아 줌

            ////k = i / j;      //[2] 런타임 에러 : 실행시켜 봐야 알 수 있다.
            //k = i + j;      //[3] 논리 에러 : 원래 의도는 i-j인데 실수로 i+1로 코딩 한 경우 결과값이 달라짐
            //Console.WriteLine(k);

            int i = 3;
            int j = 0;     
            int k = 0;

            try  //에러가 발생할 만한 의심이 되는 구문 입력
            {
                if (j != 0)     //0이 아니면 나누고
                {
                    k = i / j;
                }
                else  //0이면 개발자가 미리 예측
                {
                    //throw 문 : 개발자가 정의하는 에러 처리문
                    throw new Exception("제로가 오면 안됩니다. ");
                    k = i / j;      //throw문이 있으면 이 문장은 실행 안됨
                }
            }
            catch (Exception ex)  //에러가 발생되면 처리해야 할 코드 입력
            {
                Console.WriteLine("에러 발생됨 - 사람이 알려주는 메시지");
                Console.WriteLine(ex.Message);      //시스템이 알려주는 메세지
            }
            finally     //에러발생과 상관 없이 반드시 실행해야 할 문장
            {
                Console.WriteLine("프로그램을 종료합니다. ");
            }
            Console.WriteLine(k);
        }
    }
}
