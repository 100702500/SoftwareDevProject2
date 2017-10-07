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
      

        public Form_AddSales()
        {
            InitializeComponent();
        }


        private void Form_AddSales_Load(object sender, EventArgs e)
        {

        }

        private void btn_cont_Click(object sender, EventArgs e)
        {

            //Testing Zac's Code.
            /*
            float f = (float)2.11;
            ActiveRecord.AddItem(txt_enterID.Text, f, (int)(txt_qty.Value));
            */


            //My Testing code:
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


 
    }
}
