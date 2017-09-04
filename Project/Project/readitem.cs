using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace Project
{
    //static
    public class PHP_f_read
    {
        const char delimiter = ',';
        public PHP_f_read()
        {
        }

        /// <summary>
        /// get file location of specified date
        /// </summary>
        public string datalocation(string date)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            path += "\\" + date + ".csv";
            return path;
        }

        /// <summary>
        /// returns sale record
        /// </summary>
        /// <param name="location"></param>
        public List<Item> loadfile(string location)
        {
            List<Item> saleItems = new List<Item>();
            
            string line;
            int counter = 0;
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(location);
            while ((line = file.ReadLine()) != null)
            {
                string[] details = line.Split(delimiter);
                Item record = new Item(details[0], float.Parse(details[1]), int.Parse(details[2]));
                saleItems.Add(record);

                Console.WriteLine(line);
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
        public void searchforitem(int conditioncolumn/*, condition*/)
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