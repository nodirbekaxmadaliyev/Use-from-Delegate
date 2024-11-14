using System;

namespace Delegate
{
    internal class Program
    {
        public delegate void math(int a, int b);
        public void sum(int a, int b)
        {
            Console.WriteLine( a + b);
        }
        public void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            Program ob = new Program();
            math Dsum = new math(ob.sum);
            Dsum += ob.sub;
            Dsum(25, 15);
            Dsum.Invoke(25, 35);
        }

    }
}
