using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    internal static class AHelp
    {
        public static int GetPriority(string sign)
        {
            if (Single.TryParse(sign, out var result)) { return -1; }
            switch (sign)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "(":
                    return 0;
                case ")":
                    return 3;
                default:
                    throw new NullPriorityEx();
            }
        }
    }
}
