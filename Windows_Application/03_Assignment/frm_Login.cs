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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_UserName.Text == "A" && tb_Password.Text == "a")
            {
                frm_Add_Student Obj = new frm_Add_Student();
                Obj.Show();
                this.Hide();

                MessageBox.Show("Login Sussesfull", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_UserName.Text = "";
                tb_Password.Text = "";
            }
            else
            {
                MessageBox.Show("Login Failed", "Correct User Name or Password", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                tb_UserName.Text = "";
                tb_Password.Text = "";
            }
        }

    }
}
