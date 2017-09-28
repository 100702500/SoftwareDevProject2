using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Project
{
    class SystemManager
    {
        Stocks stock = new Stocks();
        SalesRecord ActiveRecord;
        Report ActiveReport;
        Boolean Loop;
        string userInput;

        public SystemManager()
        {
            Loop = true;
            SystemRun();
        }

        private void SystemRun()
        {
            //Loop over user input.
            while (Loop)
            {
                Console.WriteLine("Menu System");
                Console.WriteLine("     1. Add Record");
                Console.WriteLine("     2. Read Record");
                Console.WriteLine("     3. Read Records at a Date");
                Console.WriteLine("     4. Edit Record");
                Console.WriteLine("     5. Monthly Report");
                Console.WriteLine("     6. Quit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            //Go to AddRecord.
                            AddRecord();
                            break;
                        }
                    case "2":
                        {
                            //Go to GetRecord.
                            GetRecord();
                            break;
                        }
                    case "3":
                        {
                            DailyReport();
                            break;
                        }
                    case "4":
                        {
                            //Go to Edit Record
                            EditRecord();
                            break;
                        }
                    case "5":
                        {
                            MonthlyReport();
                            break;
                        }
                    case "6":
                        {
                            //Break the loop and exit the program.
                            Loop = false;
                            break;
                        }
                }
            }
        }

        private void AddRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Add'
            ActiveRecord = new SalesRecord(0, stock);
        }

        private void GetRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Read'
            ActiveRecord = new SalesRecord(1, stock);     
        }

        private void EditRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Edit'
            ActiveRecord = new SalesRecord(2, stock);
        }

        private void MonthlyReport()
        {
            //Declare a new Report and set it's mode to monthly.
            ActiveReport = new Report(0, stock);
        }

        private void DailyReport()
        {
            ActiveReport = new Report(2, stock);
        }
    }
}
