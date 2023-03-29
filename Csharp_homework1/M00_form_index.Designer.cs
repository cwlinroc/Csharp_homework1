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
            this.SuspendLayout();
            // 
            // button_showhelloform
            // 
            this.button_showhelloform.Location = new System.Drawing.Point(67, 54);
            this.button_showhelloform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_showhelloform.Name = "button_showhelloform";
            this.button_showhelloform.Size = new System.Drawing.Size(225, 89);
            this.button_showhelloform.TabIndex = 0;
            this.button_showhelloform.Text = "Show Hello Form";
            this.button_showhelloform.UseVisualStyleBackColor = true;
            this.button_showhelloform.Click += new System.EventHandler(this.button_showhelloform_Click);
            // 
            // btn_show_clicked
            // 
            this.btn_show_clicked.Location = new System.Drawing.Point(861, 472);
            this.btn_show_clicked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_show_clicked.Name = "btn_show_clicked";
            this.btn_show_clicked.Size = new System.Drawing.Size(161, 61);
            this.btn_show_clicked.TabIndex = 1;
            this.btn_show_clicked.Text = "show clicked times";
            this.btn_show_clicked.UseVisualStyleBackColor = true;
            this.btn_show_clicked.Click += new System.EventHandler(this.btn_show_clicked_Click);
            // 
            // btn_show_date
            // 
            this.btn_show_date.Location = new System.Drawing.Point(861, 389);
            this.btn_show_date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_show_date.Name = "btn_show_date";
            this.btn_show_date.Size = new System.Drawing.Size(160, 60);
            this.btn_show_date.TabIndex = 2;
            this.btn_show_date.TabStop = false;
            this.btn_show_date.Text = "show date";
            this.btn_show_date.UseVisualStyleBackColor = true;
            this.btn_show_date.Click += new System.EventHandler(this.btn_show_date_Click);
            // 
            // btn_showloanform
            // 
            this.btn_showloanform.Location = new System.Drawing.Point(388, 54);
            this.btn_showloanform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_showloanform.Name = "btn_showloanform";
            this.btn_showloanform.Size = new System.Drawing.Size(220, 89);
            this.btn_showloanform.TabIndex = 3;
            this.btn_showloanform.Text = "Show Loan Form";
            this.btn_showloanform.UseVisualStyleBackColor = true;
            this.btn_showloanform.Click += new System.EventHandler(this.btn_showloanform_Click);
            // 
            // btm_show_barapp
            // 
            this.btm_show_barapp.Location = new System.Drawing.Point(699, 54);
            this.btm_show_barapp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btm_show_barapp.Name = "btm_show_barapp";
            this.btm_show_barapp.Size = new System.Drawing.Size(220, 89);
            this.btm_show_barapp.TabIndex = 4;
            this.btm_show_barapp.Text = "Show bar app";
            this.btm_show_barapp.UseVisualStyleBackColor = true;
            this.btm_show_barapp.Click += new System.EventHandler(this.btm_show_barapp_Click);
            // 
            // btn_show_student_structform
            // 
            this.btn_show_student_structform.Location = new System.Drawing.Point(70, 193);
            this.btn_show_student_structform.Name = "btn_show_student_structform";
            this.btn_show_student_structform.Size = new System.Drawing.Size(221, 105);
            this.btn_show_student_structform.TabIndex = 5;
            this.btn_show_student_structform.Text = "Show Student Structform";
            this.btn_show_student_structform.UseVisualStyleBackColor = true;
            this.btn_show_student_structform.Click += new System.EventHandler(this.btn_show_student_structform_Click);
            // 
            // M00_form_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btn_show_student_structform);
            this.Controls.Add(this.btm_show_barapp);
            this.Controls.Add(this.btn_showloanform);
            this.Controls.Add(this.btn_show_date);
            this.Controls.Add(this.btn_show_clicked);
            this.Controls.Add(this.button_showhelloform);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}