using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2_V1
{
    public partial class Form_AddRec : Form
    {
        static Stocks stock = new Stocks();
        SalesRecord ActiveRecord = new SalesRecord(0, stock);

        public Form_AddRec()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            float f = (float)2.11;
            ActiveRecord.AddItem(txt_enterID.Text, f, (int)(txt_qty.Value));
        }

        private void btn_complete_Click(object sender, EventArgs e)
        {
            ActiveRecord.complete();
        }
    }
}
