﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

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

        //Constructor, selects a method based on the Mode that was passed in.
        public SalesRecord(int Mode)
        {
            Loop = true;
            saleItems = new List<Item>();

            if (Mode == (int)Modes.Add)
            {
                AddRecord();
            }
        }

        //Takes the whole record and writes it to a CSV file in the desktop.
        private void writeRecord(DateTime date)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string dateTime = date.ToString();

            string createddate = Convert.ToDateTime(dateTime).ToString("dd-MM-yyyy h_mm-tt");
            path += "\\"+ createddate + ".csv";
            Console.WriteLine("Saved at: " + path);
            string delimiter = ",";

            int length = saleItems.Count + 1; 
            string[][] record = new string[length][];

            record[0] = new string[] { "Product Name", "Product Price", "Product Quantity"};
          
            for (int i = 1; i < length; i++)
            {
                record[i] = new string[] { saleItems[i-1].getProductName(), saleItems[i-1].getProductPrice().ToString(), saleItems[i-1].getProductQuantity().ToString() };
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                sb.AppendLine(string.Join(delimiter, record[i]));
            }
             File.WriteAllText(path, sb.ToString());
            
        }

        //Prints the contents of the Record.
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

        //Add Record interface.
        private void AddRecord()
        {
            Console.WriteLine("ADD RECORD");
            DateTime dateTime = DateTime.Now;
            //Loop over user input.
            while (Loop)
            {
                Console.WriteLine("     1. Add Item");
                Console.WriteLine("     2. Complete Record");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            //If User selected Add Item, begin the method.
                            AddItem();
                            
                            writeRecord(dateTime);
                            break;
                        }
                    case "2":
                        {
                            //If user selected Complete Record, record some data and break the loop.
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
            //Print the completed Record.
            PrintRecord();
        }

        //Add invidvidual items to the sales record.
        private void AddItem()
        {
            //Take in user input for name and perform validation.
            Console.WriteLine("Please Enter an Item Name:");
            string name = Console.ReadLine();
            while (!ValidateName(name))
            {
                Console.WriteLine("Please Enter a valid Item Name:");
                name = Console.ReadLine();
            }
            //Take in user input for price and perform validation.
            Console.WriteLine("Please Enter an Item Price");
            string stringprice = Console.ReadLine();
            while (!ValidatePrice(stringprice))
            {
                Console.WriteLine("Please Enter a valid Item Price:");
                stringprice = Console.ReadLine();
            }
            float price = float.Parse(stringprice);
            //Take in user input for quantity and perform validation.
            Console.WriteLine("Please Enter an Item Quantity");
            string stringquantity = Console.ReadLine();
            while (!ValidateQuantity(stringquantity))
            {
                Console.WriteLine("Please Enter a valid Item Quantity");
                stringquantity = Console.ReadLine();
            }
            int quantity = Convert.ToInt16(stringquantity);
            //Add the item to the list.
            saleItems.Add(new Item(name, price, quantity));
            
        }

        //Regex to ensure no special characters or numbers.
        private Boolean ValidateName(string name)
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");
            if (regexItem.IsMatch(name))
                return true;
            else
                return false;
        }
        //Regex to ensure max 3 digits. max 2 digits float format.
        private Boolean ValidatePrice(string price)
        {
            var regexItem = new Regex("^[0-9]{1,3}.[0-9]{1,2}$");
            if (regexItem.IsMatch(price))
                return true;
            else
                return false;
        }
        //Regex to ensure double digits or less quantity.
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
