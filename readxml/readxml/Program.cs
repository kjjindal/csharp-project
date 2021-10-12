using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Data;
using System.Data.SqlClient;



namespace readxml
{
    class Program
    {
        static void Main(string[] args)
        {
            //  XmlDocument Xdoc = new XmlDocument();
            //  Xdoc.Load("C:\\Users\\kalpit.jindal\\Desktop\\students1.xml");
            //  Xdoc.Save(Console.Out);
            // Console.WriteLine();

            /*
            string location_url = "C:\\Users\\kalpit.jindal\\Desktop\\students1.xml";
            XmlTextReader reader = new XmlTextReader(location_url);
            while (reader.Read())
            {
                Console.WriteLine(reader.Name);

             /*  if (!reader.NodeType.Equals("Whitespace"))
                {
                    Console.WriteLine($"{reader.Value} this is value of ");

                }  */


            // }  

            XmlReader file;
            DataSet ds = new DataSet();

            file = XmlReader.Create("C:\\Users\\kalpit.jindal\\Desktop\\students1.xml", new XmlReaderSettings());
            ds.ReadXml(file);

            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[0]);
                Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[1]);
                Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[2]);
                Console.WriteLine(ds.Tables[0].Rows[i].ItemArray[3]);



            }



            Console.ReadLine();
        }
    }
}
