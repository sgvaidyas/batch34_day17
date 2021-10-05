using System;
using System.Threading;
using System.Threading.Tasks;

namespace EXTHREADS
{
    class Mythread
    {
        public void myfun1()
        {
            Thread t = Thread.CurrentThread;
            for (int x = 22; x <= 30; x++)
            {
                Console.WriteLine(t.Name + "   hiiiiii");
                Thread.Sleep(400);

            }
        }
        public void myfun2()
        {
            Thread t = Thread.CurrentThread;
            for (int x = 22; x <= 30; x++)
            {
                Console.WriteLine(t.Name + "   hello");
                Thread.Sleep(50);
            }
        }
    }
    class Thread3
    {
        static void Main(string[] args)
        {
            Mythread ob = new Mythread();
            Thread t1 = new Thread(new ThreadStart(ob.myfun1));
            Thread t2 = new Thread(new ThreadStart(ob.myfun1));
            Thread t3 = new Thread(new ThreadStart(ob.myfun2));

            t1.Name = "one";
            t2.Name = "two";
            t3.Name = "three";
            t3.Start();
            t1.Start();
            t2.Start();
        }
    }
}
