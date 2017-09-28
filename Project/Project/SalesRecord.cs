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
        Stocks itemstock;

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
        public SalesRecord(int Mode, Stocks stock)
        {
            itemstock = stock;
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

        /// <summary>
        /// Regex to ensure no special characters or numbers.
        /// </summary>
        /// <returns></returns>
        
        private bool ValidateBarcode(string name)
        {
            var regexItem = new Regex("^d +$");
            bool isValid = false;
            
            if (regexItem.IsMatch(name))
                isValid = true;

            if (itemstock.contains(Stocks.fields.barcode, name))
                isValid = true;

            return isValid;
        }

        //Regex to ensure max 3 digits. max 2 digits float format.
        
        private bool ValidatePrice(float price)
        {
            var regexItem = new Regex("^[0-9]{1,3}.[0-9]{1,2}$");
            bool isValid = false;

            if (regexItem.IsMatch(price.ToString()))
                isValid = true;

            return isValid;
        }

        //Regex to ensure double digits or less quantity.
        /// string name, float price, int qty
        private bool ValidateQuantity(int qty)
        {
            var regexItem = new Regex("^[0-9]{1,2}$");
            bool isValid = false;

            if (regexItem.IsMatch(qty.ToString()))
                isValid = true;

            return isValid;
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
                            string a = Console.ReadLine();
                            float b = float.Parse(Console.ReadLine());
                            int c = int.Parse(Console.ReadLine());
                            try
                            {
                                AddItem(a, b, c);
                            }
                            catch (Exception)
                            {

                                throw;
                            }
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
                            //is not validated
                            string a = Console.ReadLine();
                            float b = float.Parse(Console.ReadLine());
                            int c = int.Parse(Console.ReadLine());
                            try
                            {
                                AddItem(a,b,c);
                            }
                            catch (Exception)
                            {
                                //try again
                                throw;
                            }
                            break;
                        }
                    default:
                        {
                            //Other, therefore edit the selected item.
                            try
                            {
                                EditItem(saleItems[Convert.ToInt32(userInput) - 2], Convert.ToInt32(userInput) - 2);
                            }
                            catch (Exception)
                            {
                                //try again
                                throw;
                            }
                            
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
        private void AddItem(string name, float price, int qty)
        {
            if (ValidateBarcode(name) && ValidatePrice(price) && ValidateQuantity(qty))
            {
                saleItems.Add(new Item(name, price, qty));
            }
            else
            {
                throw new Exception("Name or Price or Qty is not valid");
            }
            
        }

        private void EditItem(Item item, int index)
        {
            bool isvalid = false;
            Console.WriteLine("Item Barcode: " + item.getProductName());

            Console.WriteLine("Item Price: " + item.getProductPrice());

            Console.WriteLine("Item Quantity: " + item.getProductQuantity());
            //Take in user input for price and perform validation.

            float price = float.Parse(Console.ReadLine());
            if (ValidatePrice(price))
            {
                isvalid = true;
            }
            else
            {
                throw new Exception("Price Not valid");
            }

            int qty = int.Parse(Console.ReadLine());
            if (ValidateQuantity(qty))
            {
                isvalid = true;
            }
            else
            {
                throw new Exception("qty Not valid");
            }
            if (isvalid)
            {
                saleItems[index] = new Item(item.getProductName(), price, qty);
            }
        }     
    }
}
