using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (Item element in saleItems)
            {
                Console.Write("Product Name: ");
                Console.WriteLine(element.getProductName());
                Console.Write("Product Price: ");
                Console.WriteLine(element.getProductPrice());
            }
            Console.Write("Totals To: ");
            Console.WriteLine(saleTotal);
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
                                saleTotal += element.getProductPrice();
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

            Console.WriteLine("Please Enter an Item Price");
            float price = float.Parse(Console.ReadLine());

            saleItems.Add(new Item(name, price));
        }
    }
}
