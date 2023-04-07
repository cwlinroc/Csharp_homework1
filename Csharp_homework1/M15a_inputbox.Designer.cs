namespace Csharp_homework1
{
    partial class form_M15a_inputbox
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
            this.label_title = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.textbox_inputnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title.Location = new System.Drawing.Point(57, 68);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(235, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Please Input A Number";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_enter.Location = new System.Drawing.Point(361, 63);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(153, 30);
            this.btn_enter.TabIndex = 1;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_cancel.Location = new System.Drawing.Point(361, 116);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(153, 30);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // textbox_inputnumber
            // 
            this.textbox_inputnumber.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textbox_inputnumber.Location = new System.Drawing.Point(62, 121);
            this.textbox_inputnumber.Name = "textbox_inputnumber";
            this.textbox_inputnumber.Size = new System.Drawing.Size(249, 25);
            this.textbox_inputnumber.TabIndex = 3;
            // 
            // form_M15a_inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 191);
            this.Controls.Add(this.textbox_inputnumber);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label_title);
            this.KeyPreview = true;
            this.Name = "form_M15a_inputbox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.M15a_inputbox_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox textbox_inputnumber;
    }
}