using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JXLibrary
{
   public class RentProduct
    {
        public int ItemId { get; private set; }
        public string ItemName { get; private set; }
        public decimal Price { get; private set; }
        public decimal Deposit { get; private set; }
        public string DamageInfo { get; private set; }

        public bool IsTaken { get; private set; }

        public RentProduct(int itemId, string itemName, decimal price, decimal deposit, string damageInfo)
        {
            this.ItemId = itemId;
            this.ItemName = itemName;
            this.Price = price;
            this.Deposit = deposit;
            this.DamageInfo = damageInfo;
            this.IsTaken = false;
        }
    }
}
