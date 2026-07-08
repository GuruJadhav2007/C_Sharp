using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Star_Addmission_System
{
    public partial class frm_Add_Student : Form
    {
        public frm_Add_Student()
        {
            InitializeComponent();
        }

        SqlConnection Gcon = new SqlConnection(@"Data Source=GURU;Initial Catalog=Star_Addmission_SystemS_DB;Integrated Security=True");

        void Gcon_Start()
        {
            if (Gcon.State != ConnectionState.Open)
            {
                Gcon.Open();
            }
        }

        void Gcon_Stop()
        {
            if(Gcon.State != ConnectionState.Closed)
            {
                Gcon.Close();
            }
        }

        public void Clear_Control()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "1-5-2000";
            cmb_Course.SelectedIndex = -1;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student obj = new frm_Search_Student(this);
            obj.Show();
            this.Hide();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Gcon_Start();

            if(tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && dtp_DOB.Text != "" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Insert into Student_Details (Roll_No,Name,DOB,Mob_No,Course) Values(@RNo,@Nm,@DOB,@MobNo,@Course)";

                Cmd.Connection = Gcon;

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Control();
            }
            else
            {
                MessageBox.Show("1st Fill all fields ");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Update_Student Obj = new frm_Update_Student(this);
            Obj.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List Obj = new frm_Student_List();
            Obj.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
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
            if(!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
