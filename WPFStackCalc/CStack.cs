using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    internal class CStack
    {
        public Node? head;

        public void Push(string data)
        {
            if (!Single.TryParse(data, out float result))
            {
                Fabric fabric = new Fabric(data);
                IOperation operation = fabric.GetOperation();
                operation.Run(this);
                return;
            }
            if (head == null)
            {
                head = new Node(result);
                return;
            }

            Node newNode = new Node(result);
            newNode.next = head;
            head = newNode;
        }
        public Node Pop()
        {
            if (head == null) { return null; }
            Node current = head;
            head = head.next;
            current.next = null;
            return current;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }
    }
}
