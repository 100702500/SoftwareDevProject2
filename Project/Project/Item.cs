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
        int productQuantity;

        public Item(string name, float price, int quantity)
        {
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }

        public float getProductPrice()
        {
            return productPrice;
        }

        public string getProductName()
        {
            return productName;
        }

        public int getProductQuantity()
        {
            return productQuantity;
        }
    }
}
