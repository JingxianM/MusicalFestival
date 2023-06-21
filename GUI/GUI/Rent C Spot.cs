using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phidget22;
using Phidget22.Events;

namespace GUI
{
    public partial class Rent_C_Spot: Form
    {
        private RFID myRFIDReader;
        private RFIDNr RFIDnumber;
        public Rent_C_Spot()
        {

            InitializeComponent();
            try
            {
                myRFIDReader = new RFID();
                // myRFIDReader.Attach += new AttachEventHandler(AttachRFID);
                myRFIDReader.Open();
            }
            catch (PhidgetException) { MessageBox.Show("Something went wrong with the RFID"); }
        }

        private void BnScanRFID_Click(object sender, EventArgs e)
        {
            RFIDnumber = new RFIDNr(myRFIDReader.DeviceSerialNumber.ToString());
        }

    }
}
