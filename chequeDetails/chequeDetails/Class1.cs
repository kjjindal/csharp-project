using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chequeDetails
{
    public class Class1
    {
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        public static void Main()
        {
            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.IsNumeric("23"));
          
        }

        

        
    }
}
