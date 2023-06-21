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
using JXLibrary;

namespace GUI
{
    public partial class Guest_s_Info : Form
    {
        // private RFID rfidReader;
        private RFID rfidReaderV;
        private LoaningController loans;
        private VisitorController visitors;
        private visitor visitor;
        private Sale s;
        private SaleController sales;
        public Guest_s_Info()
        {
            InitializeComponent();
            loans = new LoaningController();
            visitors = new VisitorController();
            sales = new SaleController();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void GBxInformation_Enter(object sender, EventArgs e)
        {

        }

        private void BuyingHistory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Btn_scan_Click(object sender, EventArgs e)
        {
            btn_scan.Enabled = false;
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


        private void RfidTagScanV(object sender, RFIDTagEventArgs e)
        {
            string rfid = e.Tag.ToString();
            visitor = visitors.GetAcountByTag(rfid);
            if (visitor != null)
            {
                lb_balance.Text = visitor.Balance.ToString();
                lb_fname.Text = visitor.Fname;
                lb_lname.Text = visitor.Lname;
                lb_dob.Text = visitor.Dob.ToString("dd - MM - yyyy");
                lb_status.Text = visitor.InPark ? "In park" : "Not in park";
                lb_ticketId.Text = visitor.TicketNr.ToString();
                if (loans.GetRentList(visitor.Rfid).Count == 0)
                {
                    LoaningHistory.Items.Add("you didn't rent anything");
                }
                else
                {
                    foreach (var item in loans.GetRentList(visitor.Rfid))
                    {
                        LoaningHistory.Items.Add(item);
                    }
                }

                if (sales.GetBoughtList(visitor.Rfid).Count == 0)
                {
                    BuyingHistory.Items.Add("you didn't rent anything");
                }
                else
                {
                    foreach (var item in sales.GetBoughtList(visitor.Rfid))
                    {
                        BuyingHistory.Items.Add(item);
                    }
                }
                rfidReaderV.Close();
                showMsg("showed successfully", true);
            }
            else
            {
                showMsg("NO such account", false);

            }
            btn_scan.Enabled = true;

        }

    }
}
