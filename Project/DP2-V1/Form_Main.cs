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
    public partial class form_Mainmenu : Form
    {
        public form_Mainmenu()
        {
            InitializeComponent();
        }
        Form_AddRec rec = new Form_AddRec();
        Form_EditRec edit = new Form_EditRec();
        Form_Display dis = new Form_Display();
        Form_MonthlyReport rep = new Form_MonthlyReport();
        Form_WeeklyReport wee = new Form_WeeklyReport();

        private void btn_AddRec_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage = this;
            rec.Show();
            this.Hide();
        }

        private void btn_EditRec_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage = this;
            edit.Show();
            this.Hide();
        }

        private void btn_DisplayRec_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage = this;
            dis.Show();
            this.Hide();
        }
        

        //Generate Reports
        private void btn_GenMonth_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage = this;
            rep.Show();
            this.Hide();
        }

        private void btn_GenWeek_Click(object sender, EventArgs e)
        {
            Program.FormState.PreviousPage = this;
            wee.Show();
            this.Hide();
        }

        //QUIT
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
