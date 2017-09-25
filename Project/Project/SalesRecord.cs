using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Project
{
    public class SalesRecord
    {
        enum Modes {Add, Read, Edit};

        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;

        Boolean Loop;
        string userInput;

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }


        //Constructor, selects a method based on the Mode that was passed in.
        public SalesRecord(int Mode)
        {
            Loop = true;
            saleItems = new List<Item>();

            if (Mode == (int)Modes.Add)
            {
                AddRecord();
            }
            if (Mode == (int)Modes.Read)
            {
                ReadRecord();
            }
            if (Mode == (int)Modes.Edit)
            {
                EditRecord();
            }
        }

        //Calculates the total sale cost and then prints the record.
        private void PrintRecord()
        {
            saleTotal = 0;
            foreach (Item element in saleItems)
            {
                saleTotal += element.getTotalCost();
            }

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

        //Extracts the file name from a given path via replace operations.
        private void FileNameToDate(string path)
        {
            string date = Path.GetFileName(path);
            date = date.Replace("-", "/");
            date = date.Replace("_", ":");
            date = date.Replace(".csv", "");
            saleTime = Convert.ToDateTime(date);
        }

        //Regex to ensure no special characters or numbers.
        private string ValidateName()
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");
            bool isNotValid = true;

            Console.WriteLine("Please Enter an Item Name:");
            userInput = Console.ReadLine();

            if (regexItem.IsMatch(userInput))
                isNotValid = false;

            while (isNotValid)
            {
                Console.WriteLine("Please Enter a valid Item Name:");
                userInput = Console.ReadLine();
                if (regexItem.IsMatch(userInput))
                    isNotValid = false;
            }

            return userInput;
        }

        //Regex to ensure max 3 digits. max 2 digits float format.
        private float ValidatePrice()
        {
            var regexItem = new Regex("^[0-9]{1,3}.[0-9]{1,2}$");
            bool isNotValid = true;

            Console.WriteLine("Please Enter an Item Price");
            userInput = Console.ReadLine();
            if (regexItem.IsMatch(userInput))
                isNotValid = false;

            while (isNotValid)
            {
                Console.WriteLine("Please Enter a valid Item Price:");
                userInput = Console.ReadLine();
                if (regexItem.IsMatch(userInput))
                    isNotValid = false;
            }
            float price = float.Parse(userInput);
            return price;
        }

        //Regex to ensure double digits or less quantity.
        private int ValidateQuantity()
        {
            var regexItem = new Regex("^[0-9]{1,2}$");
            bool isNotValid = true;

            Console.WriteLine("Please Enter an Item Quantity");
            userInput = Console.ReadLine();
            if (regexItem.IsMatch(userInput))
                isNotValid = false;

            while (isNotValid)
            {
                Console.WriteLine("Please Enter a valid Item Quantity");
                userInput = Console.ReadLine();
                if (regexItem.IsMatch(userInput))
                    isNotValid = false;
            }
            int quantity = Convert.ToInt16(userInput);
            return quantity;
        }

        //Add Record interface.
        private void AddRecord()
        {
            Console.WriteLine("ADD RECORD");

            //Loop over user input.
            while (Loop)
            {
                Console.WriteLine("     1. Add Item");
                Console.WriteLine("     2. Print Record");
                Console.WriteLine("     3. Complete Record");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            //If User selected Add Item, begin the method.
                            AddItem();
                            break;
                        }
                    case "2":
                        {
                            //Print the completed Record.
                            PrintRecord();
                            break;
                        }
                    case "3":
                        {
                            //If user selected Complete Record, write the record and end the loop.
                            Loop = false;
                            saleTime = DateTime.Now;
                            csvManager.writeSalesRecord(this);
                            break;
                        }                     
                }
            }
        }

        //Reads in the record, adds the sale date, 
        private void ReadRecord()
        {
            string path = csvManager.selectFile();
            saleItems = csvManager.readSingleFile(path);
            FileNameToDate(path);
            PrintRecord();
        }

        //Reads in the record information then allows for editing.
        private void EditRecord()
        {
            ReadRecord();
            
            while (Loop)
            {
                //Writes out all the contents available for editing.
                Console.WriteLine("Select an item to edit");
                Console.WriteLine("0: Complete Record");
                Console.WriteLine("1: Add New Item");
                int count = 2;
                foreach (Item element in saleItems)
                {
                    Console.WriteLine(count + ": " + element.getProductName());
                    count++;
                }
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        {
                            //Complete the edit.
                            Loop = false;
                            break;
                        }
                    case "1":
                        {
                            //Add a new item to the Record.
                            AddItem();
                            break;
                        }
                    default:
                        {
                            //Other, therefore edit the selected item.
                            EditItem(saleItems[Convert.ToInt32(userInput) - 2], Convert.ToInt32(userInput) - 2);
                            break;
                        }
                }
                //Recalculate the total amount and print the changes to console.
                PrintRecord();
            }
            //Write the changes to file once the record is completed.
            csvManager.writeSalesRecord(this);
        }

        //Add invidvidual items to the sales record.
        private void AddItem()
        {
            //Take in user input for name and perform validation.
            string name = ValidateName();
            //Take in user input for price and perform validation.
            float price = ValidatePrice();
            //Take in user input for quantity and perform validation.
            int quantity = ValidateQuantity();
            //Add the item to the list.
            saleItems.Add(new Item(name, price, quantity));
        }

        private void EditItem(Item item, int index)
        {
            Console.WriteLine("Item Name: " + item.getProductName());

            Console.WriteLine("Item Price: " + item.getProductPrice());
            //Take in user input for price and perform validation.
            float price = ValidatePrice();
            Console.WriteLine("Item Quantity: " + item.getProductQuantity());
            //Take in user input for quantity and perform validation.
            int quantity = ValidateQuantity();

            saleItems[index] = new Item(item.getProductName(), price, quantity);
        }     
    }
}
