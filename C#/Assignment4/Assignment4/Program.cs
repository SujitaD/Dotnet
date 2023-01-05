using System;

namespace Assignment4
{
    class Mystack
    {
        int[] a;
        int n;
        public Mystack(int size)
        {
            a = new int[size];
            n = 0;

        }

        public bool Push(int val)
        {
            if (n < a.Length)
            {
                a[n] = val;
                n++;
                return true;
            }
            else
            {
                throw new Exception("Stack full");
            }
        }

        public int Pop()
        {
            if (n > 0)
            {
                n--;
                return a[n];
            }
            else
            {
                throw new Exception("Stack empty");
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Mystack s = new Mystack(10);
            int num;
            try
            {
                num = s.Pop();
            }
            catch
            {
                Console.WriteLine("Stack empty");
            }
            //Console.WriteLine("exit");
            Console.ReadKey();


        }
    }


}
