using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Project
{
    class SystemManager
    {
        SalesRecord ActiveRecord;
        Report ActiveReport;
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
                Console.WriteLine("     3. Read Records at a Date");
                Console.WriteLine("     4. Edit Record");
                Console.WriteLine("     5. Monthly Report");
                Console.WriteLine("     6. Quit");

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
                            //Go to GetRecord.
                            GetRecord();
                            break;
                        }
                    case "3":
                        {
                            AllRecordsofdate();
                            break;
                        }
                    case "4":
                        {
                            //Go to Edit Record
                            EditRecord();
                            break;
                        }
                    case "5":
                        {
                            MonthlyReport();
                            break;
                        }
                    case "6":
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
            //Declare a new Sales Record object and set it's mode to 'Read'
            ActiveRecord = new SalesRecord(1);     
        }

        private void EditRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Edit'
            ActiveRecord = new SalesRecord(2);
        }

        private void MonthlyReport()
        {
            //Declare a new Report and set it's mode to monthly.
            ActiveReport = new Report(0);
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
    }
}
