namespace Csharp_homework1
{
    partial class M02_form_index
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
            // M02_form_index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_show_clicked);
            this.Controls.Add(this.button_showhelloform);
            this.Name = "M02_form_index";
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_showhelloform;
        private System.Windows.Forms.Button btn_show_clicked;
    }
}