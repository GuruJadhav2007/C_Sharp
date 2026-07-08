
namespace Assignment_No03
{
    partial class frm_Search_Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Search_Student = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btn_LogOut);
            this.panel1.Controls.Add(this.lbl_Search_Student);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1453, 137);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Search_Student
            // 
            this.lbl_Search_Student.AutoSize = true;
            this.lbl_Search_Student.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Search_Student.Font = new System.Drawing.Font("Modern No. 20", 30F);
            this.lbl_Search_Student.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Search_Student.Location = new System.Drawing.Point(541, 40);
            this.lbl_Search_Student.Name = "lbl_Search_Student";
            this.lbl_Search_Student.Size = new System.Drawing.Size(327, 51);
            this.lbl_Search_Student.TabIndex = 0;
            this.lbl_Search_Student.Text = "Search Student";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.Linen;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Sienna;
            this.lbl_Roll_No.Location = new System.Drawing.Point(350, 230);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(115, 35);
            this.lbl_Roll_No.TabIndex = 1;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Linen;
            this.lbl_Name.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_Name.ForeColor = System.Drawing.Color.Sienna;
            this.lbl_Name.Location = new System.Drawing.Point(350, 310);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(96, 35);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.Linen;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_Mob_No.ForeColor = System.Drawing.Color.Sienna;
            this.lbl_Mob_No.Location = new System.Drawing.Point(350, 380);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(159, 35);
            this.lbl_Mob_No.TabIndex = 3;
            this.lbl_Mob_No.Text = "Mobile No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.Linen;
            this.lbl_DOB.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_DOB.ForeColor = System.Drawing.Color.Sienna;
            this.lbl_DOB.Location = new System.Drawing.Point(350, 450);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(186, 35);
            this.lbl_DOB.TabIndex = 4;
            this.lbl_DOB.Text = "Date of Birth";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.Linen;
            this.lbl_Course.Font = new System.Drawing.Font("Rockwell", 18F);
            this.lbl_Course.ForeColor = System.Drawing.Color.Sienna;
            this.lbl_Course.Location = new System.Drawing.Point(350, 520);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(116, 35);
            this.lbl_Course.TabIndex = 5;
            this.lbl_Course.Text = "Course";
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(714, 235);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(290, 30);
            this.tb_Roll_No.TabIndex = 6;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(714, 315);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(290, 30);
            this.tb_Name.TabIndex = 7;
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(714, 385);
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(290, 30);
            this.tb_Mob_No.TabIndex = 8;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(714, 453);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(290, 30);
            this.dtp_DOB.TabIndex = 9;
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Location = new System.Drawing.Point(714, 525);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(290, 33);
            this.cmb_Course.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Search.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.btn_Search.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Search.Location = new System.Drawing.Point(947, 701);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(83, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Refresh.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.btn_Refresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Refresh.Location = new System.Drawing.Point(200, 701);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Add_Student.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.btn_Add_Student.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Add_Student.Location = new System.Drawing.Point(438, 701);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(128, 23);
            this.btn_Add_Student.TabIndex = 13;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Update.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.btn_Update.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Update.Location = new System.Drawing.Point(714, 701);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(129, 23);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Update Student";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_Student_List.Font = new System.Drawing.Font("Rockwell", 16.2F);
            this.btn_Student_List.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Student_List.Location = new System.Drawing.Point(1100, 701);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(146, 23);
            this.btn_Student_List.TabIndex = 15;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_LogOut.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(1325, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(117, 41);
            this.btn_LogOut.TabIndex = 1;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            // 
            // frm_Search_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1453, 782);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student";
            this.Text = "Search Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Search_Student;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Student_List;
    }
}