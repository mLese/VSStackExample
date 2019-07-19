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
        public Stack() { }

        public void push(int val)
        {

        }

        public int pop()
        {
            return 0;
        }

        public int peek()
        {
            return 0;
        }
    }
}
