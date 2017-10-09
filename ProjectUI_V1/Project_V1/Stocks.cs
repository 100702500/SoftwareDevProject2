using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_V1
{
    
    public class Stocks
    {
        private List<String[]> itemlist;
        const char delimiter = ',';

        public String getItemBarcode(int at)
        {
            return itemlist.ElementAt(at)[0];
        }
        public String getItemName(int at)
        {
            return itemlist.ElementAt(at)[1];
        }
        public String getItemGroup(int at)
        {
            return itemlist.ElementAt(at)[2];
        }
        public String getItemPrice(int at)
        {
            return itemlist.ElementAt(at)[3];
        }
        public String getItemQty(int at)
        {
            return itemlist.ElementAt(at)[4];
        }
        public List<String> getitemgroups()
        {
            List<String> groups = new List<String>(); 
            //get all unique groups
            foreach (string[] str in itemlist)
            {
                if (!groups.Contains(str[2]))
                {
                    groups.Add(str[2]);
                }
            }
            return groups;
        }
        public List<String> getitemsIDofgroup(string group)
        {
            List<String> items = new List<String>();
            //get all unique groups
            foreach (string[] str in itemlist)
            {
                if (str[2] == group)
                {
                    items.Add(str[1]);
                }
            }
            return items;
        }
        public String getgroupofitemID(string ID)
        {
            String group = "";
            //get all unique groups
            foreach (string[] str in itemlist)
            {
                if (str[0] == ID)
                {
                    group = str[2];
                    break;
                }
            }
            return group;
        }
        public String getNameofitemID(string ID)
        {
            String group = "";
            //get all unique groups
            foreach (string[] str in itemlist)
            {
                if (str[0] == ID)
                {
                    group = str[1];
                    break;
                }
            }
            return group;
        }
        public enum fields
        {
            barcode,
            name,
            group,
            price,
            qty
        }


        /// <summary>
        /// FIXME: defaults to 0
        /// </summary>
        /// <param name="f"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool contains(fields f, string item)
        {
            bool result = false;
            switch (f)
            {
                case fields.barcode:
                    foreach (string[] line in itemlist)
                    {
                        if (line[0] == item)
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
                case fields.name:
                    foreach (string[] line in itemlist)
                    {
                        if (line[1] == item)
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
                case fields.group:
                    foreach (string[] line in itemlist)
                    {
                        if (line[2] == item)
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
                case fields.price:
                    foreach (string[] line in itemlist)
                    {
                        if (line[3] == item)
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
                case fields.qty:
                    foreach (string[] line in itemlist)
                    {
                        if (line[4] == item)
                        {
                            result = true;
                            break;
                        }
                    }
                    break;
                default:
                    result = false;
                    break;
            }
            return result;
        }


        public Stocks ()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            path += "\\data\\ITEMS.csv";

            itemlist = getitems(path);
        }
        private List<String[]> getitems(string location)
        {
            List<String[]> allstock = new List<String[]>();
            string line;
            StreamReader file = new StreamReader(location);
            //Skip the header line
            string headerLine = file.ReadLine();
            //Read the contents of the file into saleItems until EoF is reached.
            while ((line = file.ReadLine()) != null)
            {
                string[] details = line.Split(delimiter);
                String[] curritem = new string[] { details[0], details[1], details[2], details[3] };
                allstock.Add(curritem);
            }
            file.Close();
            //Return the extracted items from the CSV file.
            return allstock;
        }
    }
}
