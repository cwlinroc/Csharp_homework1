namespace Csharp_homework1
{
    partial class M00_form_index
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
            this.button_showhelloform = new System.Windows.Forms.Button();
            this.btn_show_clicked = new System.Windows.Forms.Button();
            this.btn_show_date = new System.Windows.Forms.Button();
            this.btn_showloanform = new System.Windows.Forms.Button();
            this.btm_show_barapp = new System.Windows.Forms.Button();
            this.btn_show_student_structform = new System.Windows.Forms.Button();
            this.btn_show_students_grade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_showhelloform
            // 
            this.button_showhelloform.Location = new System.Drawing.Point(50, 43);
            this.button_showhelloform.Name = "button_showhelloform";
            this.button_showhelloform.Size = new System.Drawing.Size(169, 71);
            this.button_showhelloform.TabIndex = 0;
            this.button_showhelloform.Text = "Show Hello Form";
            this.button_showhelloform.UseVisualStyleBackColor = true;
            this.button_showhelloform.Click += new System.EventHandler(this.button_showhelloform_Click);
            // 
            // btn_show_clicked
            // 
            this.btn_show_clicked.Location = new System.Drawing.Point(646, 378);
            this.btn_show_clicked.Name = "btn_show_clicked";
            this.btn_show_clicked.Size = new System.Drawing.Size(121, 49);
            this.btn_show_clicked.TabIndex = 1;
            this.btn_show_clicked.Text = "show clicked times";
            this.btn_show_clicked.UseVisualStyleBackColor = true;
            this.btn_show_clicked.Click += new System.EventHandler(this.btn_show_clicked_Click);
            // 
            // btn_show_date
            // 
            this.btn_show_date.Location = new System.Drawing.Point(646, 311);
            this.btn_show_date.Name = "btn_show_date";
            this.btn_show_date.Size = new System.Drawing.Size(120, 48);
            this.btn_show_date.TabIndex = 2;
            this.btn_show_date.TabStop = false;
            this.btn_show_date.Text = "show date";
            this.btn_show_date.UseVisualStyleBackColor = true;
            this.btn_show_date.Click += new System.EventHandler(this.btn_show_date_Click);
            // 
            // btn_showloanform
            // 
            this.btn_showloanform.Location = new System.Drawing.Point(291, 43);
            this.btn_showloanform.Name = "btn_showloanform";
            this.btn_showloanform.Size = new System.Drawing.Size(165, 71);
            this.btn_showloanform.TabIndex = 3;
            this.btn_showloanform.Text = "Show Loan Form";
            this.btn_showloanform.UseVisualStyleBackColor = true;
            this.btn_showloanform.Click += new System.EventHandler(this.btn_showloanform_Click);
            // 
            // btm_show_barapp
            // 
            this.btm_show_barapp.Location = new System.Drawing.Point(524, 43);
            this.btm_show_barapp.Name = "btm_show_barapp";
            this.btm_show_barapp.Size = new System.Drawing.Size(165, 71);
            this.btm_show_barapp.TabIndex = 4;
            this.btm_show_barapp.Text = "Show bar app";
            this.btm_show_barapp.UseVisualStyleBackColor = true;
            this.btm_show_barapp.Click += new System.EventHandler(this.btm_show_barapp_Click);
            // 
            // btn_show_student_structform
            // 
            this.btn_show_student_structform.Location = new System.Drawing.Point(52, 154);
            this.btn_show_student_structform.Margin = new System.Windows.Forms.Padding(2);
            this.btn_show_student_structform.Name = "btn_show_student_structform";
            this.btn_show_student_structform.Size = new System.Drawing.Size(166, 84);
            this.btn_show_student_structform.TabIndex = 5;
            this.btn_show_student_structform.Text = "Show Student Structform";
            this.btn_show_student_structform.UseVisualStyleBackColor = true;
            this.btn_show_student_structform.Click += new System.EventHandler(this.btn_show_student_structform_Click);
            // 
            // btn_show_students_grade
            // 
            this.btn_show_students_grade.Location = new System.Drawing.Point(291, 154);
            this.btn_show_students_grade.Margin = new System.Windows.Forms.Padding(2);
            this.btn_show_students_grade.Name = "btn_show_students_grade";
            this.btn_show_students_grade.Size = new System.Drawing.Size(166, 84);
            this.btn_show_students_grade.TabIndex = 6;
            this.btn_show_students_grade.Text = "Show Students Grade";
            this.btn_show_students_grade.UseVisualStyleBackColor = true;
            this.btn_show_students_grade.Click += new System.EventHandler(this.btn_show_students_grade_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 84);
            this.button1.TabIndex = 7;
            this.button1.Text = "Show Students Grade List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // M00_form_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_show_students_grade);
            this.Controls.Add(this.btn_show_student_structform);
            this.Controls.Add(this.btm_show_barapp);
            this.Controls.Add(this.btn_showloanform);
            this.Controls.Add(this.btn_show_date);
            this.Controls.Add(this.btn_show_clicked);
            this.Controls.Add(this.button_showhelloform);
            this.Name = "M00_form_index";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_showhelloform;
        private System.Windows.Forms.Button btn_show_clicked;
        private System.Windows.Forms.Button btn_show_date;
        private System.Windows.Forms.Button btn_showloanform;
        private System.Windows.Forms.Button btm_show_barapp;
        private System.Windows.Forms.Button btn_show_student_structform;
        private System.Windows.Forms.Button btn_show_students_grade;
        private System.Windows.Forms.Button button1;
    }
}