using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    //Head class
    internal class StackCalcEx : ApplicationException { public StackCalcEx(string message) : base(message) { } }

    //Expression could not be converted
    internal class CantConvertEx : StackCalcEx { public CantConvertEx() : base("Given expression is invalid") { } }
    //Expression is divided by zero
    internal class DividedByZeroEx : StackCalcEx { public DividedByZeroEx() : base("Given expression is divided by zero") { } }
    //Runtime in Operations
    internal class InvalidOperationEx : StackCalcEx { public InvalidOperationEx() : base("Given expression cannot be calculated") { } }
}
