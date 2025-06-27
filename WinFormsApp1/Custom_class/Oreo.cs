using All_tools_Form_Apps.Pop_up_windows;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace All_tools_Form_Apps.Custom_class
{
    public class Oreo(object right, string middle, object left)
    {
        int ans;
        int number;

        int right_n;
        int left_n;
        Oreo oreo;
        public int compute()
        {
            if (right.Equals(typeof(Oreo)))
            {
            }
            else
            {
                right_n = (int)right;
            }

            if (left.Equals(typeof(Oreo)))
            {

            }
            else
            {
                left_n = (int)left;
            }

            if (left_n != 0 && right_n != 0)
            {
                if (middle == "+")
                {
                    ans = right_n + left_n;
                }
                else if (middle == "-")
                {
                    ans = right_n - left_n;
                }
                else if (middle == "*")
                {
                    ans = right_n * left_n;
                }
                else if (middle == "/")
                {
                    ans = right_n / left_n;
                }
                else
                {
                    new BSOD("*_*", "系統崩潰!\n計算單元時發生錯誤: 運算子不可運算!", "COMPUTING_ERROR");
                }
            }
            return ans;
        }
    }
}
