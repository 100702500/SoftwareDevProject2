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
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private void Form_MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddRec_Click(object sender, EventArgs e)
        {
            Form_AddSales formAdd = new Form_AddSales();
            this.Hide();
            formAdd.ShowDialog();
            this.Close();
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            //Exit Button
            this.Close();
        }

        private void btn_EditRec_Click(object sender, EventArgs e)
        {
            Form_Edit formEdit = new Form_Edit();
            this.Hide();
            formEdit.ShowDialog();
            this.Close();
        }

        private void btn_DisplayRec_Click(object sender, EventArgs e)
        {
            Form_Display formDisplay = new Form_Display();
            this.Hide();
            formDisplay.ShowDialog();
            this.Close();
        }



    }
}
