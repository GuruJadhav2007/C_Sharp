using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Addmission_System
{
    public partial class frm_Update_Student : Form
    {
        public frm_Update_Student(frm_Add_Student Obj)
        {
            InitializeComponent();
        }

        private void frm_Update_Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "1-5-2000";
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student Obj = new frm_Add_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List Obj = new frm_Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
