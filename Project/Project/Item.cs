using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Item
    {
        string productName;
        float productPrice;

        public Item(string name, float price)
        {
            productName = name;
            productPrice = price;
        }

        public float getProductPrice()
        {
            return productPrice;
        }

        public string getProductName()
        {
            return productName;
        }
    }
}
