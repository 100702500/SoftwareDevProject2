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
    public partial class Form_Display : Form
    {
        public Form_Display()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Display_Load(object sender, EventArgs e)
        {

        }

        //back
        private void button3_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage.Show();
            this.Hide();
        }

        //search
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
