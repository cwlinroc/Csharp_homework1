namespace Csharp_homework1
{
    partial class form_M02_loancounter
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
            this.textbox_loan_amount = new System.Windows.Forms.TextBox();
            this.textbox_loan_term_year = new System.Windows.Forms.TextBox();
            this.textbox_lending_rate_year = new System.Windows.Forms.TextBox();
            this.textbox_down_payment = new System.Windows.Forms.TextBox();
            this.btn_PMT = new System.Windows.Forms.Button();
            this.btn_total = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_loan_amout
            // 
            this.label_loan_amout.AutoSize = true;
            this.label_loan_amout.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_amout.Location = new System.Drawing.Point(236, 78);
            this.label_loan_amout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loan_amout.Name = "label_loan_amout";
            this.label_loan_amout.Size = new System.Drawing.Size(123, 34);
            this.label_loan_amout.TabIndex = 0;
            this.label_loan_amout.Text = "貸款金額";
            // 
            // label_loan_term_year
            // 
            this.label_loan_term_year.AutoSize = true;
            this.label_loan_term_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_loan_term_year.Location = new System.Drawing.Point(236, 155);
            this.label_loan_term_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loan_term_year.Name = "label_loan_term_year";
            this.label_loan_term_year.Size = new System.Drawing.Size(114, 34);
            this.label_loan_term_year.TabIndex = 1;
            this.label_loan_term_year.Text = "期限(年)";
            // 
            // label_lending_rate_year
            // 
            this.label_lending_rate_year.AutoSize = true;
            this.label_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_lending_rate_year.Location = new System.Drawing.Point(236, 230);
            this.label_lending_rate_year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_lending_rate_year.Name = "label_lending_rate_year";
            this.label_lending_rate_year.Size = new System.Drawing.Size(111, 34);
            this.label_lending_rate_year.TabIndex = 2;
            this.label_lending_rate_year.Text = "利率(%)";
            // 
            // label_down_payment
            // 
            this.label_down_payment.AutoSize = true;
            this.label_down_payment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_down_payment.Location = new System.Drawing.Point(236, 305);
            this.label_down_payment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_down_payment.Name = "label_down_payment";
            this.label_down_payment.Size = new System.Drawing.Size(96, 34);
            this.label_down_payment.TabIndex = 3;
            this.label_down_payment.Text = "頭期款";
            // 
            // textbox_loan_amount
            // 
            this.textbox_loan_amount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_amount.Location = new System.Drawing.Point(568, 68);
            this.textbox_loan_amount.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_loan_amount.Name = "textbox_loan_amount";
            this.textbox_loan_amount.Size = new System.Drawing.Size(228, 42);
            this.textbox_loan_amount.TabIndex = 4;
            this.textbox_loan_amount.Text = "1000000";
            // 
            // textbox_loan_term_year
            // 
            this.textbox_loan_term_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_loan_term_year.Location = new System.Drawing.Point(568, 145);
            this.textbox_loan_term_year.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_loan_term_year.Name = "textbox_loan_term_year";
            this.textbox_loan_term_year.Size = new System.Drawing.Size(228, 42);
            this.textbox_loan_term_year.TabIndex = 5;
            this.textbox_loan_term_year.Text = "5";
            // 
            // textbox_lending_rate_year
            // 
            this.textbox_lending_rate_year.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_lending_rate_year.Location = new System.Drawing.Point(568, 220);
            this.textbox_lending_rate_year.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_lending_rate_year.Name = "textbox_lending_rate_year";
            this.textbox_lending_rate_year.Size = new System.Drawing.Size(228, 42);
            this.textbox_lending_rate_year.TabIndex = 6;
            this.textbox_lending_rate_year.Text = "8";
            // 
            // textbox_down_payment
            // 
            this.textbox_down_payment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_down_payment.Location = new System.Drawing.Point(568, 295);
            this.textbox_down_payment.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_down_payment.Name = "textbox_down_payment";
            this.textbox_down_payment.Size = new System.Drawing.Size(228, 42);
            this.textbox_down_payment.TabIndex = 7;
            this.textbox_down_payment.Text = "50000";
            // 
            // btn_PMT
            // 
            this.btn_PMT.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_PMT.Location = new System.Drawing.Point(151, 454);
            this.btn_PMT.Margin = new System.Windows.Forms.Padding(4);
            this.btn_PMT.Name = "btn_PMT";
            this.btn_PMT.Size = new System.Drawing.Size(200, 62);
            this.btn_PMT.TabIndex = 8;
            this.btn_PMT.Text = "PMT(月付)";
            this.btn_PMT.UseVisualStyleBackColor = true;
            this.btn_PMT.Click += new System.EventHandler(this.btn_PMT_Click);
            // 
            // btn_total
            // 
            this.btn_total.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_total.Location = new System.Drawing.Point(445, 454);
            this.btn_total.Margin = new System.Windows.Forms.Padding(4);
            this.btn_total.Name = "btn_total";
            this.btn_total.Size = new System.Drawing.Size(200, 62);
            this.btn_total.TabIndex = 9;
            this.btn_total.Text = "總付款";
            this.btn_total.UseVisualStyleBackColor = true;
            this.btn_total.Click += new System.EventHandler(this.btn_total_Click);
            // 
            // btn_report
            // 
            this.btn_report.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_report.Location = new System.Drawing.Point(744, 454);
            this.btn_report.Margin = new System.Windows.Forms.Padding(4);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(200, 62);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "列印報告";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // form_M02_loancounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_total);
            this.Controls.Add(this.btn_PMT);
            this.Controls.Add(this.textbox_down_payment);
            this.Controls.Add(this.textbox_lending_rate_year);
            this.Controls.Add(this.textbox_loan_term_year);
            this.Controls.Add(this.textbox_loan_amount);
            this.Controls.Add(this.label_down_payment);
            this.Controls.Add(this.label_lending_rate_year);
            this.Controls.Add(this.label_loan_term_year);
            this.Controls.Add(this.label_loan_amout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_M02_loancounter";
            this.Text = "loan counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_loan_amout;
        private System.Windows.Forms.Label label_loan_term_year;
        private System.Windows.Forms.Label label_lending_rate_year;
        private System.Windows.Forms.Label label_down_payment;
        private System.Windows.Forms.TextBox textbox_loan_amount;
        private System.Windows.Forms.TextBox textbox_loan_term_year;
        private System.Windows.Forms.TextBox textbox_lending_rate_year;
        private System.Windows.Forms.TextBox textbox_down_payment;
        private System.Windows.Forms.Button btn_PMT;
        private System.Windows.Forms.Button btn_total;
        private System.Windows.Forms.Button btn_report;
    }
}