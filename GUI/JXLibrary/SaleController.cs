using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace JXLibrary
{
    public class SaleController
    {
        private List<Sale> sales;
        private VisitorController vc = new VisitorController();
        public SaleController()
        {
            sales = new List<Sale>();
        }

        public List<string> GetBoughtList(string rfid)
        {
            visitor v = vc.GetAcountByTag(rfid);
            List<string> s = new List<string>();

            try
            {
                string sqlQuery = "SELECT saleProduct.name FROM saleProduct,sale WHERE saleProduct.id=sale.ProductId and ticketNr='" + v.TicketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    s.Add(name);
                }
                return s;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public decimal CalTotalOfSaleItem(int productId, decimal price)
        {
            try
            {
                decimal earn;
                string sqlQuery = "SELECT SUM(qttSold) FROM sale WHERE productID='" + productId + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                if (command1.ExecuteScalar() is DBNull)
                {
                    earn = 0;
                }
                else { earn = Convert.ToDecimal(command1.ExecuteScalar()) * price; }
                return earn;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
        public decimal ShopSaleSpent(int shopNr)
        {
            try
            {
                decimal spent;
                string sqlQuery = "SELECT SUM(spent) FROM saleshop WHERE shopNr='" + shopNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                spent = Convert.ToDecimal(command1.ExecuteScalar());
                return spent;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}
