using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Addresss { set; get; }
        private Dictionary<string, Product> products;
        public Shop(string name, string address):this()
        {
            Name = name;
            Addresss = address;
        }
        public Shop()
        {
            products=new Dictionary<string, Product>();
        }

        public void AddItem(Product productToBeAdded)
        {
            if (products.ContainsKey(productToBeAdded.Id))
                products[productToBeAdded.Id].Quantity += productToBeAdded.Quantity;
            else
                products.Add(productToBeAdded.Id, productToBeAdded);
        }

        public Product[] GetAllProducts()
        {
            return products.Values.ToArray();
        }
    }
}
