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
    public static class readItem
    {
        const char delimiter = ',';

        /// <summary>
        /// get file location of specified date
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
        /// return array of items matching clause
        /// </summary>
        /// <param name="conditioncolumn">which column will be </param>
        /// <param name="condition">a condition to be checked</param>
        public static void searchforitem(int conditioncolumn/*, condition*/)
        {
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