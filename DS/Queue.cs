using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class MyStack
    {
        Queue<int> q1;
        public MyStack()
        {
            q1 = new Queue<int>();
        }
        public void Push(int x)
        {
            q1.Enqueue(x);
            int size = q1.Count;
            while (size > 1)
            {
                q1.Enqueue(q1.Dequeue());
                size--;
            }
        }

        public int Pop()
        {
            return q1.Dequeue();
        }

        public int Top()
        {
            return q1.Peek();
        }

        public bool Empty()
        {
            if (q1.Count == 0) return true;
            else return false;
        }
    }

}
