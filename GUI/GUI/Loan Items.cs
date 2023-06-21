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
    public partial class Loan_Items: Form
    {
       // private RFID rfidReader;
        private RFID rfidReaderV;
        private LoaningController loans;
        private VisitorController visitors;
        private visitor visitor;
        public Loan_Items()
        {

            InitializeComponent();
            loans = new LoaningController();
            visitors = new VisitorController();
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
                lb_Rfid.Text = visitor.Rfid;
                lb_status.Text = visitor.InPark.ToString();
                lb_ticketId.Text = visitor.TicketNr.ToString();;
                lb_age.Text = visitors.GetAge(visitor.TicketNr, DateTime.Now).ToString();
                rfidReaderV.Close();
            }
            else
            {
                showMsg("RFID not valid", false);

            }
            BnScanRFID.Enabled = true;

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


        private void Cb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_selectedItems.Items.Add(cb_item.SelectedItem);
            if (cb_item.SelectedIndex == 0)
            { l_deposit.Text = "10"; lb_price.Text = "2"; }
            else if (cb_item.SelectedIndex == 1)
            { l_deposit.Text = "7"; lb_price.Text = "3";}
            else
            {l_deposit.Text = "5"; lb_price.Text = "2";}
            TotalPrice();
        }
        private void BnLoan_Click(object sender, EventArgs e)
        {
            int itemId = Convert.ToInt32(tb_itemId.Text);
            int id = Convert.ToInt32(lb_ticketId.Text);
            if (cb_item.SelectedItem != null && tb_itemId!=null)
            {
                loans.UndateLoanProducts(itemId);
                loans.UpdateBalance(id, TotalPrice());
                loans.UpdateSpent(id, TotalPrice());
                loans.UpdateMoneyInShop(TotalPrice());
                loans.UpdateRent(itemId,id,1,cb_days.SelectedIndex+1,cb_item.SelectedItem.ToString());
                showMsg("you rent successfully!",true);
            }
            else
            {
                lb_message.ForeColor = Color.FromArgb(231, 76, 60);
                lb_message.Items.Add("Please complete the information");
            }
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            
        }

        private void L_price_Click(object sender, EventArgs e)
        {
          
        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private decimal TotalPrice()
        {
            decimal total = 0;
            int days;
            if (cb_days.SelectedIndex == 0) { days = 3; }
            else if (cb_days.SelectedIndex == 1) { days = 2; }
            else { days = 3; }

            if (cb_days.SelectedIndex != null)
            {
                decimal product =days * Convert.ToDecimal(lb_price.Text);
                total = product + Convert.ToDecimal(l_deposit.Text);
                l_total.Text = total.ToString();
                return total;
            }
            else { MessageBox.Show("Please complete the information"); return total; }
           
        }

        private void Tb_Days_TextChanged(object sender, EventArgs e)
        {
            l_total.Text = TotalPrice().ToString();
        }

        private void Cb_days_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal total;
            int days;
            if (cb_days.SelectedIndex == 0) { days = 3; }
            else if (cb_days.SelectedIndex == 1) { days = 2; }
            else { days = 3; }

            if (cb_days.SelectedIndex != null)
            {
                decimal product = days * Convert.ToDecimal(lb_price.Text);
                total = product + Convert.ToDecimal(l_deposit.Text);
                l_total.Text = total.ToString();
            }
        }
    }
}
