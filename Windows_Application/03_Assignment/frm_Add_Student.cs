using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_No03
{
    public partial class frm_Add_Student : Form
    {
        public frm_Add_Student()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Roll_No.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "10-01-2005";
            cmb_Course.SelectedIndex = -1;
        }

        private void frm_Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Student_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            frm_Update_Student Obj = new frm_Update_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List Obj = new frm_Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login Obj = new frm_Login();
            Obj.Show();
            this.Hide();
        }
    }
}
