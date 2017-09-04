using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Project
{
    class SalesRecord
    {
        enum Modes {Add, Edit};
        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;

        Boolean Loop;
        string userInput;

        public SalesRecord(int Mode)
        {
            Loop = true;
            saleItems = new List<Item>();

            if (Mode == (int)Modes.Add)
            {
                AddRecord();
            }
        }

        private void PrintRecord()
        {
            Console.WriteLine("Printing Record Data");
            Console.WriteLine("-------------------------");
            Console.WriteLine(saleTime);
            Console.WriteLine("-------------------------");

            foreach (Item element in saleItems)
            {
                Console.Write("Product Name: ");
                Console.WriteLine(element.getProductName());
                Console.Write("Product Price: ");
                Console.WriteLine(element.getProductPrice());
                Console.Write("Product Quantity: ");
                Console.WriteLine(element.getProductQuantity());
                Console.Write("Product Total: ");
                Console.WriteLine(element.getProductQuantity() * element.getProductPrice());
                Console.WriteLine("-------------------------");
            }

            Console.Write("Sale Total: ");
            Console.WriteLine(saleTotal);
            Console.WriteLine("-------------------------");
        }

        private void AddRecord()
        {
            Console.WriteLine("ADD RECORD");
            while (Loop)
            {
                Console.WriteLine("     1. Add Item");
                Console.WriteLine("     2. Complete Record");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            AddItem();
                            break;
                        }
                    case "2":
                        {
                            Loop = false;
                            saleTime = DateTime.Now;
                            foreach (Item element in saleItems)
                            {
                                saleTotal += element.getProductQuantity() * element.getProductPrice();
                            }
                            break;
                        }
                }
            }
            PrintRecord();
        }

        private void AddItem()
        {
            Console.WriteLine("Please Enter an Item Name:");
            string name = Console.ReadLine();
            while (!ValidateName(name))
            {
                Console.WriteLine("Please Enter a valid Item Name:");
                name = Console.ReadLine();
            }

            Console.WriteLine("Please Enter an Item Price");
            string stringprice = Console.ReadLine();
            while (!ValidatePrice(stringprice))
            {
                Console.WriteLine("Please Enter a valid Item Price:");
                stringprice = Console.ReadLine();
            }
            float price = float.Parse(stringprice);


            Console.WriteLine("Please Enter an Item Quantity");
            string stringquantity = Console.ReadLine();
            while (!ValidateQuantity(stringquantity))
            {
                Console.WriteLine("Please Enter a valid Item Quantity");
                stringquantity = Console.ReadLine();
            }
            int quantity = Convert.ToInt16(stringquantity);

            saleItems.Add(new Item(name, price, quantity));
        }

        private Boolean ValidateName(string name)
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");
            if (regexItem.IsMatch(name))
                return true;
            else
                return false;
        }

        private Boolean ValidatePrice(string price)
        {
            var regexItem = new Regex("^[0-9]{1,3}.[0-9]{1,2}$");
            if (regexItem.IsMatch(price))
                return true;
            else
                return false;
        }

        private Boolean ValidateQuantity(string quantity)
        {
            var regexItem = new Regex("^[0-9]{1,2}$");
            if (regexItem.IsMatch(quantity))
                return true;
            else
                return false;
        }
    }
}
