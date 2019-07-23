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
            var stack = new Stack();
            //Console.WriteLine("Please enter a number to add to the stack, pop to remove a #, or peek to see the last #: ");
            //var response = Console.ReadLine();
            var loop = true;

            while (loop == true)
            {
                Console.WriteLine("Please enter a number to add to the stack, pop to remove a #, or peek to see the last #: ");
                var response = Console.ReadLine();

                if(response.ToLower() == "q")
                {
                    loop = false;
                }
                else if (response.ToLower() == "peek")
                {
                    var peekaboo = stack.peek();
                    
                    if(peekaboo < 0)
                    {
                        Console.WriteLine("Gotta add something first dumbass");
                    }
                    else
                        Console.WriteLine(peekaboo);
                }
                else if (response.ToLower() == "pop")
                {
                    var number = stack.pop();

                    if (number < 0)
                    {
                        Console.WriteLine("You can't pop a number that ain't there boyo");
                    }
                    else
                        Console.WriteLine("Pop goes the weasel" +  " " + number);
                }
                else
                {
                    stack.push(Convert.ToInt32(response));
                }
            }
            
        }
    }

    public class Stack: IStack
    {
        private int[] stack = new int[] { };

        public Stack()
        {
            
        }

        public void push(int val)
        {
            var list = stack.ToList<int>();
            list.Add(val);
            stack = list.ToArray<int>();
        }

        public int pop()
        {
            //var last = stack[stack.Length - 1];

            var list = stack.ToList<int>();

            if (stack.Length == 0)
            {
                return -1;
            }
            var last = list.ElementAt(list.Count - 1);
            list.RemoveAt(list.Count - 1);
            stack = list.ToArray<int>();
            
            return last;
        }

        public int peek()
        {
            if(stack.Length == 0)
            {
                return -1;
            }
            int last = stack[stack.Length - 1];
            return last;
        }
    }
}
