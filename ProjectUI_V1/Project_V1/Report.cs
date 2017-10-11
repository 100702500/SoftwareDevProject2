using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V1
{
    public class Report
    {
        enum Modes { Monthly, Weekly, Daily, MonthlyEstimate };

        string userInput;
        List<string> fileEntries; 
        List<Item> saleItems;
        DateTime saleTime;
        Stocks itemstock;
        Random random;

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
            random = new Random();

            if (Mode == (int)Modes.Monthly)
            {
                MonthlyReport();
            }
            if (Mode == (int)Modes.Weekly)
            {
                WeeklyReport();
            }
            if (Mode == (int)Modes.Daily)
            {
                DailyReport();
            }
            if (Mode == (int)Modes.MonthlyEstimate)
            {
                MonthlyEstimate();
            }
        }
        private void WeeklyReport()
        {

            fileEntries = csvManager.selectWeekOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this, 1); 

        }

        private void MonthlyReport()
        {
            fileEntries = csvManager.selectSetOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);
            saleItems = csvManager.condenseitems(saleItems);

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this, 0);
        }

        private void DailyReport()
        {
            List<string> locations = csvManager.selectSetOfFiles();

            float totalsaletotal = 0;

            csvManager.ListFiles(csvManager.selectSetOfFiles());

            userInput = Console.ReadLine();

            foreach (string path in csvManager.selectFilesByDate(userInput, locations))
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

        private void MonthlyEstimate()
        {
            fileEntries = csvManager.selectSetOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);

            List<Item> predictedSales = new List<Item>();

            foreach (Item element in saleItems)
            {
                predictedSales.Add(new Item(element.getProductName(), element.getProductPrice(), PerformEstimateMagic(element.getProductQuantity())));
            }

            saleItems = predictedSales;

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this, 0);
        }

        private int PerformEstimateMagic(int baseQuantity)
        {
            int returnme = 0;
            if (baseQuantity < 11)
            {
                returnme = random.Next(-3, 3) + baseQuantity;
                if (returnme < 0)
                    returnme = 0;
                return returnme;
            }
            else if (baseQuantity < 21)
            {
                returnme = random.Next(-5, 5) + baseQuantity;
                return returnme;
            }
            else if (baseQuantity < 31)
            {
                returnme = random.Next(-6, 6) + baseQuantity;
                return returnme;
            }
            else if (baseQuantity > 30)
            {
                returnme = random.Next(-(baseQuantity / 5), (baseQuantity / 5)) + baseQuantity;
                return returnme;
            }
            else
                return baseQuantity;
        }
    }
}
