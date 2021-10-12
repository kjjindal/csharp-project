using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace readcsv
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var reader = new StreamReader(@"C:\students1.csv"))
            {
                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=52.187.146.148;Initial Catalog=dbtest;User ID=sa;Password=system123#";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "";

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                   

                    sql = $"insert into csventry values('{values[0].Split(',')[0]}','{values[0].Split(',')[1]}','{values[0].Split(',')[2]}','{values[0].Split(',')[3]}')";
                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                
                cnn.Close();
                Console.ReadLine();
            }

        }
    }
}
