using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXLibrary
{
    public class RentShop
    {
        public int ShopNr { get; private set; }
        public string ShopName { get; private set; }

        public RentShop(int shopNr, string shopName)
        {
            this.ShopNr = shopNr;
            this.ShopName = shopName;
        }
    }
}
