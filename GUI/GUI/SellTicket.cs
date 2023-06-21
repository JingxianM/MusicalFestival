using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using JXLibrary;
using GMLibrary;


namespace GUI
{
    public partial class SellTicket : Form
    {
        private RFID rfidReader;
        private VisitorController visitors;
        private visitor visitor;
        private visitor v;
        private List<visitor> visitorList;
        int counter;

        public SellTicket()
        {
            InitializeComponent();
            dtp_dob.CustomFormat = "dd - MMM - yyyy";
            visitors = new VisitorController();
            visitorList = new List<visitor>();
        }
        
        private void BnAddMoney_Click(object sender, EventArgs e)
        {
            bool isfind = false;
            foreach (Form fm in Application.OpenForms)
            {
                //判断Form2是否存在，如果在激活并给予焦点
                if (fm.Name == "AddMoney")
                {
                    fm.WindowState = FormWindowState.Maximized;
                    fm.WindowState = FormWindowState.Normal;
                    fm.Activate();
                    return;
                }
            }
            //如果窗口不存在，打开窗口
            if (!isfind) { Form fm = new AddMoney(); fm.Show(); }
        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void BnSellTicket_Click(object sender, EventArgs e)
        {
            lb_message.Items.Clear();
            bool hasBank = false;
            bool hasEmail = false;
            bool hasFname = false;
            bool hasLname = false;
            bool hasDob = false;
            bool hasPwd = false;

            //type value
            string email = tb_email.Text;
            string bank = TBxBankAcc.Text;
            string pwd = tb_pwd.Text;
            string fname = TBxName.Text;
            string lname = TBxSurName.Text;
            DateTime dob = dtp_dob.Value;
            //check null
            if (email != "")
                hasEmail = !hasEmail;
            if (pwd != "")
                hasPwd = !hasPwd;
            if (fname != "")
                hasFname = !hasFname;
            if (lname != "")
                hasLname = !hasLname;
            if (dob != null)
                hasDob = !hasDob;
            if (bank != "")
                hasBank = !hasBank;
            //get days
            int days = clb_date.CheckedItems.Count;
            int day1=0;
            int day2=0;
            int day3=0;
            if (clb_date.SelectedIndex == 0)
            { day1 = 1; }
            else if (clb_date.SelectedIndex == 1)
            { day2 = 1; }
            else
            { day3 = 1; }
            if (hasEmail && hasDob && hasFname && hasBank && hasLname && hasPwd)
            {
                if (visitors.CheckEmailRegistered(tb_email.Text))
                { lb_message.Items.Add("the email is already registered, please enter a new one"); }

                else if (visitors.CheckEmailFormat(tb_email.Text) == false)
                { lb_message.Items.Add("wrong email format"); }

                else if (visitors.CheckAge(dob, DateTime.Now))
                { lb_message.Items.Add("you're too young for the festival"); }
                else
                {
                    btn_sellTicket.Enabled = false;
                    visitors.SighUp(fname, lname, dob, email, pwd, bank, 0, days,day1,day2,day3);
                    lb_message.Items.Add("buy tickets successfully");
                    counter = 5;
                    btn_sellTicket.Text = counter.ToString();
                    timer1.Start();
                }
            }
            else
            {
                lb_message.ForeColor = Color.FromArgb(231, 76, 60);
                lb_message.Text = "PERSONAL INFORMATION INCOMPLETE";
            }

        }

        private void Btn_CheckIn_Click(object sender, EventArgs e)
        {
            visitor v = visitors.GetVisitorByEmail(tb_email.Text);
            if (v != null && v.Rfid != "" && !v.InPark)
            {
                if (visitors.CheckIn(v))
                {
                    showMsg("CHECKED-IN", true);
                }
            }
            else if (v == null)
            {
                showMsg("NO VALID ACCOUNT", false);
            }
            else if (v.Rfid == "")
            {
                showMsg("NO RFID", false);
            }
            else if (v.InPark)
            {
                showMsg("ALREADY CHECKED", false);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            btn_sellTicket.Text = counter.ToString();
            if (counter == 0)
            {
                timer1.Stop();
                btn_sellTicket.Enabled = true;
                //rfidReader.Tag -= new RFIDTagEventHandler(RfidTagScan);
                btn_sellTicket.Text = "successful";
               
            }
        }

        private void showMsg(string msg, bool ok)
        {
            if (ok) { lb_message.ForeColor = Color.FromArgb(22, 160, 133); }

            else
            { lb_message.ForeColor = Color.FromArgb(231, 76, 60); }
            lb_message.Items.Add(msg);
        }

        private void Btn_scan_Click(object sender, EventArgs e)
        {
            btn_scan.Enabled = false;
            try
            {
                rfidReader = new RFID();
                rfidReader.Attach += new AttachEventHandler(RfidDevAtt);
                rfidReader.Detach += new DetachEventHandler(RfidDevDet);
                rfidReader.Tag += new RFIDTagEventHandler(RfidTagScan);
                rfidReader.Open();
            }
            catch (PhidgetException)
            {
                showMsg("ERROR", false);
            }
        }
        private void RfidDevAtt(object sender, AttachEventArgs e)
        {
            showMsg("DEVICE ATTACHED", true);
        }

        private void RfidDevDet(object sender, DetachEventArgs e)
        {
            showMsg("DEVICE DETACHED", false);
        }

        private void RfidTagScan(object sender, RFIDTagEventArgs e)
        {
            string rfid = e.Tag.ToString();
            visitor tempv = visitors.GetAcountByTag(rfid);

            if (tempv == null)
            {
                lb_rfid.Text = rfid;
                btn_bind.Enabled = true;
            }
            else
            {
                showMsg("RFID NOT AVALIABLE", false);
                lb_rfid.Text = "NULL";
                btn_bind.Enabled = false;
            }
            rfidReader.Close();
            btn_scan.Enabled = true;

        }

        private void btn_bind_Click(object sender, EventArgs e)
        {
            string rfid = lb_rfid.Text;
            if (visitors.BindRfidWzOnLineTkt(visitor, rfid, tb_email.Text))
            {
                showMsg("BINDED", true);
                btn_bind.Enabled = false;
            }
            else
            {
                MessageBox.Show("something wrong");
            }
        }

        private void btn_scan_Click_1(object sender, EventArgs e)
        {
            btn_scan.Enabled = false;
            try
            {
                rfidReader = new RFID();
                rfidReader.Attach += new AttachEventHandler(RfidDevAtt);
                rfidReader.Detach += new DetachEventHandler(RfidDevDet);
                rfidReader.Tag += new RFIDTagEventHandler(RfidTagScan);
                rfidReader.Open();
            }
            catch (PhidgetException)
            {
                showMsg("ERROR", false);
            }
        }
    }
}
