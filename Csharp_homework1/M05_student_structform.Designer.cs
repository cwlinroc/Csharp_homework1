namespace Csharp_homework1
{
    partial class M05_student_structform
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_chinese = new System.Windows.Forms.Label();
            this.label_english = new System.Windows.Forms.Label();
            this.label_math = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_chinesescore = new System.Windows.Forms.TextBox();
            this.text_englishscore = new System.Windows.Forms.TextBox();
            this.text_mathscore = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show_saved = new System.Windows.Forms.Button();
            this.btn_show_minmax = new System.Windows.Forms.Button();
            this.text_showdata = new System.Windows.Forms.TextBox();
            this.text_minmax = new System.Windows.Forms.TextBox();
            this.label_grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(129, 108);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(62, 31);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // label_chinese
            // 
            this.label_chinese.AutoSize = true;
            this.label_chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_chinese.Location = new System.Drawing.Point(129, 169);
            this.label_chinese.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chinese.Name = "label_chinese";
            this.label_chinese.Size = new System.Drawing.Size(62, 31);
            this.label_chinese.TabIndex = 1;
            this.label_chinese.Text = "國文";
            // 
            // label_english
            // 
            this.label_english.AutoSize = true;
            this.label_english.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_english.Location = new System.Drawing.Point(129, 239);
            this.label_english.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(62, 31);
            this.label_english.TabIndex = 2;
            this.label_english.Text = "英文";
            // 
            // label_math
            // 
            this.label_math.AutoSize = true;
            this.label_math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_math.Location = new System.Drawing.Point(129, 309);
            this.label_math.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_math.Name = "label_math";
            this.label_math.Size = new System.Drawing.Size(62, 31);
            this.label_math.TabIndex = 3;
            this.label_math.Text = "數學";
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_name.Location = new System.Drawing.Point(276, 104);
            this.text_name.Margin = new System.Windows.Forms.Padding(4);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(208, 39);
            this.text_name.TabIndex = 4;
            // 
            // text_chinesescore
            // 
            this.text_chinesescore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_chinesescore.Location = new System.Drawing.Point(276, 165);
            this.text_chinesescore.Margin = new System.Windows.Forms.Padding(4);
            this.text_chinesescore.Name = "text_chinesescore";
            this.text_chinesescore.Size = new System.Drawing.Size(208, 39);
            this.text_chinesescore.TabIndex = 5;
            this.text_chinesescore.Text = "0";
            // 
            // text_englishscore
            // 
            this.text_englishscore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_englishscore.Location = new System.Drawing.Point(276, 235);
            this.text_englishscore.Margin = new System.Windows.Forms.Padding(4);
            this.text_englishscore.Name = "text_englishscore";
            this.text_englishscore.Size = new System.Drawing.Size(208, 39);
            this.text_englishscore.TabIndex = 6;
            this.text_englishscore.Text = "0";
            // 
            // text_mathscore
            // 
            this.text_mathscore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text_mathscore.Location = new System.Drawing.Point(276, 305);
            this.text_mathscore.Margin = new System.Windows.Forms.Padding(4);
            this.text_mathscore.Name = "text_mathscore";
            this.text_mathscore.Size = new System.Drawing.Size(208, 39);
            this.text_mathscore.TabIndex = 7;
            this.text_mathscore.Text = "0";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(185, 435);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 29);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "button1";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show_saved
            // 
            this.btn_show_saved.Location = new System.Drawing.Point(385, 435);
            this.btn_show_saved.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show_saved.Name = "btn_show_saved";
            this.btn_show_saved.Size = new System.Drawing.Size(100, 29);
            this.btn_show_saved.TabIndex = 9;
            this.btn_show_saved.Text = "button2";
            this.btn_show_saved.UseVisualStyleBackColor = true;
            this.btn_show_saved.Click += new System.EventHandler(this.btn_show_saved_Click);
            // 
            // btn_show_minmax
            // 
            this.btn_show_minmax.Location = new System.Drawing.Point(799, 460);
            this.btn_show_minmax.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show_minmax.Name = "btn_show_minmax";
            this.btn_show_minmax.Size = new System.Drawing.Size(100, 29);
            this.btn_show_minmax.TabIndex = 10;
            this.btn_show_minmax.Text = "button3";
            this.btn_show_minmax.UseVisualStyleBackColor = true;
            this.btn_show_minmax.Click += new System.EventHandler(this.btn_show_minmax_Click);
            // 
            // text_showdata
            // 
            this.text_showdata.Location = new System.Drawing.Point(639, 104);
            this.text_showdata.Margin = new System.Windows.Forms.Padding(4);
            this.text_showdata.Multiline = true;
            this.text_showdata.Name = "text_showdata";
            this.text_showdata.ReadOnly = true;
            this.text_showdata.Size = new System.Drawing.Size(284, 146);
            this.text_showdata.TabIndex = 11;
            // 
            // text_minmax
            // 
            this.text_minmax.Location = new System.Drawing.Point(639, 259);
            this.text_minmax.Margin = new System.Windows.Forms.Padding(4);
            this.text_minmax.Multiline = true;
            this.text_minmax.Name = "text_minmax";
            this.text_minmax.ReadOnly = true;
            this.text_minmax.Size = new System.Drawing.Size(284, 129);
            this.text_minmax.TabIndex = 12;
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Location = new System.Drawing.Point(649, 60);
            this.label_grade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(41, 15);
            this.label_grade.TabIndex = 13;
            this.label_grade.Text = "label5";
            // 
            // M05_student_structform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.text_minmax);
            this.Controls.Add(this.text_showdata);
            this.Controls.Add(this.btn_show_minmax);
            this.Controls.Add(this.btn_show_saved);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.text_mathscore);
            this.Controls.Add(this.text_englishscore);
            this.Controls.Add(this.text_chinesescore);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label_math);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.label_chinese);
            this.Controls.Add(this.label_name);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "M05_student_structform";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_chinese;
        private System.Windows.Forms.Label label_english;
        private System.Windows.Forms.Label label_math;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_chinesescore;
        private System.Windows.Forms.TextBox text_englishscore;
        private System.Windows.Forms.TextBox text_mathscore;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show_saved;
        private System.Windows.Forms.Button btn_show_minmax;
        private System.Windows.Forms.TextBox text_showdata;
        private System.Windows.Forms.TextBox text_minmax;
        private System.Windows.Forms.Label label_grade;
    }
}