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

namespace GUI
{
    public partial class CheckIn : Form
    {
        private RFID rfidReader;
        private Connection conn;
        private Account acc;
        //private FilterInfoCollection videoDevices;
        //private VideoCaptureDevice videoSource;
        //Bitmap bmp = null;
        public CheckIn()
        {

            InitializeComponent();
            InitializeDisplay();
            conn = new Connection();
        }
        private void InitializeDisplay()
        {
            lbname.Text = "";
            lbsurname.Text = "";
            lbtnr2.Text = "";
            lbrfid2.Text = "";
            lbbalance.Text = "";
            lbstatus.Text = "";
            lbspot.Text = "";
            acc = null;
        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void BnScanRFID_Click(object sender, EventArgs e)
        {
            BnScanRFID.Enabled = false;
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
            Account tempAcc = conn.GetAcountByTag(rfid);

            if (tempAcc == null)
            {
                lbrfid2.Text = rfid;
                btnbind.Enabled = true;
            }
            else
            {
                showMsg("RFID NOT AVALIABLE", false);
                lbrfid2.Text = "NULL";
                btnbind.Enabled = false;
            }
            rfidReader.Close();
            BnScanRFID.Enabled = true;
        }



        private void BnCheckIn_Click(object sender, EventArgs e)
        {
            if (acc != null && acc.rfid != "" && !acc.inpark)
            {
                if (conn.GateCheckIn(acc))
                {
                    showMsg("CHECKED-IN", true);
                    InitializeDisplay();
                }
            }
            else if (acc == null)
            {
                showMsg("NO VALID ACCOUNT", false);
            }
            else if (acc.rfid == "")
            {
                showMsg("NO RFID", false);
            }
            else if (acc.inpark)
            {
                showMsg("ALREADY CHECKED", false);
            }
        }

        private void btnbind_Click(object sender, EventArgs e)
        {
            string rfid = lbrfid2.Text;
            if (conn.BindRfidWzOnLineTkt(acc, rfid))
            {
                showMsg("BINDED", true);
                btnbind.Enabled = false;
                BnScanRFID.Enabled = false;
                acc = conn.GetAcountByTag(rfid);
            }

        }

        private void showMsg(string msg, bool ok)
        {
            if (ok)
            {
                lblMsg.ForeColor = Color.FromArgb(22, 160, 133);
            }
            else
            {
                lblMsg.ForeColor = Color.FromArgb(231, 76, 60);
            }
            lblMsg.Text = msg;
        }

        private void BtnVerifyTkt_Click(object sender, EventArgs e)
        {

            InitializeDisplay();
            try
            {
                int tktnr = int.Parse(tbxTktnr.Text);
                acc = conn.GetAcountByTkt(tktnr);
                if (acc == null)
                {
                    showMsg("TICKET NOT EXIST", false);
                }
                else
                {
                    lblMsg.Text = "";
                    lbname.Text = acc.fname;
                    lbsurname.Text = acc.lname;
                    lbtnr2.Text = acc.tktnr.ToString();
                    lbbalance.Text = acc.balance.ToString();
                    lbstatus.Text = acc.inpark ? "In park" : "Not in park";
                    lbspot.Text = acc.campnr == 0 ? "No camping" : "#" + acc.campnr;
                    if (acc.rfid == "")
                    {
                        BnScanRFID.Enabled = true;
                        lbrfid2.Text = "NULL";
                    }
                    else
                    {
                        BnScanRFID.Enabled = false;
                        lbrfid2.Text = acc.rfid;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}