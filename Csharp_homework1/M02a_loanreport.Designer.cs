namespace Csharp_homework1
{
    partial class M02a_loanreport
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
            this.label_loan_amount = new System.Windows.Forms.Label();
            this.label_loan_term_year = new System.Windows.Forms.Label();
            this.label_lending_rate_year = new System.Windows.Forms.Label();
            this.label_PMT = new System.Windows.Forms.Label();
            this.label_total_payment = new System.Windows.Forms.Label();
            this.textbox_loan_amount = new System.Windows.Forms.TextBox();
            this.textbox_loan_term_yaer = new System.Windows.Forms.TextBox();
            this.textbox_lending_rate_year = new System.Windows.Forms.TextBox();
            this.textbox_PMT = new System.Windows.Forms.TextBox();
            this.textbox_total_payment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_loan_amount
            // 
            this.label_loan_amount.AutoSize = true;
            this.label_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_amount.Location = new System.Drawing.Point(99, 55);
            this.label_loan_amount.Name = "label_loan_amount";
            this.label_loan_amount.Size = new System.Drawing.Size(73, 20);
            this.label_loan_amount.TabIndex = 0;
            this.label_loan_amount.Text = "貸款金額";
            // 
            // label_loan_term_year
            // 
            this.label_loan_term_year.AutoSize = true;
            this.label_loan_term_year.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_term_year.Location = new System.Drawing.Point(100, 116);
            this.label_loan_term_year.Name = "label_loan_term_year";
            this.label_loan_term_year.Size = new System.Drawing.Size(67, 20);
            this.label_loan_term_year.TabIndex = 1;
            this.label_loan_term_year.Text = "期限(年)";
            // 
            // label_lending_rate_year
            // 
            this.label_lending_rate_year.AutoSize = true;
            this.label_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_lending_rate_year.Location = new System.Drawing.Point(100, 180);
            this.label_lending_rate_year.Name = "label_lending_rate_year";
            this.label_lending_rate_year.Size = new System.Drawing.Size(65, 20);
            this.label_lending_rate_year.TabIndex = 2;
            this.label_lending_rate_year.Text = "利率(%)";
            // 
            // label_PMT
            // 
            this.label_PMT.AutoSize = true;
            this.label_PMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_PMT.Location = new System.Drawing.Point(99, 248);
            this.label_PMT.Name = "label_PMT";
            this.label_PMT.Size = new System.Drawing.Size(57, 20);
            this.label_PMT.TabIndex = 3;
            this.label_PMT.Text = "月付款";
            // 
            // label_total_payment
            // 
            this.label_total_payment.AutoSize = true;
            this.label_total_payment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_total_payment.Location = new System.Drawing.Point(99, 312);
            this.label_total_payment.Name = "label_total_payment";
            this.label_total_payment.Size = new System.Drawing.Size(57, 20);
            this.label_total_payment.TabIndex = 4;
            this.label_total_payment.Text = "總付款";
            // 
            // textbox_loan_amount
            // 
            this.textbox_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_amount.Location = new System.Drawing.Point(248, 46);
            this.textbox_loan_amount.MaxLength = 30000;
            this.textbox_loan_amount.Name = "textbox_loan_amount";
            this.textbox_loan_amount.ReadOnly = true;
            this.textbox_loan_amount.Size = new System.Drawing.Size(137, 29);
            this.textbox_loan_amount.TabIndex = 5;
            // 
            // textbox_loan_term_yaer
            // 
            this.textbox_loan_term_yaer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_term_yaer.Location = new System.Drawing.Point(248, 107);
            this.textbox_loan_term_yaer.MaxLength = 30000;
            this.textbox_loan_term_yaer.Name = "textbox_loan_term_yaer";
            this.textbox_loan_term_yaer.ReadOnly = true;
            this.textbox_loan_term_yaer.Size = new System.Drawing.Size(137, 29);
            this.textbox_loan_term_yaer.TabIndex = 6;
            // 
            // textbox_lending_rate_year
            // 
            this.textbox_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_lending_rate_year.Location = new System.Drawing.Point(248, 171);
            this.textbox_lending_rate_year.MaxLength = 30000;
            this.textbox_lending_rate_year.Name = "textbox_lending_rate_year";
            this.textbox_lending_rate_year.ReadOnly = true;
            this.textbox_lending_rate_year.Size = new System.Drawing.Size(137, 29);
            this.textbox_lending_rate_year.TabIndex = 7;
            // 
            // textbox_PMT
            // 
            this.textbox_PMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_PMT.Location = new System.Drawing.Point(248, 239);
            this.textbox_PMT.MaxLength = 30000;
            this.textbox_PMT.Name = "textbox_PMT";
            this.textbox_PMT.ReadOnly = true;
            this.textbox_PMT.Size = new System.Drawing.Size(137, 29);
            this.textbox_PMT.TabIndex = 8;
            // 
            // textbox_total_payment
            // 
            this.textbox_total_payment.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_total_payment.Location = new System.Drawing.Point(248, 303);
            this.textbox_total_payment.MaxLength = 30000;
            this.textbox_total_payment.Name = "textbox_total_payment";
            this.textbox_total_payment.ReadOnly = true;
            this.textbox_total_payment.Size = new System.Drawing.Size(137, 29);
            this.textbox_total_payment.TabIndex = 9;
            // 
            // M03a_loanreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 411);
            this.Controls.Add(this.textbox_total_payment);
            this.Controls.Add(this.textbox_PMT);
            this.Controls.Add(this.textbox_lending_rate_year);
            this.Controls.Add(this.textbox_loan_term_yaer);
            this.Controls.Add(this.textbox_loan_amount);
            this.Controls.Add(this.label_total_payment);
            this.Controls.Add(this.label_PMT);
            this.Controls.Add(this.label_lending_rate_year);
            this.Controls.Add(this.label_loan_term_year);
            this.Controls.Add(this.label_loan_amount);
            this.Name = "M03a_loanreport";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loan_amount;
        private System.Windows.Forms.Label label_loan_term_year;
        private System.Windows.Forms.Label label_lending_rate_year;
        private System.Windows.Forms.Label label_PMT;
        private System.Windows.Forms.Label label_total_payment;
        private System.Windows.Forms.TextBox textbox_loan_amount;
        private System.Windows.Forms.TextBox textbox_loan_term_yaer;
        private System.Windows.Forms.TextBox textbox_lending_rate_year;
        private System.Windows.Forms.TextBox textbox_PMT;
        private System.Windows.Forms.TextBox textbox_total_payment;
    }
}