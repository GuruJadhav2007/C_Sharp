using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Star_Addmission_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }

        SqlConnection GCon = new SqlConnection(@"Data Source=GURU;Initial Catalog=Star_Addmission_SystemS_DB;Integrated Security=True");

        void GCon_Open()
        {
            if(GCon.State != ConnectionState.Open)
            {
                GCon.Open();
            }
        }

        void GCon_Close()
        {
            if(GCon.State != ConnectionState.Closed)
            {
                GCon.Close();
            }
        }

        private void btn_Stud_List_Click(object sender, EventArgs e)
        {
            frm_Student_List obj = new frm_Student_List();
            obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Name.Clear();
            tb_Roll_No.Clear();
            dtp_DOB.Text = "01-02-2001";
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            GCon_Open();

            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Insert Into Student_Details (Roll_No, Name, DOB, Mob_No, Course) Values (@RNo, @Nm, @DOB, @MNo, @Course )";

                Cmd.Connection = GCon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tb_Mob_No.Clear();
                tb_Name.Clear();
                tb_Roll_No.Clear();
                cmb_Course.SelectedIndex = -1;
                dtp_DOB.Text = "01-03-2001";
            }
            else
            {
                MessageBox.Show("1st Fill All Fields", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            GCon_Close();
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
            if (!(Char.IsDigit(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
