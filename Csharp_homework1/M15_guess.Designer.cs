namespace Csharp_homework1
{
    partial class M15_guess
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
            this.label_resault = new System.Windows.Forms.Label();
            this.btn_guess = new System.Windows.Forms.Button();
            this.btn_showanswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_resault
            // 
            this.label_resault.AutoSize = true;
            this.label_resault.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_resault.Location = new System.Drawing.Point(148, 96);
            this.label_resault.Name = "label_resault";
            this.label_resault.Size = new System.Drawing.Size(472, 29);
            this.label_resault.TabIndex = 0;
            this.label_resault.Text = "Please select a number between 0 and 100";
            // 
            // btn_guess
            // 
            this.btn_guess.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_guess.Location = new System.Drawing.Point(153, 192);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(182, 60);
            this.btn_guess.TabIndex = 1;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = true;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // btn_showanswer
            // 
            this.btn_showanswer.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_showanswer.Location = new System.Drawing.Point(438, 192);
            this.btn_showanswer.Name = "btn_showanswer";
            this.btn_showanswer.Size = new System.Drawing.Size(182, 60);
            this.btn_showanswer.TabIndex = 2;
            this.btn_showanswer.Text = "Show Answer";
            this.btn_showanswer.UseVisualStyleBackColor = true;
            this.btn_showanswer.Click += new System.EventHandler(this.btn_showanswer_Click);
            // 
            // M15_guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 349);
            this.Controls.Add(this.btn_showanswer);
            this.Controls.Add(this.btn_guess);
            this.Controls.Add(this.label_resault);
            this.Name = "M15_guess";
            this.Text = "Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resault;
        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Button btn_showanswer;
    }
}