using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingConcept
{
    class Program
    {
        static void print()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);

            }
        }
        static void Main(string[] args)
        {
            ThreadStart th = new ThreadStart(ThreadingConcept.Program.print);
            Thread t = new Thread(th);
            t.Start();
            Thread t2 = new Thread(th);
            t2.Start();

            Console.ReadKey();


        }
    }
}
