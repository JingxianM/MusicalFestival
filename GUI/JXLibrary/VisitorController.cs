using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace JXLibrary
{
    public class VisitorController
    {
        private List<visitor> visitors;
        public VisitorController()
        {
            visitors = new List<visitor>();
        }


        /* Top Up start
           Top Up start 
           Top Up start */
        private bool TopUpOnePpl(int ticketNr, decimal balance)
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
                if (days == 1) ticketNr = rd.Next(1000000, 9999999);

                else if (days == 2) ticketNr = rd.Next(100000, 999999);

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
                bool result = false;
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
          return  RegexUtilities.IsValidEmail(email);
        }
        public bool CheckAge(DateTime dob, DateTime now)
        {
            int age = now.Year - dob.Year;
            if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day)) age--;
            if (age < 16) return true;
            else return false;
        }

        public int GetAge(int ticketNr, DateTime now)
        {
            try
            {
                bool result = false;
                string sqlQuery = "SELECT birthday FROM visitor WHERE ticketNr='" + ticketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command1.ExecuteReader();
                DateTime dob = default (DateTime);
                if (reader.Read())
                {
                    dob =Convert.ToDateTime(reader["birthday"]);
                    result = !result;
                }
                int age = now.Year - dob.Year;
                if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day)) age--;
                return age;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                dbConnection.CloseConnection();
            }
           ;
        }
        public bool SighUp(string fname, string lname, DateTime dob, string email, string pwd, string bank, decimal balance, int days,int day1,int day2,int day3)
        {
            try
            {
                bool result = false;
                int ticketNr = GenerateTicketNr(days);
                string dobFromat = dob.ToString("dd-MM-yyyy");
                string sqlInsert = "INSERT INTO visitor (ticketNr, email, password, fname, lname, birthday, bankAccount,balance,campNr,inPark,inCamp,June27,June28,June29) " +
                                    "VALUES ('" + ticketNr + "','" + email + "','" + pwd + "','" + fname + "','" + lname + "','" + dobFromat + "','" + bank + "','" + balance + "','" + 0 + "','" + 0 + "','" + 0 + "','"+ day1 + "','"+day2 + "','"+ day3+ "');";
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
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
                    string rfid = reader["Rfid"].ToString();
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
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
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

        public visitor GetVisitorByEmail(string email)
        {
            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE email='" + email + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int ticketNr = Convert.ToInt32(reader["ticketNr"]);
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
                    string rfid = reader["Rfid"].ToString();
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

        public bool BindRfidWzOnLineTkt (visitor v, string rfid,string email)
        {
            try
            {
                v = GetVisitorByEmail(email);
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

        /* Information start 
           Information start  
           Information start  */
        public int NrOfVisitors()
        {
            try
            {
                int count;
                string sqlQuery = "SELECT COUNT(*) FROM visitor WHERE inPark=1";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                count = Convert.ToInt32(command1.ExecuteScalar());
                return count;
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

        public decimal TotalBalance()
        {
            try
            {
                decimal total;
                string sqlQuery = "SELECT SUM(balance) FROM visitor WHERE inPark=1";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                total = Convert.ToDecimal(command1.ExecuteScalar());
                return total;
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

        public int BookedSpots()
        {
            try
            {
                int count;
                string sqlQuery = "SELECT COUNT(*) FROM camp";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                count = Convert.ToInt32(command1.ExecuteScalar());
                return count;
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

        public int LeftSpots()
        {
            try
            {
                int count;
                string sqlQuery = "SELECT COUNT(*) FROM camp";
                dbConnection.OpenConnection();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, dbConnection.con);
                count = 45- Convert.ToInt32(command1.ExecuteScalar());
                return count;
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

        public decimal Spent()
        {
            try
            {
                decimal spent;
                string sqlQuery = "SELECT SUM(spent) FROM visitor";
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

        public decimal ShopRentSpent(int shopNr)
        {
            try
            {
                decimal spent;
                string sqlQuery = "SELECT SUM(AmountMoney) FROM rentshop WHERE shopNr='" + shopNr + "'";
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
        /* Information end
           Information end  
           Information end  */




        /* log out start
           log out start 
           log out start  */
        public visitor GetAccountByTagCheckOut(string rfid)
        {
            visitor v = GetAcountByTag(rfid);

            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE ticketNr='" + v.TicketNr + "'";
                dbConnection.OpenConnection();
                MySqlCommand command = new MySqlCommand(sqlQuery, dbConnection.con);
                MySqlDataReader reader = command.ExecuteReader();
                return v;
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
        public bool GateCheckOut(visitor v)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor set balance= '0', inPark='0', Rfid='0' WHERE ticketNr='" + v.TicketNr + "' ";
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

        /* log out end
          log out end  
          log out end  */

    }
}
