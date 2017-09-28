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
            string edtDateTime = txtbox_datetime.Text;
            string edtItemName = txtbox_name.Text;
            int edtQty = Convert.ToInt32(numbox_qty.Value);
            Decimal edtPrice = Convert.ToDecimal(txtbox_price.Text);

            MessageBox.Show(edtDateTime + " " + edtItemName + " "
                + edtQty.ToString() + " " + edtPrice.ToString());
        }
    }
}
