using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JXLibrary;

namespace GUI
{
    public partial class Information : Form
    {
        VisitorController v;
        LoaningController loans;
        SaleController sales;
        public Information()
        {
            InitializeComponent();
            v = new VisitorController();
            loans = new LoaningController();
            sales = new SaleController();
        }

        private void BTnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

        private void Btn_sCheck_Click(object sender, EventArgs e)
        {
            if (cb_rentShop.SelectedIndex == 0) { l_sAmount.Text = v.ShopRentSpent(1).ToString(); }
            else if (cb_rentShop.SelectedIndex == 1) { l_sAmount.Text = v.ShopRentSpent(2).ToString(); }
            else if (cb_saleShop.SelectedIndex == 0) { l_sAmount.Text = sales.ShopSaleSpent(1).ToString(); }
            else if (cb_rentShop.SelectedIndex == 1) { l_sAmount.Text = sales.ShopSaleSpent(2).ToString(); }
            else if (cb_rentShop.SelectedIndex == 2) { l_sAmount.Text = sales.ShopSaleSpent(3).ToString(); }
        }

        private void Btn_statics_Click(object sender, EventArgs e)
        {
            l_nrOfV.Text =v.NrOfVisitors().ToString();
            l_balance.Text = v.TotalBalance().ToString();
            l_spent.Text = v.Spent().ToString();
            l_spots.Text = v.BookedSpots().ToString();
            l_freeSpots.Text = v.LeftSpots().ToString();
            
        }

        private void Btn_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            Guest_s_Info info =new Guest_s_Info();
            info.ShowDialog();
            this.Close();
        }

        private void Btn_iCheck_Click(object sender, EventArgs e)
        {
            if (cb_item.SelectedIndex == 0)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(1, 2).ToString();
            }
            else if (cb_item.SelectedIndex == 1)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(2, 3).ToString();
            }
            else if (cb_item.SelectedIndex == 2)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(3, 6).ToString();
            }
            else if (cb_item.SelectedIndex == 3)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(4, 4).ToString();
            }
            else if (cb_item.SelectedIndex == 4)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(5, 2).ToString();
            }
            else if (cb_item.SelectedIndex == 5)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(6, 2).ToString();
            }
            else if (cb_item.SelectedIndex == 6)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(7, 6).ToString();
            }
            else if (cb_item.SelectedIndex == 7)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(8, 8).ToString();
            }
            else if (cb_item.SelectedIndex == 8)
            {
                lb_iAmout.Text = sales.CalTotalOfSaleItem(9, 5).ToString();
            }
            else if (cb_item.SelectedIndex == 9)
            {
                lb_iAmout.Text = loans.CalTotalOfRentItem(cb_item.SelectedItem.ToString(), 5).ToString();
            }
            else if (cb_item.SelectedIndex == 11)
            {
                lb_iAmout.Text = loans.CalTotalOfRentItem(cb_item.SelectedItem.ToString(), 2).ToString();
            }
            else
            {
                lb_iAmout.Text = loans.CalTotalOfRentItem(cb_item.SelectedItem.ToString(), 2).ToString();
            }
        }
    }
}
