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
        const char filedelimiter = '\\';
        const string filetype = ".csv";

        public static List<string> verifyCSV(string[] toVerify)
        {
            int count = 0;
            List<string> ToReturn = new List<String>();

            foreach (string filename in toVerify)
            {
                string[] dateArr = filename.Split(filedelimiter);

                if (dateArr[dateArr.Length - 1].Contains(filetype))
                {
                    ToReturn.Add(filename);
                }
                count++;
            }

            return ToReturn;
        }

        public static string getDateFromPath(string location)
        {
            string date;
            string[] datearr = location.Split(filedelimiter);
            date = datearr[datearr.Length - 1].Substring(0, datearr[datearr.Length - 1].Length - filetype.Length);
            return date;
        }

        public static void ListFiles(List<string> list)
        {
            Console.WriteLine("Listed Files");
            int count = 0;
            foreach (string fileName in list)
            {
                Console.WriteLine(count + ": " + getDateFromPath(fileName));
                count++;
            }
        }

        //Select a single file within the current year and month and return it's path.
        public static string selectFile()
        {
            //Scan the directory of the current year and month.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            path += "\\data\\" + currentYear + "\\" + currentMonth;
            string[] fileEntries = Directory.GetFiles(path);
            List<string> csvEntries = verifyCSV(fileEntries);

            //Take user input after displaying all files in the directory.
            string userInput;
            Console.WriteLine("Select a file");
            ListFiles(csvEntries);

            userInput = Console.ReadLine();
            //Return the file selected by the user.
            return csvEntries[Convert.ToInt32(userInput)];
        }

        //Look for all files in the current month folder that are within the last 7 days or the closest monday, and returns them in a list.
        public static List<string> selectWeekOfFiles()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            path += "\\data\\" + currentYear + "\\" + currentMonth;
            string[] fileEntries = Directory.GetFiles(path);
            List<string> allFiles = new List<string>(); 

            foreach (string d in fileEntries)
            {
                allFiles.Add(d);
            }

            int size = fileEntries.Length;
            string date = "";
            string dayOfTheMonth = "";
        
            DateTime myDate;
         
            bool MondayFound = false;
            List<string> output = new List<string>();

            for (int i = 0; i < size; i++)
            {
                if (!MondayFound)
                {
                    date = getDateFromPath(fileEntries[i]);
                    date = SliceDate(date, " ");

                    myDate = DateTime.ParseExact(date, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);

                    dayOfTheMonth = getDateFromPath(fileEntries[i]);
                    dayOfTheMonth = SliceDate(dayOfTheMonth, "-");
                    int firstDayofWeek = Int32.Parse(dayOfTheMonth);

                    string dateNow = DateTime.Now.ToString();
                    dateNow = SliceDate(dateNow, "/");
                    int DayNow = Int32.Parse(dateNow);

                    if (DayNow -firstDayofWeek < 7)
                    { 
                         if (myDate.DayOfWeek == DayOfWeek.Monday)
                         {
                            MondayFound = true;
                         }
                        else
                        {
                            output.Add(fileEntries[i]);
                        }
                    }
                    else
                    {
                        break; 
                    }
                }
                else
                {
                    List<string> mondayFiles = new List<string>();
                    mondayFiles = selectFilesByDate(date, allFiles);
                    foreach (string f in mondayFiles)
                    {
                        output.Add(f); 
                    }
                    break; 
                }

            }
            
            return output; 
        }

        public static string SliceDate (string date, string symbol)
        {
            int DayIndex = date.IndexOf(symbol);
            if (DayIndex > 0)
                date = date.Substring(0, DayIndex);
            return date;
        }

        //Retrieves all the files from the directory of the current year and month, then returns them.
        public static List<string> selectSetOfFiles()
        {
            //Scan the directory of the current year and month.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string currentYear = DateTime.Now.ToString("yyyy");
            string currentMonth = DateTime.Now.ToString("MM");
            path += "\\data\\" + currentYear + "\\" + currentMonth;
            string[] fileEntries = Directory.GetFiles(path);
            List<string> csvEntries = verifyCSV(fileEntries);

            ListFiles(csvEntries);
            //Return all the collected files.
            return csvEntries;
        }

        public static List<string> selectFilesByDate(string condition, List<string> locations)
        {
            string[] test = new string[locations.Count];

            int count = 0;
            foreach (string filename in locations)
            {
                test[count] = getDateFromPath(locations[count]);
                test[count] = test[count].Split(' ')[0];
                count++;
            }
            count = 0;

            List<string> pathresults = new List<string>();
            foreach (string date in test)
            {
                if (date == condition)
                {
                    pathresults.Add(locations[count]);
                }
                count++;
            }
            return pathresults;
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
        public static List<Item> readSetOfFiles(List<String> locations)
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
        public static void writeSalesReport(Report input, int mode)
        {
            //Manage the path where the CSV files should be saved to.
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string createdYear = input.getsaleTime().ToString("yyyy");
            string createdDate = input.getsaleTime().ToString("dd-MM-yyyy h_mm_ss tt");
            if (mode == 0)
            {
                path += "\\data\\" + createdYear + "\\Reports\\" + createdDate + ".csv";
            }
            else if (mode == 1)
            {
                path += "\\data\\" + createdYear + "\\Reports\\Weekly\\" + createdDate + ".csv";
            }
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
