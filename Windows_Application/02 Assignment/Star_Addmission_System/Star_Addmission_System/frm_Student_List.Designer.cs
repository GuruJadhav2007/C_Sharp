
namespace Star_Addmission_System
{
    partial class frm_Student_List
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Head = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Head = new System.Windows.Forms.Label();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.studentDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.star_Addmission_SystemS_DBDataSet2 = new Star_Addmission_System.Star_Addmission_SystemS_DBDataSet2();
            this.studentDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter2 = new Star_Addmission_System.Star_Addmission_SystemS_DBDataSet2TableAdapters.Student_DetailsTableAdapter();
            this.pnl_Head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_Addmission_SystemS_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Head
            // 
            this.pnl_Head.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnl_Head.Controls.Add(this.btn_Logout);
            this.pnl_Head.Controls.Add(this.lbl_Head);
            this.pnl_Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Head.Location = new System.Drawing.Point(0, 0);
            this.pnl_Head.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Head.Name = "pnl_Head";
            this.pnl_Head.Size = new System.Drawing.Size(1120, 123);
            this.pnl_Head.TabIndex = 1;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.LightGray;
            this.btn_Logout.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Red;
            this.btn_Logout.Location = new System.Drawing.Point(1007, 4);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(109, 38);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Head
            // 
            this.lbl_Head.AutoSize = true;
            this.lbl_Head.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Head.Font = new System.Drawing.Font("Modern No. 20", 36F);
            this.lbl_Head.ForeColor = System.Drawing.Color.Coral;
            this.lbl_Head.Location = new System.Drawing.Point(385, 26);
            this.lbl_Head.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Head.Name = "lbl_Head";
            this.lbl_Head.Size = new System.Drawing.Size(329, 62);
            this.lbl_Head.TabIndex = 0;
            this.lbl_Head.Text = "Student List";
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AllowUserToAddRows = false;
            this.dgv_Student_List.AllowUserToDeleteRows = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Location = new System.Drawing.Point(16, 130);
            this.dgv_Student_List.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.ReadOnly = true;
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.Size = new System.Drawing.Size(1088, 446);
            this.dgv_Student_List.TabIndex = 2;
            // 
            // studentDetailsBindingSource2
            // 
            this.studentDetailsBindingSource2.DataMember = "Student_Details";
            this.studentDetailsBindingSource2.DataSource = this.star_Addmission_SystemS_DBDataSet2;
            // 
            // star_Addmission_SystemS_DBDataSet2
            // 
            this.star_Addmission_SystemS_DBDataSet2.DataSetName = "Star_Addmission_SystemS_DBDataSet2";
            this.star_Addmission_SystemS_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentDetailsBindingSource1
            // 
            this.studentDetailsBindingSource1.DataMember = "Student_Details";
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.LightGray;
            this.btn_Add_Student.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Add_Student.Location = new System.Drawing.Point(107, 584);
            this.btn_Add_Student.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(196, 36);
            this.btn_Add_Student.TabIndex = 1;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightGray;
            this.btn_Search.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.Red;
            this.btn_Search.Location = new System.Drawing.Point(808, 583);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(196, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.LightGray;
            this.btn_Update_Student.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.btn_Update_Student.ForeColor = System.Drawing.Color.Red;
            this.btn_Update_Student.Location = new System.Drawing.Point(446, 583);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(212, 36);
            this.btn_Update_Student.TabIndex = 3;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // student_DetailsTableAdapter2
            // 
            this.student_DetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1120, 634);
            this.Controls.Add(this.btn_Update_Student);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.pnl_Head);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.pnl_Head.ResumeLayout(false);
            this.pnl_Head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star_Addmission_SystemS_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Head;
        private System.Windows.Forms.Label lbl_Head;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource1;
        private System.Windows.Forms.Button btn_Update_Student;
        private Star_Addmission_SystemS_DBDataSet2 star_Addmission_SystemS_DBDataSet2;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource2;
        private Star_Addmission_SystemS_DBDataSet2TableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter2;
    }
}