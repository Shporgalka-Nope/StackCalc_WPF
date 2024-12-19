using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WPFStackCalc
{
    internal class Calc
    {
        private Stack<float> nums = new Stack<float>();
        private Stack<string> oper = new Stack<string>();
        private Fabric fabric = new Fabric();

        public string AUTOIdentify(string expression)
        {
            Identify(expression + " ");
            return ReturnResult();
        }

        private void Identify(string expression)
        {
            string fullSign = "";
            for(int i = 0; i < expression.Length; i++)
            {
                if (expression[i] != ' ') 
                { 
                    fullSign += expression[i];
                    continue;
                }
                else
                {
                    if (AHelp.GetPriority(fullSign) == -1) 
                    {
                        nums.Push(Single.Parse(fullSign)); 
                        fullSign = "";
                    }
                    else
                    {
                        if (fullSign == "(")
                        {
                            oper.Push(fullSign);
                            fullSign = "";
                            continue;
                        }
                        if (fullSign == ")")
                        {
                            while(oper.Peek() != "(") { CalculateOnce(); }
                            oper.Pop(); //Dropping (
                            fullSign = "";
                            continue;
                        }
                        if (oper.Count == 0) 
                        { 
                            oper.Push(fullSign);
                            fullSign = "";
                        }
                        else
                        {
                            while(oper.Count > 0 && AHelp.GetPriority(fullSign) < AHelp.GetPriority(oper.Peek())) 
                            { 
                                CalculateOnce();
                            }
                            oper.Push(fullSign);
                            fullSign = "";
                        }
                    }
                }
            }

        }
        private void CalculateOnce()
        {
            IOperation op = fabric.GetOperation(oper.Pop());
            op.Run(nums);
        }
        private string ReturnResult()
        {
            while(oper.Count > 0)
            {
                CalculateOnce();
            }
            string result = nums.Pop().ToString();
            return result;
        }
    }
}
