using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace JXLibrary
{
    public class LoaningController
    {
        private List<RentProduct> products;
        private VisitorController vc = new VisitorController();
        public LoaningController()
        {
            products = new List<RentProduct>();
        }

        public bool UndateLoanProducts(int itemId)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE rentproduct SET taken = '" + 1 + "' WHERE itemId = '" + itemId + "'; ";
                dbConnection.OpenConnection();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, dbConnection.con);
                if (command2.ExecuteNonQuery() != 1)
                {
                    result = !result;
                }
                return result;
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

        private decimal GetBalanceByTicketNr(int ticketNr, out decimal balance)
        {
            try
            {
                string sqlQuery = "SELECT balance FROM visitor WHERE ticketNr='" + ticketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command1.ExecuteReader();
                balance = 0;
                if (reader.Read())
                {
                    balance = Convert.ToDecimal(reader["balance"]);
                }

                return balance;
               
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
        private decimal GetSpentByTicketNr(int ticketNr, out decimal spent)
        {
            try
            {
                string sqlQuery = "SELECT spent FROM visitor WHERE ticketNr='" + ticketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command1.ExecuteReader();
                spent = 0;
                if (reader.Read())
                {
                    spent = Convert.ToDecimal(reader["spent"]);
                }

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
        public bool UpdateBalance(int ticketNr, decimal price)
        {
            try
            {
                decimal balance;
                decimal dbBalance=GetBalanceByTicketNr(ticketNr,out balance);
                dbBalance -= price;
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET balance = '" + dbBalance + "' WHERE ticketNr = '" + ticketNr + "'; ";
                dbConnection.OpenConnection();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, dbConnection.con);
                if (command2.ExecuteNonQuery() != 1)
                {
                    result = !result;
                }
                return result;
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
        public bool UpdateSpent(int ticketNr, decimal price)
        {
            try
            {
                decimal spent;
                decimal dbSpent = GetSpentByTicketNr(ticketNr, out spent);
                dbSpent += price;
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET spent = '" + dbSpent + "' WHERE ticketNr = '" + ticketNr + "'; ";
                dbConnection.OpenConnection();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, dbConnection.con);
                if (command2.ExecuteNonQuery() != 1)
                {
                    result = !result;
                }
                return result;
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
        private int GenerateRentId()
        {
            try
            {
                dbConnection.OpenConnection();
                Random rd = new Random();
                int rentId = rd.Next(1111, 9999);
                string sqlQuery = "SELECT * FROM rent WHERE rentId='" + rentId + "'";
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return rentId;
                }
                return GenerateRentId();
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
        private decimal GetShopMoneyByShopNr(int shopNr, out decimal money)
        {
            try
            {
                string sqlQuery = "SELECT AmountMoney FROM rentshop WHERE shopNr='" + shopNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command1.ExecuteReader();
                money = 0;
                if (reader.Read())
                {
                    money = Convert.ToDecimal(reader["AmountMoney"]);
                }

                return money;

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
        public bool UpdateMoneyInShop(decimal money)
        {
            try
            {
                decimal balance;
                decimal dbMoney = GetShopMoneyByShopNr(1, out balance);
                dbMoney += money;
                bool result = false;
                string sqlUpdate = "UPDATE rentshop SET AmountMoney = '" + dbMoney + "' WHERE shopNr = 1 ";
                dbConnection.OpenConnection();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, dbConnection.con);
                if (command2.ExecuteNonQuery() != 1)
                {
                    result = !result;
                }
                return result;
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
        public bool UpdateRent(int itemId,int ticketNr,int shopNr,int fromDays,string itemName)
        {
            try
            {
                bool result = false;
                int rentId = GenerateRentId();
                string sqlInsert = "INSERT INTO rent (rentId,itemId,ticketNr,shopNr,saleDay,returned,itemName) " +
                                    "VALUES ('" + rentId + "','" + itemId + "','" + ticketNr + "','" + shopNr + "','" + fromDays + "','" + 0 + "','" + itemName+"');";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlInsert, dbConnection.con);
                if (command.ExecuteNonQuery() == 1)
                {
                    result = !result;
                }
                return result;
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

        public List<string> GetRentList(string rfid)
        {
            visitor v = vc.GetAcountByTag(rfid);
            List<string> rent = new List<string>();
            try
            {
                string item = "";
                string sqlQuery = "SELECT itemName FROM rent WHERE ticketNr='" + v.TicketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    item = reader["itemName"].ToString();
                    rent.Add(item);
                }
                return rent;
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

        public decimal CalTotalOfRentItem(string itemName, decimal price)
        {
            try
            {
                decimal amount;
                string sqlQuery = "SELECT COUNT(*) FROM rent WHERE itemName='" + itemName + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                amount = Convert.ToDecimal(command1.ExecuteScalar());
                decimal earn = amount * price;
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
       
    }
}
