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

        private void btn_AddRec_Click(object sender, EventArgs e)
        {
            Form_AddRec rec = new Form_AddRec();
            rec.Show();
        }

        private void btn_EditRec_Click(object sender, EventArgs e)
        {
            Form_EditRec edit = new Form_EditRec();
            edit.Show();
        }

        private void btn_DisplayRec_Click(object sender, EventArgs e)
        {
            Form_Display dis = new Form_Display();
            dis.Show();
        }
        

        //Generate Reports
        private void btn_GenMonth_Click(object sender, EventArgs e)
        {
            Form_MonthlyReport rep = new Form_MonthlyReport();
            rep.Show();
        }

        private void btn_GenWeek_Click(object sender, EventArgs e)
        {
            Form_WeeklyReport wee = new Form_WeeklyReport();
            wee.Show();
        }

        //QUIT
        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
