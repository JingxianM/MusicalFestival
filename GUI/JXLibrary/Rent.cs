using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXLibrary
{
    public class Rent
    {
        public int RentId { get; private set; }
        public int TicketNr { get; private set;}
        public int ItemId { get; private set; }
        public int ShopNr { get; private set; }
        public int SaleTime { get; private set; }

        public Rent(int rentId, int ticketNr, int itemId, int shopNr, int saleTime)
        {
            this.RentId = rentId;
            this.TicketNr = ticketNr;
            this.ItemId = itemId;
            this.ShopNr=shopNr;
            this.SaleTime = saleTime;
        }

    }
}
