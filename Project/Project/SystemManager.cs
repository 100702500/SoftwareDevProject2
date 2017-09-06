using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SystemManager
    {
        SalesRecord ActiveRecord;
        Boolean Loop;
        string userInput;

        public SystemManager()
        {
            Loop = true;
            SystemRun();
        }

        private void SystemRun()
        {
            //Loop over user input.
            while (Loop)
            {
                Console.WriteLine("Menu System");
                Console.WriteLine("     1. Add Record");
                Console.WriteLine("     2. Read Record");
                Console.WriteLine("     3. Quit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            //Go to AddRecord.
                            AddRecord();
                            break;
                        }
                    case "2":
                        {
                            //Go to AddRecord.
                            GetRecord();
                            break;
                        }
                    case "3":
                        {
                            //Break the loop and exit the program.
                            Loop = false;
                            break;
                        }
                }
            }
        }

        private void AddRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Add'
            ActiveRecord = new SalesRecord(0);
        }
        private void GetRecord()
        {
            List<Item> loadedfile = Readitem.loadfile(Readitem.datalocation());
            float saletotal = 0;
            foreach (Item file in loadedfile)
            {
                Console.WriteLine("Printing Record Data");
                Console.WriteLine("-------------------------");
                Console.WriteLine("MISSING SALES TIME");// TODO: Missing sales time
                Console.WriteLine("-------------------------");
                Console.Write("Product Name: ");
                Console.WriteLine(file.getProductName());
                Console.Write("Product Price: ");
                Console.WriteLine(file.getProductPrice());
                Console.Write("Product Quantity: ");
                Console.WriteLine(file.getProductQuantity());
                Console.Write("Product Total: ");
                Console.WriteLine(file.getProductQuantity() * file.getProductPrice());
                Console.WriteLine("-------------------------");
                saletotal += (file.getProductQuantity() * file.getProductPrice());
            }

            Console.Write("Sale Total: ");
            Console.WriteLine(saletotal);
            Console.WriteLine("-------------------------");
        }
       
    }
}
