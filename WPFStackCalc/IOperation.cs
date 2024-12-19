using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    internal interface IOperation
    {
        void Run(Stack<float> stack);
    }
}
