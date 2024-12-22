using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace WPFStackCalc
{
    internal abstract class OperationFabric
    {
        public abstract IOperation GenerateOperation(string key);

        public IOperation GetOperation(string key)
        {
            return this.GenerateOperation(key);
        }
    }

    internal class Fabric : OperationFabric
    {

        public override IOperation GenerateOperation(string key)
        {
            switch (key)
            {
                case "+":
                    return new Plus();
                case "-":
                    return new Minus();
                case "*":
                    return new Myltiplication();
                case "/":
                    return new Division();
                case "^":
                    return new Sqrt();
                default:
                    throw new CantConvertEx();
            }
        }
    }
}
