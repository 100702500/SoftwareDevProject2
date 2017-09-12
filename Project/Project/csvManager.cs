using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class csvManager
    {
        const char delimiter = ',';

        //Select a single file within the current year and month and return it's path.
        public static string selectFile()
        {
            //Scan the directory of the current year and month.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            path += "\\data\\" + currentYear + "\\" + currentMonth;
            string[] fileEntries = Directory.GetFiles(path);
            //Take user input after displaying all files in the directory.
            string userInput;
            Console.WriteLine("Select Files");
            int count = 0;
            foreach (string fileName in fileEntries)
            {
                Console.WriteLine(count + ": " + fileName);
                count++;
            }
            userInput = Console.ReadLine();
            //Return the file selected by the user.
            return fileEntries[Convert.ToInt32(userInput)];
        }

        //Retrieves all the files from the directory of the current year and month, then returns them.
        public static string[] selectSetOfFiles()
        {
            //Scan the directory of the current year and month.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            path += "\\data\\" + currentYear + "\\" + currentMonth;
            string[] fileEntries = Directory.GetFiles(path);
            //Return all the collected files.
            return fileEntries;
        }

        //Receives a path location and then reads the content of that CSV into saleItems and returns it.
        public static List<Item> readSingleFile(string location)
        {
            List<Item> saleItems = new List<Item>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(location);
            //Skip the header line
            string headerLine = file.ReadLine();
            //Read the contents of the file into saleItems until EoF is reached.
            while ((line = file.ReadLine()) != null)
            {
                string[] details = line.Split(delimiter);
                Item record = new Item(details[0], float.Parse(details[1]), int.Parse(details[2]));
                saleItems.Add(record);
            }
            file.Close();
            //Return the extracted items from the CSV file.
            return saleItems;
        }

        //Receives a set of path locations and reads their content into saleItems and returns it.
        public static List<Item> readSetOfFiles(string[] locations)
        {
            List<Item> saleItems = new List<Item>();
            string line;
            string headerLine;
            System.IO.StreamReader file;
            string[] details;
            Item record;
            bool sameitemflag;

            //For each file, do the following.
            foreach (string element in locations)
            {
                file = new System.IO.StreamReader(element);
                //Skip the header line.
                headerLine = file.ReadLine();
                //Read the contents of the file into saleItems until EoF is reached.
                while ((line = file.ReadLine()) != null)
                {
                    details = line.Split(delimiter);
                    record = new Item(details[0], float.Parse(details[1]), int.Parse(details[2]));
                    sameitemflag = false;
                    //Check if the new item name is unique.
                    foreach (Item Element in saleItems)
                    {
                        //If it isn't, add quantities rather than adding the entire new item.
                        if (record.getProductName() == Element.getProductName())
                        {
                            Element.addQuantity(record.getProductQuantity());
                            sameitemflag = true;
                        }
                    }
                    //If item is unique, add it to the list.
                    if (!sameitemflag)
                        saleItems.Add(record);
                }
                file.Close();
            }
            //Return the combined totals for the items across all the given files.
            return saleItems;
        }

        //Writes a CSV file to the current year and month folder.
        public static void writeSalesRecord(SalesRecord input)
        {
            //Manage the path where the CSV files should be saved to.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string createdYear = input.getsaleTime().ToString("yyyy");
            string createdMonth = input.getsaleTime().ToString("MM");
            string createdDate = input.getsaleTime().ToString("dd-MM-yyyy h_mm_ss tt");
            path += "\\data\\" + createdYear + "\\" + createdMonth + "\\" + createdDate + ".csv";
            Console.WriteLine("Saved at: " + path);
            //Create an array of an array of strings made of the records contents.
            int length = input.getsaleItems().Count + 1;
            string[][] record = new string[length][];
            record[0] = new string[] { "Product Name", "Product Price", "Product Quantity" };
            for (int i = 1; i < length; i++)
            {
                record[i] = new string[] { input.getsaleItems()[i - 1].getProductName(), input.getsaleItems()[i - 1].getProductPrice().ToString(), input.getsaleItems()[i - 1].getProductQuantity().ToString() };
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

        //Writes a CSV file to the Reports folder.
        public static void writeSalesReport(Report input)
        {
            //Manage the path where the CSV files should be saved to.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string createdYear = input.getsaleTime().ToString("yyyy");
            string createdDate = input.getsaleTime().ToString("dd-MM-yyyy h_mm_ss tt");
            path += "\\data\\" + createdYear + "\\Reports\\" + createdDate + ".csv";
            Console.WriteLine("Saved at: " + path);
            //Create an array of an array of strings made of the records contents.
            int length = input.getsaleItems().Count + 1;
            string[][] record = new string[length][];
            record[0] = new string[] { "Product Name", "Product Price", "Product Quantity" };
            for (int i = 1; i < length; i++)
            {
                record[i] = new string[] { input.getsaleItems()[i - 1].getProductName(), input.getsaleItems()[i - 1].getProductPrice().ToString(), input.getsaleItems()[i - 1].getProductQuantity().ToString() };
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
