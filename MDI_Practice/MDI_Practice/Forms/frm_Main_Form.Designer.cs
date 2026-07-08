
namespace MDI_Practice.Forms
{
    partial class frm_Main_Form
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
            this.lbl_Add_Student = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.pnl_Contener = new System.Windows.Forms.Panel();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.btn_Update_Student = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_Student
            // 
            this.lbl_Add_Student.AutoSize = true;
            this.lbl_Add_Student.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_Add_Student.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Student.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_Add_Student.Location = new System.Drawing.Point(366, 45);
            this.lbl_Add_Student.Name = "lbl_Add_Student";
            this.lbl_Add_Student.Size = new System.Drawing.Size(295, 54);
            this.lbl_Add_Student.TabIndex = 0;
            this.lbl_Add_Student.Text = "Add Student";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Header.Controls.Add(this.lbl_Add_Student);
            this.pnl_Header.Location = new System.Drawing.Point(272, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1105, 155);
            this.pnl_Header.TabIndex = 1;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_Buttons.Controls.Add(this.btn_Student_List);
            this.pnl_Buttons.Controls.Add(this.btn_Update_Student);
            this.pnl_Buttons.Controls.Add(this.btn_Add_Student);
            this.pnl_Buttons.Location = new System.Drawing.Point(1, 155);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(273, 615);
            this.pnl_Buttons.TabIndex = 2;
            // 
            // pnl_Contener
            // 
            this.pnl_Contener.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnl_Contener.Location = new System.Drawing.Point(272, 155);
            this.pnl_Contener.Name = "pnl_Contener";
            this.pnl_Contener.Size = new System.Drawing.Size(1105, 615);
            this.pnl_Contener.TabIndex = 3;
            // 
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Add_Student.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Student.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Add_Student.Location = new System.Drawing.Point(3, 82);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(262, 58);
            this.btn_Add_Student.TabIndex = 0;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // btn_Update_Student
            // 
            this.btn_Update_Student.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Update_Student.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update_Student.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Update_Student.Location = new System.Drawing.Point(3, 226);
            this.btn_Update_Student.Name = "btn_Update_Student";
            this.btn_Update_Student.Size = new System.Drawing.Size(262, 58);
            this.btn_Update_Student.TabIndex = 1;
            this.btn_Update_Student.Text = "Update Student";
            this.btn_Update_Student.UseVisualStyleBackColor = false;
            this.btn_Update_Student.Click += new System.EventHandler(this.btn_Update_Student_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Student_List.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_Student_List.Location = new System.Drawing.Point(3, 355);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(262, 58);
            this.btn_Student_List.TabIndex = 2;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            // 
            // frm_Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 771);
            this.Controls.Add(this.pnl_Contener);
            this.Controls.Add(this.pnl_Buttons);
            this.Controls.Add(this.pnl_Header);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frm_Main_Form_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Student;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Buttons;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Update_Student;
        private System.Windows.Forms.Button btn_Add_Student;
        public System.Windows.Forms.Panel pnl_Contener;
    }
}