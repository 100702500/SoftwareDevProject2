using System;
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
        enum Modes {Add, Read, Edit};

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
            if (Mode == (int)Modes.Read)
            {
                ReadRecord();
            }
            if (Mode == (int)Modes.Edit)
            {
                EditRecord();
            }
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

        //Takes the whole record and writes it to a CSV file in the desktop.
        private void writeRecord()
        {
            //Manage the path where the CSV files should be saved to.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string createdYear = saleTime.ToString("yyyy");
            string createdMonth = saleTime.ToString("MM");
            string createdDate = saleTime.ToString("dd-MM-yyyy h_mm_ss tt");
            path += "\\data\\" + createdYear + "\\" + createdMonth + "\\" + createdDate + ".csv";
            Console.WriteLine("Saved at: " + path);

            //Create an array of an array of strings made of the records contents.
            int length = saleItems.Count + 1;
            string[][] record = new string[length][];
            record[0] = new string[] { "Product Name", "Product Price", "Product Quantity" };
            for (int i = 1; i < length; i++)
            {
                record[i] = new string[] { saleItems[i - 1].getProductName(), saleItems[i - 1].getProductPrice().ToString(), saleItems[i - 1].getProductQuantity().ToString() };
            }

            //Add , in order to produce a csv file format.
            string delimiter = ",";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.AppendLine(string.Join(delimiter, record[i]));
            }

            //Write to the file.
            File.WriteAllText(path, sb.ToString());
        }

        //Calculates a new total sale based on the list of items.
        private void CalculateTotalSale()
        {
            saleTotal = 0;
            foreach (Item element in saleItems)
            {
                saleTotal += (element.getProductPrice() * element.getProductQuantity());
            }
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
                            CalculateTotalSale();
                            writeRecord();
                            break;
                        }                     
                }
            }
        }

        //Reads in the record, adds the sale date, 
        private void ReadRecord()
        {
            string path = readItem.datalocation();
            saleItems = readItem.loadfile(path);

            FileNameToDate(path);
            CalculateTotalSale();
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
                CalculateTotalSale();
                PrintRecord();
            }
            //Write the changes to file once the record is completed.
            writeRecord();
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
