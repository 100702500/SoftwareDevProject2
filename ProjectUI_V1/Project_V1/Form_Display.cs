using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// -- Testing new coode ---
using System.Text.RegularExpressions;
using System.IO;


namespace Project_V1
{
    public partial class Form_Display : Form
    {
        public Form_Display()
        {
            InitializeComponent();

            IniMonthYearBox();
        }


        // --- Testing new code ---
        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;

        private void IniMonthYearBox()
        {
            
            /*
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            */
            comboBox1.Items.Add("10");
            /*
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox2.Items.Add("2016");
            */
            comboBox2.Items.Add("2017");

        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        private void ReadRecord(string path)
        {

            List<string> files = csvManager.selectFilesByDate(path, csvManager.selectSetOfFiles());
            saleItems = csvManager.readSetOfFiles(files);
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

        private void FileNameToDate(string path)
        {
            string date = Path.GetFileName(path);
            date = date.Replace("-", "/");
            date = date.Replace("_", ":");
            date = date.Replace(".csv", "");
            saleTime = Convert.ToDateTime(date);
        }

        //--- End Testing new code ---



        //--- BUTTON FUNCTIONS ---
        private void Form_Display_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_MainMenu formMain = new Form_MainMenu();
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String userMonth = comboBox1.SelectedItem.ToString();
            String userYear = comboBox2.SelectedItem.ToString();

            listBox1.Items.Clear();
            lbl_search.Text = "( Month: " + userMonth + ", Year :" + userYear + " )";

            List <string> paths = csvManager.selectSetOfFiles(userMonth, userYear);
            List<string> dates = new List<string>();

            
            foreach (string p in paths)
            {
                // dates.Add(csvManager.getDateFromPath(p).Split(' ')[0]);
                dates.Add(csvManager.getDateFromPath(p));
            }
            
            dates = csvManager.condensestring(dates);

            foreach (string p in dates)
            {
                listBox1.Items.Add(p);
                //listBox1.Items.Add(p);
            }
           
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ReadRecord(listBox1.SelectedItem.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //--- END OF BUTTON FUNCTIONS ---
    }
}
