using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    class RFIDNr
    {
        private string number;

        public RFIDNr(string number)
        {
            this.number = number;
        }
        public string GetRFIDNr()
        {
            return number;
        }

    }
}
