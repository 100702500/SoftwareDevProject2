using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class SystemManager
    {
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
                Console.WriteLine("     3. Edit Record");
                Console.WriteLine("     4. Monthly Report");
                Console.WriteLine("     5. Quit");
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
                            //Go to Edit Record
                            EditRecord();
                            break;
                        }
                    case "4":
                        {
                            MonthlyReport();
                            break;
                        }
                    case "5":
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
            ActiveRecord = new SalesRecord(0);
        }

        private void GetRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Read'
            ActiveRecord = new SalesRecord(1);     
        }

        private void EditRecord()
        {
            //Declare a new Sales Record object and set it's mode to 'Edit'
            ActiveRecord = new SalesRecord(2);
        }

        private void MonthlyReport()
        {
            //Declare a new Report and set it's mode to monthly.
            ActiveReport = new Report(0);
        }
    }
}
