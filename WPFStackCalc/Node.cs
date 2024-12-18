using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    internal class Node
    {
        public float data;
        public Node? next;

        public Node(float d)
        {
            data = d;
        }
    }
}
