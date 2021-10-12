
namespace ctsxml
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.xmltext = new System.Windows.Forms.TextBox();
            this.xmlbutton = new System.Windows.Forms.Button();
            this.xmldata = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drivinglicence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xmlid = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.showxmldata = new System.Windows.Forms.DataGridView();
            this.xml_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml_dl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml_language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xmldata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showxmldata)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // xmltext
            // 
            this.xmltext.Location = new System.Drawing.Point(215, 42);
            this.xmltext.Name = "xmltext";
            this.xmltext.Size = new System.Drawing.Size(234, 20);
            this.xmltext.TabIndex = 0;
            // 
            // xmlbutton
            // 
            this.xmlbutton.BackColor = System.Drawing.Color.Gold;
            this.xmlbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xmlbutton.FlatAppearance.BorderSize = 0;
            this.xmlbutton.Location = new System.Drawing.Point(455, 40);
            this.xmlbutton.Name = "xmlbutton";
            this.xmlbutton.Size = new System.Drawing.Size(75, 23);
            this.xmlbutton.TabIndex = 1;
            this.xmlbutton.Text = "browse";
            this.xmlbutton.UseVisualStyleBackColor = false;
            this.xmlbutton.Click += new System.EventHandler(this.xmlbutton_Click);
            // 
            // xmldata
            // 
            this.xmldata.BackgroundColor = System.Drawing.Color.Silver;
            this.xmldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xmldata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.age,
            this.drivinglicence,
            this.language});
            this.xmldata.Location = new System.Drawing.Point(12, 103);
            this.xmldata.Name = "xmldata";
            this.xmldata.Size = new System.Drawing.Size(776, 162);
            this.xmldata.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // drivinglicence
            // 
            this.drivinglicence.HeaderText = "drivinglicence";
            this.drivinglicence.Name = "drivinglicence";
            this.drivinglicence.ReadOnly = true;
            // 
            // language
            // 
            this.language.HeaderText = "language";
            this.language.Name = "language";
            this.language.ReadOnly = true;
            // 
            // xmlid
            // 
            this.xmlid.Location = new System.Drawing.Point(12, 271);
            this.xmlid.Name = "xmlid";
            this.xmlid.Size = new System.Drawing.Size(120, 20);
            this.xmlid.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "search\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showxmldata
            // 
            this.showxmldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showxmldata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xml_name,
            this.xml_age,
            this.xml_dl,
            this.xml_language});
            this.showxmldata.Location = new System.Drawing.Point(13, 298);
            this.showxmldata.Name = "showxmldata";
            this.showxmldata.Size = new System.Drawing.Size(775, 126);
            this.showxmldata.TabIndex = 5;
            this.showxmldata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // xml_name
            // 
            this.xml_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.xml_name.HeaderText = "xml_name";
            this.xml_name.Name = "xml_name";
            this.xml_name.ReadOnly = true;
            // 
            // xml_age
            // 
            this.xml_age.HeaderText = "xml_age";
            this.xml_age.Name = "xml_age";
            this.xml_age.ReadOnly = true;
            // 
            // xml_dl
            // 
            this.xml_dl.HeaderText = "xml_dl";
            this.xml_dl.Name = "xml_dl";
            this.xml_dl.ReadOnly = true;
            // 
            // xml_language
            // 
            this.xml_language.HeaderText = "xml_language";
            this.xml_language.Name = "xml_language";
            this.xml_language.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showxmldata);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xmlid);
            this.Controls.Add(this.xmldata);
            this.Controls.Add(this.xmlbutton);
            this.Controls.Add(this.xmltext);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.xmldata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xmlid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showxmldata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox xmltext;
        private System.Windows.Forms.Button xmlbutton;
        private System.Windows.Forms.DataGridView xmldata;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn drivinglicence;
        private System.Windows.Forms.DataGridViewTextBoxColumn language;
        private System.Windows.Forms.NumericUpDown xmlid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView showxmldata;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_dl;
        private System.Windows.Forms.DataGridViewTextBoxColumn xml_language;
    }
}

