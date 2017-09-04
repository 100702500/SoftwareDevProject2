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
        Boolean Loop;
        string userInput;

        public SystemManager()
        {
            Loop = true;
            SystemRun();
        }

        private void SystemRun()
        {
            while (Loop)
            {
                Console.WriteLine("Menu System");
                Console.WriteLine("     1. Add Record");
                Console.WriteLine("     2. Quit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        {
                            AddRecord();
                            break;
                        }
                    case "2":
                        {
                            Loop = false;
                            break;
                        }
                }
            }
        }

        private void AddRecord()
        {
            ActiveRecord = new SalesRecord(0);
        }
    }
}
