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
        enum Modes { Monthly, Weekly };

        string[] fileEntries; 
        List<Item> saleItems;
        DateTime saleTime;

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        public Report(int Mode)
        {
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
            fileEntries = csvManager.selectSetOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);
            
            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this);
        }
    }
}
