using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LlCheckIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckIn checkIn = new CheckIn();
            checkIn.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 checkInCamp = new Form2();
            checkInCamp.ShowDialog();
            this.Close();
        }

        private void BnSellTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellTicket sellTicket = new SellTicket();
            sellTicket.ShowDialog();
            this.Close();
        }

        private void BnAddMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddMoney addMoney = new AddMoney();
            addMoney.ShowDialog();
            this.Close();

        }

        private void BnLoanItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loan_Items loan = new Loan_Items();
            loan.ShowDialog();
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Information info = new Information();
            info.ShowDialog();
            this.Close();
        }

        private void BnCheckOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Check_Out co = new Check_Out();
            co.ShowDialog();
            this.Close();
        }
    }
}
