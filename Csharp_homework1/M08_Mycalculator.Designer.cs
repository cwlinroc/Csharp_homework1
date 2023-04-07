namespace Csharp_homework1
{
    partial class form_M08_Mycalculator
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
            this.textbox_num1 = new System.Windows.Forms.TextBox();
            this.textbox_num2 = new System.Windows.Forms.TextBox();
            this.textbox_answer = new System.Windows.Forms.TextBox();
            this.btn_addition = new System.Windows.Forms.Button();
            this.btn_subtraction = new System.Windows.Forms.Button();
            this.btn_multiplication = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.label_num1 = new System.Windows.Forms.Label();
            this.label_num2 = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_equalline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_num1
            // 
            this.textbox_num1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_num1.Location = new System.Drawing.Point(127, 67);
            this.textbox_num1.Name = "textbox_num1";
            this.textbox_num1.Size = new System.Drawing.Size(109, 31);
            this.textbox_num1.TabIndex = 0;
            // 
            // textbox_num2
            // 
            this.textbox_num2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_num2.Location = new System.Drawing.Point(127, 175);
            this.textbox_num2.Name = "textbox_num2";
            this.textbox_num2.Size = new System.Drawing.Size(109, 31);
            this.textbox_num2.TabIndex = 1;
            // 
            // textbox_answer
            // 
            this.textbox_answer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_answer.Location = new System.Drawing.Point(127, 338);
            this.textbox_answer.Name = "textbox_answer";
            this.textbox_answer.ReadOnly = true;
            this.textbox_answer.Size = new System.Drawing.Size(131, 31);
            this.textbox_answer.TabIndex = 2;
            // 
            // btn_addition
            // 
            this.btn_addition.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_addition.Location = new System.Drawing.Point(318, 60);
            this.btn_addition.Name = "btn_addition";
            this.btn_addition.Size = new System.Drawing.Size(174, 47);
            this.btn_addition.TabIndex = 3;
            this.btn_addition.Text = "+=";
            this.btn_addition.UseVisualStyleBackColor = true;
            this.btn_addition.Click += new System.EventHandler(this.btn_addition_Click);
            // 
            // btn_subtraction
            // 
            this.btn_subtraction.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_subtraction.Location = new System.Drawing.Point(318, 146);
            this.btn_subtraction.Name = "btn_subtraction";
            this.btn_subtraction.Size = new System.Drawing.Size(174, 47);
            this.btn_subtraction.TabIndex = 4;
            this.btn_subtraction.Text = "-=";
            this.btn_subtraction.UseVisualStyleBackColor = true;
            this.btn_subtraction.Click += new System.EventHandler(this.btn_subtraction_Click);
            // 
            // btn_multiplication
            // 
            this.btn_multiplication.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_multiplication.Location = new System.Drawing.Point(318, 234);
            this.btn_multiplication.Name = "btn_multiplication";
            this.btn_multiplication.Size = new System.Drawing.Size(174, 47);
            this.btn_multiplication.TabIndex = 5;
            this.btn_multiplication.Text = "*=";
            this.btn_multiplication.UseVisualStyleBackColor = true;
            this.btn_multiplication.Click += new System.EventHandler(this.btn_multiplication_Click);
            // 
            // btn_division
            // 
            this.btn_division.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_division.Location = new System.Drawing.Point(318, 322);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(174, 47);
            this.btn_division.TabIndex = 6;
            this.btn_division.Text = "/=";
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // label_num1
            // 
            this.label_num1.AutoSize = true;
            this.label_num1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_num1.Location = new System.Drawing.Point(31, 70);
            this.label_num1.Name = "label_num1";
            this.label_num1.Size = new System.Drawing.Size(76, 20);
            this.label_num1.TabIndex = 7;
            this.label_num1.Text = "Num1：";
            // 
            // label_num2
            // 
            this.label_num2.AutoSize = true;
            this.label_num2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_num2.Location = new System.Drawing.Point(31, 178);
            this.label_num2.Name = "label_num2";
            this.label_num2.Size = new System.Drawing.Size(76, 20);
            this.label_num2.TabIndex = 8;
            this.label_num2.Text = "Num2：";
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_answer.Location = new System.Drawing.Point(31, 341);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(87, 20);
            this.label_answer.TabIndex = 9;
            this.label_answer.Text = "Answer：";
            // 
            // label_equalline
            // 
            this.label_equalline.AutoSize = true;
            this.label_equalline.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_equalline.Location = new System.Drawing.Point(46, 259);
            this.label_equalline.Name = "label_equalline";
            this.label_equalline.Size = new System.Drawing.Size(265, 20);
            this.label_equalline.TabIndex = 10;
            this.label_equalline.Text = "= = = = = = = = = = = = = = = = ";
            // 
            // form_M08_Mycalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_equalline);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_num2);
            this.Controls.Add(this.label_num1);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_multiplication);
            this.Controls.Add(this.btn_subtraction);
            this.Controls.Add(this.btn_addition);
            this.Controls.Add(this.textbox_answer);
            this.Controls.Add(this.textbox_num2);
            this.Controls.Add(this.textbox_num1);
            this.Name = "form_M08_Mycalculator";
            this.Text = "My Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_num1;
        private System.Windows.Forms.TextBox textbox_num2;
        private System.Windows.Forms.TextBox textbox_answer;
        private System.Windows.Forms.Button btn_addition;
        private System.Windows.Forms.Button btn_subtraction;
        private System.Windows.Forms.Button btn_multiplication;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Label label_num1;
        private System.Windows.Forms.Label label_num2;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_equalline;
    }
}