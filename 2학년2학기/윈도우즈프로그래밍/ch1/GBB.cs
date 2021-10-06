using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
class GBB{
    public static string result(int fix_su)
    {
        string input;
        int input_su = 0;
        Console.WriteLine("1-100 중에 상대가 생각하고 있는 수를 입력하세요 : ");
        input = Console.ReadLine();
        input_su = Convert.ToInt32(input);
        if (fix_su < input_su)
        {
            return "너무 커";
        }
        else if (fix_su > input_su)
        {
            return "너무 작어";
        }
        else if (fix_su == input_su)
        {
            return "정답";
        }
        else
        {
            return "엥";
        }
    }

}