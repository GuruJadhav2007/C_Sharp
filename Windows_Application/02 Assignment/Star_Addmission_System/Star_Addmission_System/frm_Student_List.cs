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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            GBindGrid();
        }

        SqlConnection GCon = new SqlConnection(@"Data Source=GURU;Initial Catalog=Star_Addmission_SystemS_DB;Integrated Security=True");

        void GCon_Start()
        {
            if(GCon.State != ConnectionState.Open)
            {
                GCon.Open();
            }
        }

        void GCon_Stop()
        {
            if(GCon.State != ConnectionState.Closed)
            {
                GCon.Close();
            }
        }

        void GBindGrid()
        {
            GCon_Start();

            SqlDataAdapter SAS = new SqlDataAdapter("Select * From Student_Details", GCon);

            //  SqlDataAdapter SAS = new SqlDataAdapter("Select Name,DOB,Course,Mob_No From Student_Details", GCon);

            DataTable dt = new DataTable();

            SAS.Fill(dt);

            dgv_Student_List.DataSource = dt;

            GCon_Stop();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Add_Student obj = new frm_Add_Student();
            obj.Show();
            this.Hide();
        }

        private void btn_Update_Student_Click(object sender, EventArgs e)
        {
            frm_Update_Student Obj = new frm_Update_Student(new frm_Add_Student());
            Obj.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student Obj = new frm_Search_Student(new frm_Add_Student());
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
