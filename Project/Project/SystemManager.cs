﻿using System;
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
                Console.WriteLine("     6. Weekly Report");
                Console.WriteLine("     7. Monthly Estimate");
                Console.WriteLine("     8. Weekly Estimate");
                Console.WriteLine("     9. Monthly Group Estimate");
                Console.WriteLine("     10. Quit");

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
                            WeeklyReport();
                            break;
                        }
                    case "7":
                        {
                            //Break the loop and exit the program.
                            MonthlyEstimateReport();
                            break;
                        }
                    case "9":
                        {
                            MonthlyGroupEstimateReport();
                            break;
                        }
                    case "8":
                        {
                            //Break the loop and exit the program.
                            WeeklyEstimateReport();
                            break;
                        }
                    case "10":
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
        private void WeeklyReport()
        {
            //Declare a new Report and set it's mode to meekly.
            ActiveReport = new Report(1, stock); 
        }

        private void DailyReport()
        {
            ActiveReport = new Report(2, stock);
        }

        private void MonthlyEstimateReport()
        {
            ActiveReport = new Report(3, stock);
        }

        private void MonthlyGroupEstimateReport()
        {
            ActiveReport = new Report(5, stock);
        }

        private void WeeklyEstimateReport()

        {
            ActiveReport = new Report(4, stock);
        }
    }
}
