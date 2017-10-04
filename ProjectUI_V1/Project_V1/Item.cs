using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V1
{
    public class Item
    {
        string productName;
        float productPrice;
        int productQuantity;

        public Item(string name, float price, int quantity)
        {
            //Sets all the variables.
            productName = name;
            productPrice = price;
            productQuantity = quantity;
        }

        //Getters so that the SaleRecord has read access to these variables.
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

        public float getTotalCost()
        {
            return productPrice * productQuantity;
        }

        public void addQuantity(int quant)
        {
            productQuantity += quant;
        }
    }
}
