using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_V1
{
    public partial class Form_Edit : Form
    {
        public Form_Edit()
        {
            InitializeComponent();

            IniMonthYearBox();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            /*
            string edtDateTime = txtbox_datetime.Text;
            string edtItemName = txtbox_name.Text;
            int edtQty = Convert.ToInt32(numbox_qty.Value);
            Decimal edtPrice = Convert.ToDecimal(txtbox_price.Text);

            MessageBox.Show(edtDateTime + " " + edtItemName + " "
                + edtQty.ToString() + " " + edtPrice.ToString());
                
             */

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            grpbox_editside.Visible = false;

            String userMonth = boxMonth.SelectedItem.ToString();
            String userYear = boxYear.SelectedItem.ToString();

            listBox1.Items.Clear();
        

        }

        private void btn_editsel_Click(object sender, EventArgs e)
        {
            grpbox_editside.Visible = true;
        }




        //Testing New Codes: vvv 
        //-------------------------
        
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

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            grpbox_list.Visible = true;
        }
    }
}
