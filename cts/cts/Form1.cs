using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace cts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        string connetionString;
        SqlConnection cnn;
        public int refrence;

        private void button1_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
           List<string> s = new List <string> (
     filename.Split(new string[] { "\\" }, StringSplitOptions.None));

            filebox.Text = s[s.Count-1];
            int valid;

            if (s[s.Count - 1].IndexOf(".csv")>0)
            {
                valid = 1;
            }
            else
            {
                valid = 0;
            }
           


            using (var reader = new StreamReader($"{filename}"))
            {
                connetionString = @"Data Source=52.187.146.148;Initial Catalog=dbtest;User ID=sa;Password=system123#";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sql = "";

                sql = $"insert into browse_csv (csv_name,csv_valid) values('{s[s.Count - 1]}',{valid}) ";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();


                SqlDataReader datareader;

                sql = "select max(sno) from browse_csv";
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();
                

                while (datareader.Read())
                {
                     refrence = datareader.GetInt32(0);
                }
                datareader.Close();
                command.Dispose();



                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    int n = output.Rows.Add();

                    output.Rows[n].Cells[0].Value = values[0].Split(',')[0];
                    output.Rows[n].Cells[1].Value = values[0].Split(',')[1];
                    output.Rows[n].Cells[2].Value = values[0].Split(',')[2];
                    output.Rows[n].Cells[3].Value = values[0].Split(',')[3];


                    sql = $"insert into csv_details(name,age,drivinglicense,language,csv_no) values('{values[0].Split(',')[0]}',{values[0].Split(',')[1]},{values[0].Split(',')[2]},'{values[0].Split(',')[3]}',{refrence})";
                    command = new SqlCommand(sql, cnn);
                    adapter.InsertCommand = new SqlCommand(sql, cnn);
                    adapter.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                }
                cnn.Close();
                Console.ReadLine();
            }

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void fetchdata_Click(object sender, EventArgs e)
        {

            string filename = filebox.Text;

            using (var reader = new StreamReader($"{filename}"))
            {

                

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    int n = output.Rows.Add();

                    output.Rows[n].Cells[0].Value = values[0].Split(',')[0];
                    output.Rows[n].Cells[1].Value = values[0].Split(',')[1];
                    output.Rows[n].Cells[2].Value = values[0].Split(',')[2];
                    output.Rows[n].Cells[3].Value = values[0].Split(',')[3];

                }
            }

                

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
