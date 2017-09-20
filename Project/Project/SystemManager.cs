using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

//remove was for testing get by date
using System.IO;


=======
//Added line for merge fix
>>>>>>> refs/remotes/origin/master
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
                Console.WriteLine("     3. Read Record of a date");
                Console.WriteLine("     4. Quit");
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
                            //Go to .
                            GetRecord();
                            break;
                        }
                    case "3":
                        {
                            //Go to .
                            AllRecordsofdate();
                            break;
                        }
                    case "4":
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
<<<<<<< HEAD
            string location = Readitem.datalocation();
            List<Item> loadedfile = Readitem.loadfile(location);
            float saletotal = 0;
            foreach (Item file in loadedfile)
            {
                Console.WriteLine("Printing Record Data");
                Console.WriteLine("-------------------------");
                Console.WriteLine(Readitem.getdatadate(location));
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
        private void AllRecordsofdate()
        {

            // is to get a date
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string[] fileEntries = Directory.GetFiles(path);
            string userInput;

            Console.WriteLine("Select Files");
            int count = 0;
            foreach (string fileName in fileEntries)
            {
                Console.WriteLine(count + ": " + fileName);
                count++;
            }
            //

            float totalsaletotal = 0;
            userInput = Console.ReadLine();
            foreach (string locpath in Readitem.groupsitemsbydate(userInput)) {
                List<Item> loadedfile = Readitem.loadfile(locpath);
                float saletotal = 0;
                foreach (Item file in loadedfile)
                {
                    Console.WriteLine("Printing Record Data");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine(Readitem.getdatadate(locpath));
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
                totalsaletotal += saletotal;
                Console.WriteLine("-------------------------");
            };
            Console.Write("Total Day Sale Total: ");
            Console.WriteLine(totalsaletotal);
            Console.WriteLine("-------------------------");
        }
=======
            ActiveRecord = new SalesRecord(1);     
        }
>>>>>>> refs/remotes/origin/master
    }
}
