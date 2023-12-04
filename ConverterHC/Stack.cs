using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterHC
{
    internal class Stack
    {
        class Node
        {
            public int Data;
            public Node Next;
        }
        Node Top;
        public bool IsEmpty()
        {
            if (Top == null) return true;
            else return false;
        }
        public void Push(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            if (IsEmpty())
            {
                Top = temp;
                return;
            }
            temp.Next = Top;
            Top = temp;
        }
        public int pop()
        {
            if (IsEmpty()) return int.MinValue;
            else
            {
                int x;
                x = Top.Data;
                Top = Top.Next;
                return x;
            }
        }
        public int Size()
        {
            int Counter = 0;
            if (IsEmpty()) return 0;
            Node p = Top;
            while (p != null)
            {
                Counter++;
                p = p.Next;
            }
            return Counter;
        }

    }
}
