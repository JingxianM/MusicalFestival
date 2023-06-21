using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;
using System.Windows.Forms;

namespace GMLibrary
{
    public class Connection
    {
        private MySqlConnection conn;

        public Connection()
        {
            String connInfo = "server=studmysql01.fhict.local;" +
                              "database=dbi387232;" +
                              "user id=dbi387232;" +
                              "password=gigi123;" +
                              "connect timeout=10;";
            conn = new MySqlConnection(connInfo);
        }

        public Account GetAcountByTag(string rfid)
        {
            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE Rfid='" + rfid + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int tktnr = Convert.ToInt32(reader["ticketNr"]);
                    string mail = reader["email"].ToString();
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
                    bool inpark = Convert.ToBoolean(reader["inPark"]);
                    int campnr = Convert.ToInt32(reader["campNr"]);
                    bool inCamp = Convert.ToBoolean(reader["inCamp"]);
                    double balance = Convert.ToDouble(reader["balance"]);
                    Account a = new Account(tktnr, mail, fname, lname, dob, bank, rfid, campnr, inpark, inCamp, balance);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public Account GetAcountByTkt(int tktnr)
        {
            try
            {
                string sqlQuery = "SELECT * FROM visitor WHERE ticketNr='" + tktnr + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string mail = reader["email"].ToString();
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
                    string rfid = reader["Rfid"].ToString();
                    bool inpark = Convert.ToBoolean(reader["inPark"]);
                    int campnr = Convert.ToInt32(reader["CampNr"]);
                    bool inCamp = Convert.ToBoolean(reader["inCamp"]);
                    double balance = Convert.ToDouble(reader["balance"]);
                    Account a = new Account(tktnr, mail, fname, lname, dob, bank, rfid, campnr, inpark, inCamp, balance);
                    return a;
                }
                else
                {
                    return null;
                }
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public Account GetAccountByTagCheckOut(string rfid)
        {

            try
            {
                Account acc = GetAcountByTag(rfid);
                if (acc is null)
                {
                    return null;
                }
                string sqlQuery = "SELECT * FROM borrow WHERE ticketNr='" + acc.tktnr + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["returnTime"].ToString() == "")
                    {
                        int deviceId = Convert.ToInt32(reader["itemID"]);
                        double deposit = Convert.ToDouble(reader["deposit"]);
                        Rental r = new Rental(deviceId, deposit);
                        acc.AddRental(r);
                    }
                }
                return acc;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public bool GateCheckIn(Account acc)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor set inPark= '1' WHERE ticketNr='" + acc.tktnr + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool GateCheckOut(Account acc)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor set balance= '0', inPark='0', Rfid='0' WHERE ticketNr='" + acc.tktnr + "' ";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }


        public bool CampCheck(Account acc)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "";
                int value = acc.inCamp ? 0 : 1;


                    sqlUpdate = "UPDATE visitor set inCamp= '"+value+"' WHERE ticketNr='" + acc.tktnr + "'";

                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool SaleTicketATD(string mail, string bank, string fname, string lname, DateTime dob, bool gender, string rfid)
        {
            try
            {
                bool result = false;
                int tktnr = GetNewTktNr();
                string newDate = dob.ToString("yyy-MM-dd");
                string sqlUpdate = "INSERT INTO visitor (ticketNr, lname, fname, birthday, email, bankAccount, Rfid) " +
                                    "VALUES ('" + tktnr + "','" + lname + "','" + fname + "','" + newDate + "','" + mail + "','" + bank + "','" + rfid + "');";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool BindRfidWzOnLineTkt(Account acc, string rfid)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET Rfid = '" + rfid + "' WHERE ticketNr = '" + acc.tktnr + "'; ";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public int GetNewTktNr()
        {
            try
            {
                Random rd = new Random();
                int tktnr = rd.Next(1000000, 9999999);
                string sqlQuery = "SELECT * FROM visitor WHERE ticketNr='" + tktnr + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.Read())
                {
                    return tktnr;
                }
                return GetNewTktNr();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Validemail(string mail)
        {
            try
            {
                bool result = false;
                string sqlQuery = "SELECT * FROM visitor WHERE email='" + mail + "'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return result;
                }
                return !result;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Campspot> GetSpots()
        {
            try
            {
                List<Campspot> spots = new List<Campspot>();
                string sqlQuery = "SELECT * FROM camp";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["campNr"]);
                    bool occupid = Convert.ToBoolean(reader["ownerNr"]);
                    Campspot spot = new Campspot(id, occupid);
                    spots.Add(spot);
                }
                return spots;
            }
            catch (MySqlException)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public List<Account> GetListIfOwner(Account a)
        {         
            try
            {
                List<Account> output = new List<Account>();
                string sqlQuery = "SELECT * from visitor WHERE campNr = (SELECT campNr FROM camp WHERE ownerNr='"+a.tktnr+"' ) ";   
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int tktnr = Convert.ToInt32(reader["ticketNr"]);
                    string mail = reader["email"].ToString();
                    string fname = reader["fname"].ToString();
                    string lname = reader["lname"].ToString();
                    DateTime dob = Convert.ToDateTime(reader["birthday"]);
                    string bank = reader["bankAccount"].ToString();
                    string rfid = reader["Rfid"].ToString();
                    bool inpark = Convert.ToBoolean(reader["inPark"]);
                    int campnr = Convert.ToInt32(reader["CampNr"]);
                    bool inCamp = Convert.ToBoolean(reader["inCamp"]);
                    double balance = Convert.ToDouble(reader["balance"]);
                    Account temp = new Account(tktnr, mail, fname, lname, dob, bank, rfid, campnr, inpark, inCamp, balance);
                    output.Add(temp);
                }

                return output;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }           
        }

        public bool AddVisitorToList(Account o, Account v)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET campNr = '" + o.campnr + "' WHERE ticketNr = '" + v.tktnr + "'; ";
                conn.Open();
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool OrderCampSpot(int campnr,int ownerNr)
        {
            try
            {
                bool result = false;
                conn.Open();
                string sqlUpdate = "UPDATE camp WHERE campNr = '" + campnr + "' AND ownerNr = '"+ownerNr+"'; ";
                MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool AddAccToSpot(List<Account> accs, int campnr)
        {
            try
            {
                bool result = false;
                conn.Open();

                foreach (Account acc in accs)
                {
                    string sqlUpdate = "UPDATE visitor SET campNr = '" + campnr + "', balance ='" + (acc.balance - 30) + "' " +
                        "WHERE ticketNr = '" + acc.tktnr + "'; ";
                    MySqlCommand command = new MySqlCommand(sqlUpdate, conn);
                    if (command.ExecuteNonQuery() != 1)
                    {
                        result = !result;
                    }
                }
                return result;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool RentCampSpot(List<Account> accs, int campnr,int ownerNr)
        {
            try
            {
                bool result = false;
                if (OrderCampSpot(campnr, ownerNr))
                {
                    if (!AddAccToSpot(accs, campnr))
                    {
                        result = !result;
                    }
                }
                return result;
            }
            catch (MySqlException)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }


        public bool TopUpOnce(int tktnr, double dbBalance)
        {
            try
            {
                bool result = false;
                string sqlUpdate = "UPDATE visitor SET balance = '" + dbBalance + "' WHERE ticketNr = '" + tktnr + "'; ";
                conn.Open();
                MySqlCommand command2 = new MySqlCommand(sqlUpdate, conn);
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
                conn.Close();
            }
        }

        public bool GetBalanceByTkt(int tktnr, out double dbBalance)
        {
            try
            {
                bool result = false;
                string sqlQuery = "SELECT balance FROM visitor WHERE ticketNr='" + tktnr + "'";
                conn.Open();
                MySqlCommand command1 = new MySqlCommand(sqlQuery, conn);
                MySqlDataReader reader = command1.ExecuteReader();
                dbBalance = 0;
                if (reader.Read())
                {
                    dbBalance = Convert.ToDouble(reader["balance"]);
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
                conn.Close();
            }
        }

        public bool TopUpAll(ArrayList arrlist)
        {
            bool result = true;
            foreach (string[] rec in arrlist)
            {
                int tktnr = int.Parse(rec[0]);
                double balance = Convert.ToDouble(rec[1]);
                double dbBalance;
                if (GetBalanceByTkt(tktnr, out dbBalance))
                {
                    dbBalance += balance;
                    if (TopUpOnce(tktnr, dbBalance))
                    {
                        result = !result;
                    }
                }
            }
            return result;
        }
    }
}
