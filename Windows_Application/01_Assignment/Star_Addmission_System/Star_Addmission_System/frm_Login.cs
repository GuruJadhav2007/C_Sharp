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
    public partial class frm_Login : Form
    {
        public frm_Login()
        { 
            InitializeComponent();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_User_Name.Text == "Admin" && tb_Password.Text == "A123" )
            {
                MessageBox.Show("Welcome, Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student obj = new frm_Add_New_Student();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect User Name Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_User_Name.Clear();
                tb_Password.Clear();
            }
        }

        private void tb_User_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            btn_Submit.Enabled = true;
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {

        }
    }
}
