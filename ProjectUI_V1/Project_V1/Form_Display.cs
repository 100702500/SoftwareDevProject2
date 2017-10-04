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
        }


        // --- Testing new code ---
        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        public DateTime getsaleTime()
        {
            return saleTime;
        }

        private void ReadRecord()
        {
            string path = csvManager.selectFile();
            saleItems = csvManager.readSingleFile(path);
            FileNameToDate(path);
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
            
            listBox2.Items.Clear();
            string path = csvManager.selectFile();
            saleItems = csvManager.readSingleFile(path);
            FileNameToDate(path);
            PrintRecord();

        }
        //--- END OF BUTTON FUNCTIONS ---
    }
}
