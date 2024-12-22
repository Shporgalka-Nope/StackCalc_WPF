using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    
    internal class Plus : IOperation
    {
        public void Run(Stack<float> stack)
        {
            float elementTwo = stack.Pop();
            float elementOne = stack.Pop();
            float result = elementOne + elementTwo;
            stack.Push(result);
        }
    }

    internal class Minus : IOperation
    {
        public void Run(Stack<float> stack)
        {
            float elementTwo = stack.Pop();
            float elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne - elementTwo;
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result);
        }
    }

    internal class Myltiplication : IOperation
    {
        public void Run(Stack<float> stack)
        {
            float elementTwo = stack.Pop();
            float elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne * elementTwo;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result);
        }
    }

    internal class Division : IOperation
    {
        public void Run(Stack<float> stack)
        {
            float elementTwo = stack.Pop();
            float elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne / elementTwo;
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result);
        }
    }

    internal class Sqrt : IOperation
    {
        public void Run(Stack<float> stack)
        {
            float elementOne = stack.Pop();
            double dbl = elementOne;
            float result;
            try
            {
                result = (float)Math.Sqrt(dbl);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result);
        }
    }
}
