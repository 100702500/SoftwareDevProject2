using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    //static
    public static class Readitem
    {
        const char delimiter = ',';
        const char filedelimiter = '\\';
        const string filetype = ".csv";

        /// <summary>
        /// get file location of a specified file
        /// </summary>
        public static string datalocation()
        {
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
            userInput = Console.ReadLine();
            return fileEntries[Convert.ToInt32(userInput)];
        }
        /// <summary>
        /// gets the date of a file
        /// assumption that file is of specified format
        /// TODO: add a try throw exception for if file is failed
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public static string getdatadate(string location)
        {
            string date;
            string[] datearr = location.Split(filedelimiter);
            date = datearr[datearr.Length-1].Substring(0, datearr[datearr.Length - 1].Length - filetype.Length);
            return date;
        }
        public static Boolean filetypecheck(string location)
        {
            string[] datearr = location.Split(filedelimiter);
            return datearr[datearr.Length - 1].Contains(filetype);
        }

        /// <summary>
        /// returns sale record
        /// </summary>
        /// <param name="location"></param>
        public static List<Item> loadfile(string location)
        {
            List<Item> saleItems = new List<Item>();

            string line;
            int counter = 0;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(location);
            string headerLine = file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {
                string[] details = line.Split(delimiter);
                Item record = new Item(details[0], float.Parse(details[1]), int.Parse(details[2]));
                saleItems.Add(record);
                counter++;
            }
            file.Close();
            return saleItems;
        }

        /// <summary>
        /// return array of items matching date
        /// </summary>
        /// <param name="condition">a condition to be checked</param> //TODO:Validate
        public static List<string> groupsitemsbydate(string condition)
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string[] fileEntries = Directory.GetFiles(path);
            string[] dates = new string[fileEntries.Length];
            int count = 0;
            foreach (string filename in fileEntries)
            {
                if (filetypecheck(filename))
                {
                    dates[count] = getdatadate(filename);
                }
                count++;
            }
            count = 0;

            foreach (string date in dates)
            {
                if (date != null)
                {
                    dates[count] = date.Split(' ')[0];
                }
                count++;
            }
            count = 0;
            List<string> pathresults = new List<string>();
            foreach (string date in dates)
            {
                if (date == condition)
                {
                    pathresults.Add(fileEntries[count]);
                }
                count++;
            }
            return pathresults;
            //a = list of sales record
            //for all files in path = c
            //x = loadfile(c)
            //a.add(x.search);
        }

        //get file location
        //get file data
        //search file for items based on condtion
    }
}