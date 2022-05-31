using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;
        
        public int ItemNo
        {
            get { return itemNo; }  
            set { itemNo = value; }
        }

        public string Description
        {
            get { return description; } 
            set { description = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public InvItem()
        {
            
        }

        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public string GetDisplayText()
        {
            return itemNo + " " + description + " " + price.ToString("c");
        }
    }
}


