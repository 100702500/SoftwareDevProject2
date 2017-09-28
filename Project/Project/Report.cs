using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Report
    {
        enum Modes { Monthly, Weekly, Daily };

        string userInput;
        List<string> fileEntries; 
        List<Item> saleItems;
        DateTime saleTime;
        Stocks itemstock;

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        public Report(int Mode, Stocks stock)
        {
            itemstock = stock;
            saleItems = new List<Item>();

            if (Mode == (int)Modes.Monthly)
            {
                MonthlyReport();
            }
            if (Mode == (int)Modes.Weekly)
            {

            }
            if (Mode == (int)Modes.Daily)
            {
                DailyReport();
            }
        }

        private void MonthlyReport()
        {
            fileEntries = csvManager.selectSetOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);
            saleItems = csvManager.condenseitems(saleItems);

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this);
        }

        private void DailyReport()
        {
            List<string> locations = csvManager.selectSetOfFiles();

            float totalsaletotal = 0;

            csvManager.ListFiles(csvManager.selectSetOfFiles());

            userInput = Console.ReadLine();

            foreach (string path in csvManager.selectFilesByDate(userInput, locations))
            //foreach (string path in Readitem.groupsitemsbydate(userInput))
            {
                List<Item> loadedfile = csvManager.readSingleFile(path);
                float saletotal = 0;

                foreach (Item file in loadedfile)
                {
                    Console.WriteLine("Printing Record Data");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine(csvManager.getDateFromPath(path));
                    Console.WriteLine("-------------------------");
                    Console.Write("Product ID: ");
                    Console.WriteLine(file.getProductName());
                    Console.Write("Product Name: ");
                    Console.WriteLine(itemstock.getNameofitemID(file.getProductName()));
                    Console.Write("Product Group: ");
                    Console.WriteLine(itemstock.getgroupofitemID(file.getProductName()));
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
