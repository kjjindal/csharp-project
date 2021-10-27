using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    class Program
    {

        public  void evennumber()
        {
            Console.WriteLine("even number");

        }

        static void Main(string[] args)
        {

            //18-10-2021
            //Console.Write("Enter your name here :");
            //string name=Console.ReadLine();
            //Console.WriteLine(name + " jindal");

            //string interploation
            //Console.WriteLine("hello {0}", name);
            // Console.WriteLine($"your good name is {name}");


            //@ is used to use forward slash as a forward slash not escape slash
            Console.WriteLine(@"C:\Users\kalpit.jindal\Desktop");

            //create different method 
            Program name = new Program();
            name.evennumber();
           




            Console.ReadLine();



        }
    }
}
