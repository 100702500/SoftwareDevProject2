using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//--- Insert from SalesRecord.cs ---
using System.Text.RegularExpressions;
using System.IO;

namespace Project_V1
{
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        //NEW CODES: 
        string userInput;
        List<string> fileEntries;
        List<Item> saleItems;
        DateTime saleTime;
        Stocks itemstock;
        Random random;

        float saleTotal;

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        /*
         * //Testing New Code: GENERATE REPORT CSV.
        private void WeeklyReport()
        {

            fileEntries = csvManager.selectWeekOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this, 1);

        }

        private void MonthlyReport()
        {
            fileEntries = csvManager.selectSetOfFiles();
            saleItems = csvManager.readSetOfFiles(fileEntries);
            saleItems = csvManager.condenseitems(saleItems);

            saleTime = DateTime.Now;
            csvManager.writeSalesReport(this, 0);
        }

        */


        //Button Events
        private void btn_exit_Click(object sender, EventArgs e)
        {
            //Exit Button
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Returns to MainMenu
            Form_MainMenu formMain = new Form_MainMenu();
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }
        

        private void btn_Weekly_Click(object sender, EventArgs e)
        {
            Stocks s = new Stocks();
            Report r = new Report(0, s);
            r.WeeklyReport();
            lbl_type.Text = "Weekly Report";
            listBox1.Items.Clear();

            List<string> paths = csvManager.selectSetOfFiles_ReportWeek();
            List<string> dates = new List<string>();


            foreach (string p in paths)
            {
                dates.Add(csvManager.getDateFromPath(p));
            }

            dates = csvManager.condensestring(dates);

            foreach (string p in dates)
            {
                listBox1.Items.Add(p);
            }
        }

        private void btn_Montly_Click(object sender, EventArgs e)
        {
            Stocks s = new Stocks();
            Report r = new Report(0, s);
            r.MonthlyReport();
            lbl_type.Text = "Monthly Report";
            listBox1.Items.Clear();

            List<string> paths = csvManager.selectSetOfFiles_ReportMonth();
            List<string> dates = new List<string>();


            foreach (string p in paths)
            {
                dates.Add(csvManager.getDateFromPath(p));
            }

            dates = csvManager.condensestring(dates);

            foreach (string p in dates)
            {
                listBox1.Items.Add(p);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stat = lbl_type.Text;
            listBox2.Items.Clear();
            if (stat.Contains("Monthly"))
            {
                ReadRecord_Month(listBox1.SelectedItem.ToString());
            }

            if (stat.Contains("Weekly"))
            {
                ReadRecord_Week(listBox1.SelectedItem.ToString());
            }
        }

        private void ReadRecord_Month(string path)
        {
            string files = csvManager.selectFileByDate(path, csvManager.selectSetOfFiles_ReportMonth());
          saleItems = csvManager.readSingleFile(files);
          PrintRecord();
        }

        private void ReadRecord_Week(string path)
        {
            string files = csvManager.selectFileByDate(path, csvManager.selectSetOfFiles_ReportWeek());
            saleItems = csvManager.readSingleFile(files);
            PrintRecord();
        }

        private void PrintRecord()
        {
            saleTotal = 0;
            foreach (Item element in saleItems)
            {
                saleTotal += element.getTotalCost();
            }

            listBox2.Items.Add(saleTime);
            listBox2.Items.Add("----------");
            foreach (Item element in saleItems)
            {
                listBox2.Items.Add("Product Name: ");
                listBox2.Items.Add(element.getProductName());
                listBox2.Items.Add("Product Price: ");
                listBox2.Items.Add(element.getProductPrice());
                listBox2.Items.Add("Product Quantity: ");
                listBox2.Items.Add(element.getProductQuantity());
                listBox2.Items.Add("Product Total: ");
                listBox2.Items.Add(element.getProductQuantity() * element.getProductPrice());
                listBox2.Items.Add("-------------------------");
            }

            listBox2.Items.Add("Sale Total: ");
            listBox2.Items.Add(saleTotal);
            listBox2.Items.Add("-------------------------");


        }

    }
}
