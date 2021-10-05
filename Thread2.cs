using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXTHREADS
{
    class Countme
    {
        public static void count()
        {
            Thread t = Thread.CurrentThread;
            for (int x = 22; x <= 30; x++)
            {
                Console.WriteLine(t.Name + "   " +x);
            }
        }
    }
    class Thread2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Countme.count));
            Thread t2 = new Thread(new ThreadStart(Countme.count));
            Thread t3 = new Thread(new ThreadStart(Countme.count));

            t1.Name = "one";
            t2.Name = "two";
            t3.Name = "three";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
