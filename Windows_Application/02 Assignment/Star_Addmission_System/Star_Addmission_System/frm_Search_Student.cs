using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Star_Addmission_System
{     
   
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student(frm_Add_Student obj)
        {
            InitializeComponent();
        }

        SqlConnection GCon = new SqlConnection(@"Data Source=GURU;Initial Catalog=Star_Addmission_SystemS_DB;Integrated Security=True");

        void Gcon_Start()
        {
            if(GCon.State != ConnectionState.Open)
            {
                GCon.Open();
            }
        }


        void Gcon_Stop()
        {
            if(GCon.State != ConnectionState.Closed)
            {
                GCon.Close();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "1-5-2000";
            cmb_Course.SelectedIndex = -1;

            tb_Roll_No.Enabled = true;
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student Obj = new frm_Add_Student();
            Obj.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        { 
            frm_Update_Student Obj = new frm_Update_Student(new frm_Add_Student());
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Gcon_Start();

            SqlCommand Cmd = new SqlCommand();

            Cmd.CommandText = "Select * From Student_Details Where Roll_No = @RNo";
            Cmd.Connection = GCon;

            Cmd.Parameters.Add("@RNo", SqlDbType.Int).Value = tb_Roll_No.Text;

            SqlDataReader DR = Cmd.ExecuteReader();

            if (DR.Read())
            {
                tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                tb_Mob_No.Text = (DR["Mob_No"].ToString());
                dtp_DOB.Text = (DR["DOB"].ToString());
                cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));

                lbl_Nm.Text = DR.GetString(DR.GetOrdinal("Name"));
                lbl_Mn.Text = (DR["Mob_No"].ToString());
                lbl_Db.Text = (DR["DOB"].ToString());
                lbl_Cs.Text = DR.GetString(DR.GetOrdinal("Course"));

                tb_Roll_No.Enabled = false;
            }
            else
            {
                MessageBox.Show("Invalid Roll Number.", "No Such Student Found", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            Gcon_Stop();
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

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsLetter(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
