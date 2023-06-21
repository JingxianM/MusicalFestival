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
using GMLibrary;

namespace GUI
{
    public partial class Form2 : Form
    {
        private RFID rfidReader;
        private RFID rfidReaderV;
        private Connection conn;
        private Account acc;
        private Account accV;
        private List<Account> accList;
        public Form2()
        {

            InitializeComponent();
            conn = new Connection();
        }

        private void InitialzeDisplay()
        {
            btnCheckIn.Enabled = false;
            btnCheckOut.Enabled = false;
            btnScanV.Enabled = false;
            BtnAddV.Enabled = false;
            acc = null;
            lbtnr.Text = "*****";
            lbstatus.Text = "*****";
            lbspot.Text = "*****";
            lbtnrV.Text = "*****";
            lbxAccLst.Items.Clear();
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
            acc = conn.GetAcountByTag(rfid);
            if (acc != null)
            {
                if (acc.campnr == 0)
                {
                    showMsg("NO RESERVATION FOR CAMP SPORT", false);
                }
                else
                {
                    accList = conn.GetListIfOwner(acc);
                    showCamper(acc);
                    showAccList();
                }
                rfidReader.Close();               
            }
            else
            {
                showMsg("RFID not valid", false);
            }
            BtnScanRFID.Enabled = true;

        }


        private void RfidTagScanV(object sender, RFIDTagEventArgs e)
        {
            string rfid = e.Tag.ToString();
            accV = conn.GetAcountByTag(rfid);
            if (accV != null)
            {
                if (accV.campnr != 0)
                {
                    showMsg("ALREADY HAS CAMP SPORT", false);
                    BtnAddV.Enabled = false;
                }
                else
                {
                    showVisitor(accV);
                    BtnAddV.Enabled = true;
                }
                rfidReaderV.Close();
            }
            else
            {
                showMsg("RFID not valid", false);
                
            }
            btnScanV.Enabled = true;
        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
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

       

        private void showCamper(Account a)
        {
            lbtnr.Text = a.tktnr.ToString();
            lbstatus.Text = a.inCamp ? "In" : "Out";
            lbspot.Text = "# " + a.campnr;
            if (a.inCamp)
            {
                btnCheckIn.Enabled = false;
                btnCheckOut.Enabled = true;
            }
            else
            {
                btnCheckIn.Enabled = true;
                btnCheckOut.Enabled = false;
            }
        }

        private void showVisitor(Account a)
        {
            lbtnrV.Text = a.tktnr.ToString();
        }

        private void showAccList()
        {
            if (accList.Count > 0)
            {
                foreach (var item in accList)
                {
                    lbxAccLst.Items.Add(item);
                }

                if (accList.Count < 6)
                {
                    btnScanV.Enabled = true;
                }
                else
                {
                    btnScanV.Enabled = false;
                }
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (conn.CampCheck(acc))
            {
                showMsg("CHECKED-IN", true);
                InitialzeDisplay();
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (conn.CampCheck(acc))
            {
                showMsg("CHECK-OUT", true);
                InitialzeDisplay();
            }
        }

        private void BtnScanRFID_Click(object sender, EventArgs e)
        {
            InitialzeDisplay();
            if (rfidReaderV != null)
            {
                rfidReaderV.Close();
            }

            BtnScanRFID.Enabled = false;
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

        private void btnScanV_Click(object sender, EventArgs e)
        {
            btnScanV.Enabled = false;
            BtnAddV.Enabled = false;
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

        private void BtnAddV_Click(object sender, EventArgs e)
        {
            if (conn.AddVisitorToList(acc, accV))
            {
                lbtnrV.Text = "*****";
                BtnAddV.Enabled = false;
                lbxAccLst.Items.Clear();            
                accList = conn.GetListIfOwner(acc);
                showCamper(acc);
                showAccList();
                showMsg("NEW VISITOR ADDED", true);
            }
        }
    }
}
