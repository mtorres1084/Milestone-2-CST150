using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author: Miguel Torres Perez
// CST-150

namespace Milestone2
{
    class InventoryItem
    {
        public string Flavor { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public string Description { get; private set; }

        public InventoryItem(string flavor, double price, int quantity, string description)
        {
            this.Flavor = flavor;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
        }
        public bool OutOfStock()
        {
            if(Quantity == 0)
            {
                return true;
            }
            return false;
        }
        public bool AbleToBuy(int want)
        {
            if(Quantity >= want)
            {
                return true;
            }
            return false;
        }
        public bool BuyItem(int want)
        {
            if((want > 0) && (!OutOfStock()) && (AbleToBuy(want)))
            {
                Quantity = -want;
                return true;
            }
            return false;
        }
    }
}
