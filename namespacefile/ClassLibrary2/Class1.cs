using System;


namespace ClassLibrary2
{
    public class Check
    {
        string _fname;
        string _lname;
        public void customer(string fname, string lname)
        {
            this._fname = fname;
            this._lname = lname;

        }
        public void printname()
        {
            Console.WriteLine($"My name is {this._fname} {this._lname}");

        }

        public static void main(string[] args)
        {
            Check c1 = new Check();
            c1.customer("kalpit", "jindal");
            c1.printname();
        }

    }

}
