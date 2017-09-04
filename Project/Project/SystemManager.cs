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
                Console.WriteLine("This is test text, speak back to me;");
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
            }
        }

        private void AddRecord()
        {

        }
    }
}
