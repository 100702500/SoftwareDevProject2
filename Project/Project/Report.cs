using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Report
    {
        enum Modes { Monthly, Weekly };

        string[] fileEntries; 
        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;

        Boolean Loop;
        string userInput;

        public Report(int Mode)
        {
            Loop = true;
            saleItems = new List<Item>();

            if (Mode == (int)Modes.Monthly)
            {
                MonthlyReport();
            }
            if (Mode == (int)Modes.Weekly)
            {

            }
        }

        private void MonthlyReport()
        {
            GetFiles();


            string line;
            int counter = 0;
            string headerLine;
            System.IO.StreamReader file;
            string[] details;
            Item record;

            foreach (string element in fileEntries)
            {
                file = new System.IO.StreamReader(element);
                headerLine = file.ReadLine();

                while ((line = file.ReadLine()) != null)
                {
                    details = line.Split(',');
                    record = new Item(details[0], float.Parse(details[1]), int.Parse(details[2]));
                    saleItems.Add(record);
                    counter++;
                }
                file.Close();
            }

            saleTime = DateTime.Now;
            CalculateTotalSale();

            writeRecord();
        }

        private void CalculateTotalSale()
        {
            saleTotal = 0;
            foreach (Item element in saleItems)
            {   
                saleTotal += (element.getProductPrice() * element.getProductQuantity());
            }
        }

        private void GetFiles()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");

            path += "\\data\\" + currentYear + "\\" + currentMonth;

            fileEntries = Directory.GetFiles(path);
        }

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
    }
}
