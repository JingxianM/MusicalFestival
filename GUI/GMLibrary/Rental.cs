using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMLibrary
{
    public class Rental
    {
        public int deviceID { get; }

        public double deposit { get; }

        public Rental(int deviceID, double deposit)
        {
            this.deviceID = deviceID;
            this.deposit = deposit;
        }

        public override string ToString()
        {
            return "rentID: " + this.deviceID + ", deposit: " + this.deposit + " euro";
        }
    }
}
