using System;


namespace staticconcept
{

    class Compnay
    {

        public string name;
        public int salary;
        public string ceo;
        public void print()
        {
            Console.WriteLine($"name is {name} and his salary is {salary} and his ceo name is {ceo}");

        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Compnay kalpit = new Compnay();
            Compnay Mohit = new Compnay();

            kalpit.name = "kalpit";
            kalpit.salary = 360000;
            kalpit.ceo = "Nigam";


            Mohit.name = "Mohit";
            Mohit.salary = 450000;
            Mohit.ceo = "Cognizant";
            kalpit.print();

            Mohit.print();


            Console.ReadLine();



        }




    }





}


//using System;


//namespace staticconcept
//{

//    class Compnay
//    {

//        public string name;
//        public int salary;
//        public static string ceo;
//        public void print()
//        {
//            Console.WriteLine($"name is {name} and his salary is {salary} and his ceo name is {ceo}");

//        }

//    }
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Compnay kalpit = new Compnay();
//            Compnay Mohit = new Compnay();

//            kalpit.name = "kalpit";
//            kalpit.salary = 360000;
//            //if variable is static means it's value  same for all object
//            //so in this case we can assign class object value using class

//            Compnay.ceo = "Nigam";


//            Mohit.name = "Mohit";
//            Mohit.salary = 450000;
//            Compnay.ceo = "Cognizant";
//            kalpit.print();

//            Mohit.print();


//            Console.ReadLine();



//        }




//    }





//}




