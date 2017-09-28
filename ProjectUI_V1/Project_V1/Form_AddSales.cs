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
// --------------------------------------

namespace Project_V1
{
    public partial class Form_AddSales : Form
    {
        //Declare: 
        DateTime saleTime = DateTime.Now;



        public Form_AddSales()
        {
            InitializeComponent();
        }


        private void Form_AddSales_Load(object sender, EventArgs e)
        {

        }

        private void btn_cont_Click(object sender, EventArgs e)
        {

            /*
            string addDateTime = txtbox_datetime.Text;
            string addItemName = txtbox_name.Text;
            int addQty = Convert.ToInt32(numbox_qty.Value);
            Decimal addPrice = Convert.ToDecimal(txtbox_price.Text);

            //Testing Button Output.
            MessageBox.Show(saleTime + " " + addDateTime + " " + addItemName + " " 
                + addQty.ToString() + " " +  addPrice.ToString() ) ;
            */
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            //Returns to MainMenu
            Form_MainMenu formMain = new Form_MainMenu();
            this.Hide();
            formMain.ShowDialog();
            this.Close();
        }

        private void txtbox_datetime_TextChanged(object sender, EventArgs e)
        {
           
        }

        /*
        //Add invidvidual items to the sales record.
        private void AddItem()
        {
            //Take in user input for name and perform validation.
            string name = ValidateName();
            //Take in user input for price and perform validation.
            float price = ValidatePrice();
            //Take in user input for quantity and perform validation.
            int quantity = ValidateQuantity();
            //Add the item to the list.
            saleItems.Add(new Item(name, price, quantity));
        }
        
        private decimal ValidatePrice()
        {
            decimal addPrice = Convert.ToDecimal(txtbox_price.Text);

            var regexItem = new Regex("^[0-9]{1,3}.[0-9]{1,2}$");
            bool isNotValid = true;

            if (regexItem.IsMatch(addPrice))
                isNotValid = false;

            while (isNotValid)
            {
                MessageBox.Show("Please enter a valid Item Price: ");
                if (regexItem.IsMatch(addPrice))
                    isNotValid = false;
            }
        }

    */

    }
}
