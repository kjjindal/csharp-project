using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;

namespace ctsxml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        int refrence;




        private void xmlbutton_Click(object sender, EventArgs e)
        {

            //open dialog part and filename split part  ans set file name on textbox
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            List<string> s = new List<string>(filename.Split(new string[] { "\\" }, StringSplitOptions.None));
            xmltext.Text = s[s.Count - 1];
           
            


            //check insert file is xml file or not 
            int valid;
            if (s[s.Count - 1].IndexOf(".xml") > 0)
            {
                valid = 1;
            }
            else
            {
                valid = 0;
            }


            //here sql connection start 
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=52.187.146.148;Initial Catalog=dbtest;User ID=sa;Password=system123#";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();


            //here file name and valid part sql query
            string sql = "";
            sql = $"insert into browse_xml (xml_name,xml_valid) values('{s[s.Count - 1]}',{valid}) ";
            SqlCommand command;
            command = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();


            // used to get last file sno
            SqlDataReader datareader;
            sql = "select max(sno) from browse_xml";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
                refrence = datareader.GetInt32(0);
            }
            datareader.Close();
            command.Dispose();


            
            //read xml file with the help of filename 
            XmlReader file;
            DataSet ds = new DataSet();
            file = XmlReader.Create($"{filename}", new XmlReaderSettings());
            ds.ReadXml(file);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                //to set datagrid view data 
                int n = xmldata.Rows.Add();
                xmldata.Rows[n].Cells[0].Value = ds.Tables[0].Rows[i].ItemArray[0];
                xmldata.Rows[n].Cells[1].Value = ds.Tables[0].Rows[i].ItemArray[2];
                xmldata.Rows[n].Cells[2].Value = ds.Tables[0].Rows[i].ItemArray[3];
                xmldata.Rows[n].Cells[3].Value = ds.Tables[0].Rows[i].ItemArray[1];

               
                //sql query for data insert in xml_details
       sql = $"insert into xml_details(name,age,drivinglicense,language,xml_no) values('{ds.Tables[0].Rows[i].ItemArray[0]}',{ds.Tables[0].Rows[i].ItemArray[2]},{ds.Tables[0].Rows[i].ItemArray[3]},'{ds.Tables[0].Rows[i].ItemArray[1]}',{refrence})";
             command = new SqlCommand(sql, cnn);
               adapter.InsertCommand = new SqlCommand(sql, cnn);
                adapter.InsertCommand.ExecuteNonQuery();
               command.Dispose();
            }
            cnn.Close();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            int xmlsno =(int) xmlid.Value;
            SqlDataReader datareader;
            string sql;
            string connetionString;
            SqlConnection cnn;

            connetionString = @"Data Source=52.187.146.148;Initial Catalog=dbtest;User ID=sa;Password=system123#";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand command;
            sql = $"select *  from xml_details where xml_no={xmlsno}";
            command = new SqlCommand(sql, cnn);
            datareader = command.ExecuteReader();
            while (datareader.Read())
            {
             int n = showxmldata.Rows.Add();
                showxmldata.Rows[n].Cells[0].Value =datareader.GetValue(0);
                showxmldata.Rows[n].Cells[1].Value = datareader.GetInt32(1);
                showxmldata.Rows[n].Cells[2].Value = datareader.GetValue(2);
                showxmldata.Rows[n].Cells[3].Value = datareader.GetValue(3);

            }
            datareader.Close();
            command.Dispose();






        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
