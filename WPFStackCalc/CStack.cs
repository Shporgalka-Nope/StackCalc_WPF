using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace WPFStackCalc
{
    internal class CStack
    {
        public Node? head;

        public void Push(string data)
        {
            float result = Single.Parse(data);
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
        public Node Peek()
        {
            if (head == null) { return null; }
            return head;
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
