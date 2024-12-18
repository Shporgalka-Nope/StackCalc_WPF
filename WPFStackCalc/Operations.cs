using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    
    internal class Plus : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result = elementOne.data + elementTwo.data;
            stack.Push(result.ToString());
        }
    }

    internal class Minus : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne.data - elementTwo.data;
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result.ToString());
        }
    }

    internal class Myltiplication : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne.data * elementTwo.data;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result.ToString());
        }
    }

    internal class Division : IOperation
    {
        public void Run(CStack stack)
        {
            Node elementTwo = stack.Pop();
            Node elementOne = stack.Pop();
            float result;
            try
            {
                result = elementOne.data / elementTwo.data;
            }
            catch (Exception ex) 
            {
                throw new InvalidOperationEx();
            }
            stack.Push(result.ToString());
        }
    }
}
