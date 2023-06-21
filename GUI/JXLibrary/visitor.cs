using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXLibrary
{
    public class visitor
    {
        public int TicketNr { get; private set; }
        public string Email { get; private set; }
        public string Pwd { get; private set; }
        public string Fname { get; private set; }
        public string Lname { get; private set; }
        public DateTime Dob { get; private set; }
        public bool InPark { get; private set; }
        public bool InCamp { get; private set; }
        public int CampNr { get; private set; }
        public decimal Balance { get; private set; }
        public string Rfid { get; private set; }
        public string Bank { get; private set; }
        public visitor(int ticketNr, string email, string pwd, string fname, string lname, DateTime dob, decimal balance, string rfid, string bank)
        {
            this.TicketNr = ticketNr;
            this.Email = email;
            this.Pwd = pwd;
            this.Fname = fname;
            this.Lname = lname;
            this.Dob = dob;
            this.Balance = balance;
            this.CampNr = 0;
            this.InCamp = false;
            this.InPark = true;
            this.Rfid = rfid;
            this.Bank = bank;
        }
    }
}
