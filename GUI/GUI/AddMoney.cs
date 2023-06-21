using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using JXLibrary;

namespace GUI
{
    public partial class AddMoney : Form
    {
        VisitorController visitors;
        public AddMoney()
        {
            InitializeComponent();
            visitors = new VisitorController();
        }
        private void InitializeDisplay()
        {
            listBox1.Items.Clear();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                ArrayList arrlist = new ArrayList();
                foreach (string record in listBox1.Items)
                {
                    string[] recArr = record.Split(' ');
                    arrlist.Add(recArr);
                }
                if (visitors.TopUpAll(arrlist))
                {
                    //pb_Sign.Image = il_Sign.Images[1];
                    listBox1.Items.Clear();
                    listBox1.Items.Add("TOP-UP SUCCEEDED !");
                    btnconfirm.Enabled = false;
                }
            }
        }

        private void btnloadfile_Click(object sender, EventArgs e)
        {
            InitializeDisplay();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    fs = new FileStream(this.openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    string line1 = sr.ReadLine(); // orgnaziatior iban
                    line1 = line1.Replace(" ", "");
                    if (line1 == "NL91ABNA0417164300")
                    {
                        btnconfirm.Enabled = true;
                        sr.ReadLine(); // start time
                        sr.ReadLine(); // end time
                        sr.ReadLine(); // nr of transfer
                        string s = sr.ReadLine();
                        while (s != null)
                        {
                            listBox1.Items.Add(s);
                            s = sr.ReadLine();
                        }
                    }
                }
                catch (IOException) { MessageBox.Show("something wrong about file"); }
                finally
                {
                    if (sr != null) sr.Close();
                    if (fs != null) fs.Close();
                }
            }
        }
    }
}
