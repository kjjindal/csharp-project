using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Program
    {

        static void greet()
        {
            Console.WriteLine("good afternoon");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("used to print anything in next line");
            //Console.Write("this is used to print anything");
            //Console.WriteLine();
            //int age = 25;
            //Console.WriteLine("age is " + age);
            //int day = 5;
            //float hours = 42.50F;
            //bool flag = true;
            //string name ="kalpit jindal";
            //char section = 'a';

            // if (flag)
            //  {
            // Console.WriteLine("name is " + name + " and his section is " + section);
            // }
            //else
            //{
            //Console.WriteLine("flag is not true");
            // }
            //Console.WriteLine(day);
            //Console.WriteLine(hours);

            // type casting
            // implicit casting
            // char to int to  long to float to double
            // int roll = 28;
            //double rollno = roll;


            //explicit casting
            //int marks = (int) 15.2;
            //Console.WriteLine(marks);


            //take input from user
            // string college = Console.ReadLine();
            //Console.WriteLine("college name is " + college);



            //this is concatenate in c #
            // Console.Write("Enter first number :");
            //string a = Console.ReadLine();
            //Console.Write("Enter second number :");
            //string b = Console.ReadLine();

            //Console.WriteLine("sum of " + a + " and " + b + " is = " + (Convert.ToInt32(a) + Convert.ToInt32(b)));


            //Console.WriteLine(Math.Max(30, 300));
            //Console.WriteLine(Math.Min(30, 300));
            //Console.WriteLine(Math.Sqrt(36));
            //Console.WriteLine(Math.Abs(-36));


            // string name = "my name is kalpit jindal";
            //Console.WriteLine(name.Length);
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name[0]);
            //Console.WriteLine(string.Concat(name, " and this your name ?"));


            //string interpolation 
            // int age = 22;
            //string name = "kalpit";
            //Console.WriteLine($"name is {name} and his age is {age}");
            //Console.WriteLine(name.IndexOf("al"));
            //Console.WriteLine(name.Substring(2, 4));
            //Console.WriteLine(name.Contains("al"));
            //Console.WriteLine(5 % 2);
            //Console.WriteLine(5.0 * 6.3);
            //Console.WriteLine(5 / 2.0);
            //Console.WriteLine(Math.Pow(2, 3));
            //Console.WriteLine(Math.Round(2.3));

            //greet();

            //Class1 obj1 = new Class1();

            //Console.WriteLine(obj1.class_name);
            //Console.WriteLine(obj1.class_roll);


            //array 
            // int[] marks ={19, 20, 21, 22, 23};
            /*
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }  */
            //  string[] friends = new string[3];
            //  friends[0] = "kalpit";
            // friends[1] = "rahul";
            // friends[2] = "ramesh";
            // int i = 0;
            // while (i < friends.length)
            // {
            //    Console.WriteLine(friends[i]);
            //   i++;
            // }

            // string college = "kalpit";
            // string college1 = "kalpit2";

            //  if (college == college1)
            // {
            //    Console.WriteLine("yes equal");
            // }
            // else
            //{
            //  Console.WriteLine("no ");
            //}


            string [,] students = {{"kalpit","28"},{ "naman","41"}, { "rajat","56"}};
            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students);
            }





            














         Console.ReadLine();








        }
    }
}
