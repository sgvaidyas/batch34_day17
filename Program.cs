using System;
using System.Threading;

namespace EXTHREADS
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "mythread";
            Console.WriteLine(t.Name);
        }
    }
}
