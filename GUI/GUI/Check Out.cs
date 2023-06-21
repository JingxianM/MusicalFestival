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
using System.IO;
using MySql.Data.MySqlClient;
using GMLibrary;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Controls;
using AForge.Imaging;
using ZXing.QrCode;
using ZXing.Common;
using ZXing;
using ZXing.Rendering;
using JXLibrary;

namespace GUI
{
    public partial class Check_Out : Form
    {
        private RFID rfidReaderV;
        private VisitorController visitors;
        private visitor v;
        private LoaningController loans;
        private SaleController sales;
        public Check_Out()
        {

            InitializeComponent();
            visitors = new VisitorController();
            loans = new LoaningController();
            sales = new SaleController();
        }
        private void InitializeDisplay()
        {
            lb_fname.Text = "";
            lb_lname.Text = "";
            lb_ticketId.Text = "";
            lb_Rfid.Text = "";
            lb_balance.Text = "";
            lb_status.Text = "";
            lb_spot.Text = "";
            l_email.Text = "";
            v = null;
        }

        private void RfidTagScanV(object sender, RFIDTagEventArgs e)
        {
            InitializeDisplay();
            string rfid = e.Tag.ToString();
            v = visitors.GetAccountByTagCheckOut(rfid);
            if (v is null)
            {
                showMsg("no such an account", false);
            }
            else
            {
                showMsg("Tag In Use", false);
                lb_Rfid.Text = rfid;
                lb_fname.Text = v.Fname;
                lb_lname.Text = v.Lname;
                lb_status.Text = v.InPark ? "In park" : "Not in park";
                lb_spot.Text = v.CampNr == 0 ? "No camping" : "#" + v.CampNr;
                lb_ticketId.Text = v.TicketNr.ToString();
                lb_balance.Text = v.Balance.ToString();
                if (v.InPark)
                {
                    if (loans.GetRentList(rfid).Count == 0)
                    {
                        BnCheckOut.Enabled = true;
                        lb_borrowed_items.Items.Add("CLEAR !!!");
                    }
                    else
                    {
                        foreach (var item in loans.GetRentList(rfid))
                        {
                            lb_borrowed_items.Items.Add(item);
                        }
                    }
                }
                else
                {
                    showMsg("You haven't checked in", false);
                }
            }
        }
        private void BnScanRFID_Click(object sender, EventArgs e)
        {
            BnScanRFID.Enabled = false;
            try
            {
                rfidReaderV = new RFID();
                rfidReaderV.Attach += new AttachEventHandler(RfidDevAtt);
                rfidReaderV.Detach += new DetachEventHandler(RfidDevDet);
                rfidReaderV.Tag += new RFIDTagEventHandler(RfidTagScanV);
                rfidReaderV.Open();
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

        private void showMsg(string msg, bool ok)
        {
            if (ok)
            {
                lb_message.ForeColor = Color.FromArgb(22, 160, 133);
            }
            else
            {
                lb_message.ForeColor = Color.FromArgb(231, 76, 60);
            }
            lb_message.Items.Add(msg);
        }
        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void BnCheckOut_Click(object sender, EventArgs e)
        {
            v = visitors.GetAccountByTagCheckOut(lb_Rfid.Text);
            if (v.InPark == false)
            {
                showMsg("already checked out", false);
            }
            else if (loans.GetRentList(lb_Rfid.Text).Count != 0)
            {
                BnCheckOut.Enabled = false;
                showMsg("Please return the item you borrowed", false);
            }
            else if (visitors.GateCheckOut(v))
            {
                showMsg("CHECKED-OUT", true);
                MessageBox.Show("BALANCE REFUNDED");
                lb_balance.Text = "0";
            }
            InitializeDisplay();
        }

    
    }
}
