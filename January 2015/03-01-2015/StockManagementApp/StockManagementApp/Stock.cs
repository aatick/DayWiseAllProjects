using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp
{
    public class Stock
    {
        private Dictionary<string, StockItem> items;

        public Stock()
        {
            items=new Dictionary<string, StockItem>();
        }

        public void StockIn(StockItem itemToBeAdded)
        {
            if (items.ContainsKey(itemToBeAdded.Id))
                items[itemToBeAdded.Id].Quantity += itemToBeAdded.Quantity;
            else
                items.Add(itemToBeAdded.Id,itemToBeAdded);
        }

        public void StockOut(StockItem itemToBeDeleted)
        {
            if (items.ContainsKey(itemToBeDeleted.Id))
            {
                if (items[itemToBeDeleted.Id].Quantity > itemToBeDeleted.Quantity)
                    items[itemToBeDeleted.Id].Quantity -= itemToBeDeleted.Quantity;
                else if (items[itemToBeDeleted.Id].Quantity == itemToBeDeleted.Quantity)
                    items.Remove(itemToBeDeleted.Id);
                else
                    throw new QuantityOutOfRangeException(itemToBeDeleted.Quantity, items[itemToBeDeleted.Id].Quantity);
            }
            else
                throw new ItemNotFoundException(itemToBeDeleted.Id);
        }

        public StockItem[] GetAllStockItems()
        {
            return items.Values.ToArray();
        }
    }

    class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(string id) : base("Item with Item Id " + id + " is Not Exist in the system")
        {
        }
    }

    class QuantityOutOfRangeException : Exception
    {
        public QuantityOutOfRangeException(int itemOverloadQuantity, int itemActualQuantity)
            : base("Sorry!, There is " + itemActualQuantity + " items available,\nBut you are trying to Stock out " + itemOverloadQuantity+" items.")
        {
        }
    }
}
