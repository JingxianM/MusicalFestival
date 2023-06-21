using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Web;
using System.Data;
using System.IO;
using System.Collections;
using GUI.Properties;
using System.Text.RegularExpressions;

namespace GUI.ERD
{
    class VisitorController
    {
        private List<visitor> visitors;
        public VisitorController()
        {
            visitors = new List<visitor>();
        }


        /* Top Up start
           Top Up start 
           Top Up start */
        public bool TopUpOnePpl(int ticketNr, decimal balance)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET balance = '" + balance + "' WHERE ticketNr = '" + ticketNr + "'; ";
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

        public bool GetBalanceByTicketNr(int ticketNr, out decimal balance)
        {
            try
            {
                bool result = false;
                string sqlQuery = "SELECT balance FROM visitor WHERE ticketNr='" + ticketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command1.ExecuteReader();
                balance = 0;
                if (reader.Read())
                {
                    balance = Convert.ToDecimal(reader["balance"]);
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
        public bool TopUpAll(ArrayList arrlist)
        {
            dbConnection.OpenConnection();

            bool result = true;
            foreach (string[] rec in arrlist)
            {
                int ticketNr = int.Parse(rec[0]);
                decimal dbBalance = Convert.ToDecimal(rec[1]);
                decimal balance;
                if (GetBalanceByTicketNr(ticketNr, out balance))
                {
                    balance += dbBalance;
                    if (TopUpOnePpl(ticketNr, balance))
                    {
                        result = !result;
                    }
                }
            }
            return result;
        }

        /* Top Up End 
           Top Up End 
           Top Up End */


        /* ticket start
           ticket start 
           ticket start */


        private int GenerateTicketNr(int days)
        {
            try
            {
                dbConnection.OpenConnection();
                Random rd = new Random();
                int ticketNr;
                if (days == 1)ticketNr = rd.Next(1000000, 9999999);

                else if (days == 2)ticketNr = rd.Next(100000, 999999);

                else ticketNr = rd.Next(10000, 99999);

                string sqlQuery = "SELECT * FROM visitor WHERE ticketNr='" + ticketNr + "'";
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return ticketNr;
                }
                return GenerateTicketNr(days);
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
        public bool CheckEmailRegistered(string email)
        {
            try
            {
                bool result=false;
                dbConnection.OpenConnection();
                string check = "SELECT * FROM visitor WHERE email='" + email + "'";
                MySqlCommand cmd = new MySqlCommand(check, dbConnection.con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return result;
                }
                else
                {
                    return false;//not registered
                }

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
        public bool CheckEmailFormat(string email)
        {
            string pattern = @"^\w+@\w{2,5}.com";

            //Regex.IsMatch check email format
            if (Regex.IsMatch(email, pattern)) return true;//correct
            else return false;//incorrect
        }
        public bool CheckAge(DateTime dob, DateTime now)
        {
            int age = now.Year - dob.Year;
            if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day)) age--;
            if (age < 16) return true;
            else return false;
        }
        public bool SighUp(string fname, string lname, DateTime dob, string email, string pwd, string bank, decimal balance, int days)
        {
            try
            {
                bool result = false;
                int ticketNr = GenerateTicketNr(days);
                string dobFromat = dob.ToString("yyy-MM-dd");
                string sqlInsert = "INSERT INTO visitor (ticketNr, email, password, fname, lname, birthday, bankAccount,balance,campNr,inPark,inCamp) " +
                                    "VALUES ('" + ticketNr + "','" + email + "','" + pwd + "','" +fname+ "','" +lname+ "','" + dobFromat + "','" + bank + "','" + balance + "','" + 0+ "','" + 0 + "','" +0+ "');";
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
        public visitor GetVisitorByTicketNr(int ticketNr)
        {
            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE ticketNr='" + ticketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string email = reader["email"].ToString();
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["dob"]);
                    string bank = reader["bank"].ToString();
                    string rfid = reader["Rfid"].ToString();
                    string pwd = reader["password"].ToString();
                    decimal balance = Convert.ToDecimal(reader["balance"]);
                    visitor v = new visitor(ticketNr, email, pwd, fname,lname, dob, balance,rfid,bank);
                    return v;
                }
                else
                {
                    dbConnection.CloseConnection();
                    return null;
                }
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
        public visitor GetAcountByTag(string rfid)
        {
            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE Rfid='" + rfid + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int ticketNr = Convert.ToInt32(reader["ticketNr"]);
                    string email = reader["email"].ToString();
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["dob"]);
                    string bank = reader["bank"].ToString();
                    string pwd = reader["password"].ToString();
                    decimal balance = Convert.ToDecimal(reader["balance"]);
                    visitor v = new visitor(ticketNr, email, pwd, fname, lname, dob, balance, rfid, bank);
                    return v;
                }
                else
                {
                    dbConnection.CloseConnection();
                    return null;
                }
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

        public bool BindRfidWzOnLineTkt(visitor v, string rfid)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET Rfid = '" + rfid + "' WHERE ticketNr = '" + v.TicketNr + "'; ";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlUpdate, dbConnection.con);
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
        public bool CheckIn(visitor v)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor set inPark= '1' WHERE ticketNr='" + v.TicketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlUpdate, dbConnection.con);
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



        /* ticket End 
           ticket End 
           ticket End */
    }
}
