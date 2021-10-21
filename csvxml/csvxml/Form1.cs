using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Xml;
using System.Configuration;




namespace csvxml
{
    public partial class Form1 : Form
    {

        public string GetConfigurationValue()
        {
            string connectionString;
            var ip_address = ConfigurationManager.AppSettings["ipAddress"];
            var database = ConfigurationManager.AppSettings["database"];

            var user_id = ConfigurationManager.AppSettings["userId"];
            var password = ConfigurationManager.AppSettings["password"];

            connectionString = $@"Data Source={ip_address};Initial Catalog={database};User ID={user_id};Password={password}";

            return connectionString;

        }




        public void insert_rows_in_file_details(object name,object age,object drivinglicence,object language,int refrence)
        {

            try
            {
                string connectionString = GetConfigurationValue();
                string sql = "";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command;
                cnn.Open();


                sql = $"insert_row_file_details {name},{age},{drivinglicence},{language},{refrence}";
                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();

            }
            catch
            {
                MessageBox.Show("insert file doesn't match required file ", "File data error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
             

            }

        }

        public void insert_rows_in_file_browse(string filename)
        {
            try
            {

                string connectionString = GetConfigurationValue();
                string sql = "";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command;
                cnn.Open();

                sql = $"insert_row_file_browse '{filename}',1";

                command = new SqlCommand(sql, cnn);
                adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();

                cnn.Close();

            }
            catch
            {
                MessageBox.Show("file should be not contain special character ", "File name error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        

        }

        public int find_final_row()

        {
            int refrence = 0;

            try
            {

                string connectionString = GetConfigurationValue();
                string sql = "";
                SqlConnection cnn = new SqlConnection(connectionString);
                SqlCommand command;
                SqlDataReader datareader;
                cnn.Open();

                sql = "last_sno_file_browse";
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();
                while (datareader.Read())
                {
                    refrence = datareader.GetInt32(0);
                }
                datareader.Close();
                command.Dispose();

            }
            catch
            {
                MessageBox.Show("some thing is wrong please try again", "Last entry error",
  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return refrence;



        }




        public Form1()
        {
            InitializeComponent();
        }

        public void xmlread(string filename,List <string> s)
        {
            int refrence = 0;
            insert_rows_in_file_browse(s[s.Count - 1]);
            refrence = find_final_row();
            XmlReader file;
            DataSet ds = new DataSet();
            file = XmlReader.Create($"{filename}", new XmlReaderSettings());
            ds.ReadXml(file);
            int count=0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                //to set datagrid view data 
                int n = dataGridView1.Rows.Add();
                try
                {
                    dataGridView1.Rows[n].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0];
                    dataGridView1.Rows[n].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[2];
                    dataGridView1.Rows[n].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[3];
                    dataGridView1.Rows[n].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[1];
                    insert_rows_in_file_details(ds.Tables[0].Rows[i].ItemArray[0], ds.Tables[0].Rows[i].ItemArray[2], ds.Tables[0].Rows[i].ItemArray[3], ds.Tables[0].Rows[i].ItemArray[1], refrence);
                    count += 1;
                }
                catch
                {
                    MessageBox.Show("Xml File doesn't match official Format", "File format is wrong",
 MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                finally
                {
                    numericUpDown3.Value = count;
                }



            }






        }

        public void csvread(string filename, List<string> s)
        {
            int refrence;
            int count = 0;
           

            using (var reader = new StreamReader($"{filename}"))
            {

                insert_rows_in_file_browse(s[s.Count - 1]);
                refrence = find_final_row();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    int n =dataGridView1.Rows.Add();

                    try
                    {
                        
                        dataGridView1.Rows[n].Cells[0].Value = !int.TryParse(values[0].Split(',')[0], out int num1) ? values[0].Split(',')[0] : null; ;
                        dataGridView1.Rows[n].Cells[1].Value =int.Parse(values[0].Split(',')[1]);
                        dataGridView1.Rows[n].Cells[2].Value = values[0].Split(',')[2];
                        dataGridView1.Rows[n].Cells[3].Value = !int.TryParse(values[0].Split(',')[3],out int num2)? values[0].Split(',')[3]:null;
                        insert_rows_in_file_details(values[0].Split(',')[0], values[0].Split(',')[1], values[0].Split(',')[2], values[0].Split(',')[3], refrence);
                        count += 1;
                    }
                    catch
                    {
                        MessageBox.Show("CSV File doesn't match official Format", "File format is wrong",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;


                    }
                    finally
                    {
                        numericUpDown3.Value = count;
                    }
                   


                    
                }







            }





            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                string filename = openFileDialog1.FileName;
                List<string> s = new List<string>(filename.Split(new string[] { "\\" }, StringSplitOptions.None));
                textBox1.Text = s[s.Count - 1];


                if (s[s.Count - 1].Contains(".csv"))
                {
                    csvread(filename, s);


                }
                else if (s[s.Count - 1].Contains(".xml"))
                {
                    xmlread(filename, s);


                }
                else
                {
                    MessageBox.Show("File type should be .csv or .xml only ", "File type error",
       MessageBoxButtons.OK, MessageBoxIcon.Error);


                }


            }
            else
            {
                MessageBox.Show("Please select .csv or .Xml file ", "Select file error",
    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

           
            
          





        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            int xmlsno = (int)numericUpDown1.Value;
            string connectionString = GetConfigurationValue();
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            string sql = "";
            SqlCommand command;
            SqlDataReader datareader;
            int count = 0;

            try
            {
                sql = $"file_no_file_details {xmlsno}";
                command = new SqlCommand(sql, cnn);
                datareader = command.ExecuteReader();
              


                if (datareader.HasRows)
                {
                    while (datareader.Read())
                    {
                        count += 1;
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = datareader.GetValue(0);
                        dataGridView2.Rows[n].Cells[1].Value = datareader.GetInt32(1);
                        dataGridView2.Rows[n].Cells[2].Value = datareader.GetValue(2);
                        dataGridView2.Rows[n].Cells[3].Value = datareader.GetValue(3);

                    }
                    datareader.Close();
                    command.Dispose();
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("doesn't match with record", "Select file error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch
            {

                MessageBox.Show("something is wrong please try again", "Select file error",
  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                    numericUpDown2.Value = count;

            }



        }
    }
}
