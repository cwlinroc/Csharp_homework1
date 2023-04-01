namespace Csharp_homework1
{
    partial class M02_form_loancounter
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
            this.label_loan_amout = new System.Windows.Forms.Label();
            this.label_loan_term_year = new System.Windows.Forms.Label();
            this.label_lending_rate_year = new System.Windows.Forms.Label();
            this.label_down_payment = new System.Windows.Forms.Label();
            this.text_loan_amount = new System.Windows.Forms.TextBox();
            this.text_loan_term_year = new System.Windows.Forms.TextBox();
            this.text_lending_rate_year = new System.Windows.Forms.TextBox();
            this.text_down_payment = new System.Windows.Forms.TextBox();
            this.btn_PMT = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_loan_amout
            // 
            this.label_loan_amout.AutoSize = true;
            this.label_loan_amout.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_amout.Location = new System.Drawing.Point(177, 62);
            this.label_loan_amout.Name = "label_loan_amout";
            this.label_loan_amout.Size = new System.Drawing.Size(96, 27);
            this.label_loan_amout.TabIndex = 0;
            this.label_loan_amout.Text = "貸款金額";
            // 
            // label_loan_term_year
            // 
            this.label_loan_term_year.AutoSize = true;
            this.label_loan_term_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_term_year.Location = new System.Drawing.Point(177, 124);
            this.label_loan_term_year.Name = "label_loan_term_year";
            this.label_loan_term_year.Size = new System.Drawing.Size(89, 27);
            this.label_loan_term_year.TabIndex = 1;
            this.label_loan_term_year.Text = "期限(年)";
            // 
            // label_lending_rate_year
            // 
            this.label_lending_rate_year.AutoSize = true;
            this.label_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_lending_rate_year.Location = new System.Drawing.Point(177, 184);
            this.label_lending_rate_year.Name = "label_lending_rate_year";
            this.label_lending_rate_year.Size = new System.Drawing.Size(86, 27);
            this.label_lending_rate_year.TabIndex = 2;
            this.label_lending_rate_year.Text = "利率(%)";
            // 
            // label_down_payment
            // 
            this.label_down_payment.AutoSize = true;
            this.label_down_payment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_down_payment.Location = new System.Drawing.Point(177, 244);
            this.label_down_payment.Name = "label_down_payment";
            this.label_down_payment.Size = new System.Drawing.Size(75, 27);
            this.label_down_payment.TabIndex = 3;
            this.label_down_payment.Text = "頭期款";
            // 
            // text_loan_amount
            // 
            this.text_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_loan_amount.Location = new System.Drawing.Point(426, 54);
            this.text_loan_amount.Name = "text_loan_amount";
            this.text_loan_amount.Size = new System.Drawing.Size(172, 35);
            this.text_loan_amount.TabIndex = 4;
            this.text_loan_amount.Text = "1000000";
            // 
            // text_loan_term_year
            // 
            this.text_loan_term_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_loan_term_year.Location = new System.Drawing.Point(426, 116);
            this.text_loan_term_year.Name = "text_loan_term_year";
            this.text_loan_term_year.Size = new System.Drawing.Size(172, 35);
            this.text_loan_term_year.TabIndex = 5;
            this.text_loan_term_year.Text = "5";
            // 
            // text_lending_rate_year
            // 
            this.text_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_lending_rate_year.Location = new System.Drawing.Point(426, 176);
            this.text_lending_rate_year.Name = "text_lending_rate_year";
            this.text_lending_rate_year.Size = new System.Drawing.Size(172, 35);
            this.text_lending_rate_year.TabIndex = 6;
            this.text_lending_rate_year.Text = "8";
            // 
            // text_down_payment
            // 
            this.text_down_payment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_down_payment.Location = new System.Drawing.Point(426, 236);
            this.text_down_payment.Name = "text_down_payment";
            this.text_down_payment.Size = new System.Drawing.Size(172, 35);
            this.text_down_payment.TabIndex = 7;
            this.text_down_payment.Text = "50000";
            // 
            // btn_PMT
            // 
            this.btn_PMT.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PMT.Location = new System.Drawing.Point(113, 363);
            this.btn_PMT.Name = "btn_PMT";
            this.btn_PMT.Size = new System.Drawing.Size(150, 50);
            this.btn_PMT.TabIndex = 8;
            this.btn_PMT.Text = "PMT(月付)";
            this.btn_PMT.UseVisualStyleBackColor = true;
            this.btn_PMT.Click += new System.EventHandler(this.btn_PMT_Click);
            // 
            // btn_total
            // 
            this.btn_total.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_total.Location = new System.Drawing.Point(334, 363);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(150, 50);
            this.btn_total.TabIndex = 9;
            this.btn_total.Text = "總付款";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(558, 363);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(150, 50);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "列印報告";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // M03_form_loancounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_PMT);
            this.Controls.Add(this.text_down_payment);
            this.Controls.Add(this.text_lending_rate_year);
            this.Controls.Add(this.text_loan_term_year);
            this.Controls.Add(this.text_loan_amount);
            this.Controls.Add(this.label_down_payment);
            this.Controls.Add(this.label_lending_rate_year);
            this.Controls.Add(this.label_loan_term_year);
            this.Controls.Add(this.label_loan_amout);
            this.Name = "M03_form_loancounter";
            this.Text = "loan counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loan_amout;
        private System.Windows.Forms.Label label_loan_term_year;
        private System.Windows.Forms.Label label_lending_rate_year;
        private System.Windows.Forms.Label label_down_payment;
        private System.Windows.Forms.TextBox text_loan_amount;
        private System.Windows.Forms.TextBox text_loan_term_year;
        private System.Windows.Forms.TextBox text_lending_rate_year;
        private System.Windows.Forms.TextBox text_down_payment;
        private System.Windows.Forms.Button btn_PMT;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_report;
    }
}