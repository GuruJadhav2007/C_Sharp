using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Practice.Forms
{
    public partial class frm_Main_Form : Form
    {
        public frm_Main_Form()
        {
            InitializeComponent();
        }

        private void frm_Main_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student obj = new frm_Add_New_Student() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Contener.Controls.Clear();
            pnl_Contener.Controls.Add(obj);
            obj.Show();


        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            frm_Update_Student obj = new frm_Update_Student() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_Contener.Controls.Clear();
            pnl_Contener.Controls.Add(obj);
            obj.Show();
        }
    }
}
