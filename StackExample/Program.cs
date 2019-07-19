using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{

    public interface IStack
    {
        void push(int val);
        int pop();
        int peek();
    }

    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Stack: IStack
    {
        private int[] stack = new int[100];
        private int head = -1;

        public Stack() { }

        public void push(int val)
        {
            head++;
            stack[head] = val;
        }

        public int pop()
        {
            int val = stack[head];
            head--;
            return val;
        }

        public int peek()
        {
            return stack[head];
        }
    }
}
