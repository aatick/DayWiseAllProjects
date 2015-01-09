using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp
{
    public class StockItem
    {
        private string id;
        public int Quantity { get; set; }


        public StockItem(string itemId, int itemQuantity)
        {
            id = itemId;
            Quantity = itemQuantity;
        }

        public string Id
        {
            get { return id; }
        }
    }
}
