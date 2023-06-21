using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXLibrary
{
   public class Sale
    {
        public int ReceiptNr { get;private set; }
        public int TicketNr { get; private set; }
        public int ProductId { get; private set; }
        public int QttSold { get; private set; }
        public int ShopNr { get; private set; }

        public Sale(int receiptNr, int ticketNr, int productId, int qtt, int shopNr)
        {
            this.ReceiptNr = receiptNr;
            this.TicketNr = ticketNr;
            this.ProductId = productId;
            this.QttSold = qtt;
            this.ShopNr = shopNr;
        }

    }
}
