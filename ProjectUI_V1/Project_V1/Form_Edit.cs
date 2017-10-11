using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Project_V1
{
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();

            IniMonthYearBox();
        }

        
        List<Item> saleItems;
        DateTime saleTime;
        float saleTotal;




        // Start of Button Events 
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

        private void btn_save_Click(object sender, EventArgs e)
        {

            grpbox_edit.Visible = false;
            grpbox_list.Visible = true;
         
            EditItem(saleItems[Convert.ToInt32(listBox2.SelectedIndex)], Convert.ToInt32(listBox2.SelectedIndex));
            DateTime myDate = DateTime.ParseExact(lbl_listdate.Text, "dd-MM-yyyy h_mm_ss tt",
                                       System.Globalization.CultureInfo.InvariantCulture);
            csvManager.writeSalesRecord(saleItems, myDate);
            numbox_qty.Value = 0;
            txtbox_price.Text = " ";

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_confirm.Visible = true;
            grpbox_edit.Visible = false;

            String userMonth = boxMonth.SelectedItem.ToString();
            String userYear = boxYear.SelectedItem.ToString();

            listBox1.Items.Clear();
            List<string> paths = csvManager.selectSetOfFiles(userMonth, userYear);
            List<string> dates = new List<string>();

            foreach (string p in paths)
            {
                dates.Add(csvManager.getDateFromPath(p));
            }


            foreach (string p in dates)
            {
                listBox1.Items.Add(p);
            }

        }

        private void btn_editsel_Click(object sender, EventArgs e)
        {
            grpbox_edit.Visible = true;

            lbl_date.Text = listBox1.SelectedItem.ToString();
            lbl_name.Text = listBox2.SelectedItem.ToString();

            numbox_qty.Value = 0;
            txtbox_price.Text = "";

        }

        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            grpbox_edit.Visible = false;
            grpbox_list.Visible = true;


        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            grpbox_edit.Visible = false;
            grpbox_list.Visible = true;
            listBox2.Items.Clear();

            ListProdName(listBox1.SelectedItem.ToString());
            lbl_listdate.Text = listBox1.SelectedItem.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            grpbox_edit.Visible = true;

        }
        private void grpbox_list_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // End of Button Event



        //START OF NEW CODES:
        // List combobox to Month (1-12) & Year(2016-2017) 
        private void IniMonthYearBox()
        {

            /*
            boxMonth.Items.Add("1");
            boxMonth.Items.Add("2");
            boxMonth.Items.Add("3");
            boxMonth.Items.Add("4");
            boxMonth.Items.Add("5");
            boxMonth.Items.Add("6");
            boxMonth.Items.Add("7");
            boxMonth.Items.Add("8");
            boxMonth.Items.Add("9");
            */
            boxMonth.Items.Add("10");
            /*
            boxMonth.Items.Add("11");
            boxMonth.Items.Add("12");
            boxYear.Items.Add("2016");
            */
            boxYear.Items.Add("2017");

        }

        public List<Item> getsaleItems()
        {
            return saleItems;
        }

        public DateTime getsaleTime()
        {
            return saleTime;
        }



        private void ListProdName(string path)
        {
            String userMonth = boxMonth.SelectedItem.ToString();
            String userYear = boxYear.SelectedItem.ToString();
            string file = csvManager.selectFileByDate(path, csvManager.selectSetOfFiles(userMonth, userYear));
            saleItems = csvManager.readSingleFile(file);
            printlistofname();
        }


        private void FileNameToDate(string path)
        {
            string date = Path.GetFileName(path);
            date = date.Replace("-", "/");
            date = date.Replace("_", ":");
            date = date.Replace(".csv", "");
            saleTime = Convert.ToDateTime(date);
        }
        

        private void printlistofname()
        {
            foreach (Item element in saleItems)
            {
                listBox2.Items.Add(element.getProductName());
            }
        }

        private void EditItem(Item item, int index)
        {

               
         string edtItemName = item.getProductName();
         int edtQty = Convert.ToInt32(numbox_qty.Value);
         float edtPrice = float.Parse(txtbox_price.Text);

         MessageBox.Show( "UPDATED: Item Name: " + edtItemName + ", Qty: "
             + edtQty.ToString() + ", Price:  " + edtPrice.ToString());

        saleItems[index] = new Item(edtItemName, edtPrice, edtQty);

        }

 
    }
}
