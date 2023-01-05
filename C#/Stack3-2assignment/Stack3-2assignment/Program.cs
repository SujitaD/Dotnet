using System;

namespace Stack3_2assignment
{
    class MyStack : ICloneable
    {
        int[]a = new int [5];
        int top = -1;
        int n;

        public MyStack()
        { }

        public MyStack(int n)
        {
            this.n = n;
        }


        public object Clone()
        {
            MyStack m = new MyStack();
            m.n = this.n;
            return m;
        }

        bool IsEmpty()
        {
            return (top < 0);
        }
        
        internal bool Push(int data)
        {
            if(top>=n)
            {
                try
                {
                    throw new Exception("Stack Overflow");
                }
                catch
                {
                    Console.WriteLine("Stack Overflow");
                }
            }
            else
            {
                int val = a[top++];
                return false;
            }
        }
        internal int Pop()
        {
            if(top<0)
            {
                try
                {
                    throw new Exception("Stack Underflow");
                }
                catch
                {
                    Console.WriteLine("Stack Underflow");
                }
            }
            else
            {
                int value = a[top--];
                return value;
            }
            internal void PrintStack()
            {
                if(top<0)
                {
                    Console.WriteLine("Stack Underflow");
                }
                else
                {
                    Console.WriteLine("Values in Stack are:");
                    for(int i=0;i>=0;i--)
                    {
                        Console.WriteLine(a[i]);
                    }
                }

            }
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
