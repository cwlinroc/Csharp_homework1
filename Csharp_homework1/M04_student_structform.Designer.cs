namespace Csharp_homework1
{
    partial class M04_student_structform
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
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_chinesescore = new System.Windows.Forms.TextBox();
            this.textbox_englishscore = new System.Windows.Forms.TextBox();
            this.textbox_mathscore = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_show_saved = new System.Windows.Forms.Button();
            this.btn_show_minmax = new System.Windows.Forms.Button();
            this.textbox_showdata = new System.Windows.Forms.TextBox();
            this.textbox_minmax = new System.Windows.Forms.TextBox();
            this.label_grade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(97, 86);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 24);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // label_chinese
            // 
            this.label_chinese.AutoSize = true;
            this.label_chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_chinese.Location = new System.Drawing.Point(97, 135);
            this.label_chinese.Name = "label_chinese";
            this.label_chinese.Size = new System.Drawing.Size(48, 24);
            this.label_chinese.TabIndex = 1;
            this.label_chinese.Text = "國文";
            // 
            // label_english
            // 
            this.label_english.AutoSize = true;
            this.label_english.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_english.Location = new System.Drawing.Point(97, 191);
            this.label_english.Name = "label_english";
            this.label_english.Size = new System.Drawing.Size(48, 24);
            this.label_english.TabIndex = 2;
            this.label_english.Text = "英文";
            // 
            // label_math
            // 
            this.label_math.AutoSize = true;
            this.label_math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_math.Location = new System.Drawing.Point(97, 247);
            this.label_math.Name = "label_math";
            this.label_math.Size = new System.Drawing.Size(48, 24);
            this.label_math.TabIndex = 3;
            this.label_math.Text = "數學";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_name.Location = new System.Drawing.Point(207, 83);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(157, 33);
            this.textbox_name.TabIndex = 4;
            // 
            // textbox_chinesescore
            // 
            this.textbox_chinesescore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_chinesescore.Location = new System.Drawing.Point(207, 132);
            this.textbox_chinesescore.Name = "textbox_chinesescore";
            this.textbox_chinesescore.Size = new System.Drawing.Size(157, 33);
            this.textbox_chinesescore.TabIndex = 5;
            this.textbox_chinesescore.Text = "0";
            // 
            // textbox_englishscore
            // 
            this.textbox_englishscore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_englishscore.Location = new System.Drawing.Point(207, 188);
            this.textbox_englishscore.Name = "textbox_englishscore";
            this.textbox_englishscore.Size = new System.Drawing.Size(157, 33);
            this.textbox_englishscore.TabIndex = 6;
            this.textbox_englishscore.Text = "0";
            // 
            // textbox_mathscore
            // 
            this.textbox_mathscore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_mathscore.Location = new System.Drawing.Point(207, 244);
            this.textbox_mathscore.Name = "textbox_mathscore";
            this.textbox_mathscore.Size = new System.Drawing.Size(157, 33);
            this.textbox_mathscore.TabIndex = 7;
            this.textbox_mathscore.Text = "0";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_save.Location = new System.Drawing.Point(109, 335);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(105, 54);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "儲存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_show_saved
            // 
            this.btn_show_saved.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show_saved.Location = new System.Drawing.Point(259, 335);
            this.btn_show_saved.Name = "btn_show_saved";
            this.btn_show_saved.Size = new System.Drawing.Size(105, 54);
            this.btn_show_saved.TabIndex = 9;
            this.btn_show_saved.Text = "顯示儲存內容";
            this.btn_show_saved.UseVisualStyleBackColor = true;
            this.btn_show_saved.Click += new System.EventHandler(this.btn_show_saved_Click);
            // 
            // btn_show_minmax
            // 
            this.btn_show_minmax.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_show_minmax.Location = new System.Drawing.Point(560, 358);
            this.btn_show_minmax.Name = "btn_show_minmax";
            this.btn_show_minmax.Size = new System.Drawing.Size(133, 54);
            this.btn_show_minmax.TabIndex = 10;
            this.btn_show_minmax.Text = "最低分/最高分科目";
            this.btn_show_minmax.UseVisualStyleBackColor = true;
            this.btn_show_minmax.Click += new System.EventHandler(this.btn_show_minmax_Click);
            // 
            // textbox_showdata
            // 
            this.textbox_showdata.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_showdata.Location = new System.Drawing.Point(479, 83);
            this.textbox_showdata.Multiline = true;
            this.textbox_showdata.Name = "textbox_showdata";
            this.textbox_showdata.ReadOnly = true;
            this.textbox_showdata.Size = new System.Drawing.Size(214, 118);
            this.textbox_showdata.TabIndex = 11;
            // 
            // textbox_minmax
            // 
            this.textbox_minmax.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_minmax.Location = new System.Drawing.Point(479, 207);
            this.textbox_minmax.Multiline = true;
            this.textbox_minmax.Name = "textbox_minmax";
            this.textbox_minmax.ReadOnly = true;
            this.textbox_minmax.Size = new System.Drawing.Size(214, 104);
            this.textbox_minmax.TabIndex = 12;
            // 
            // label_grade
            // 
            this.label_grade.AutoSize = true;
            this.label_grade.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_grade.Location = new System.Drawing.Point(475, 48);
            this.label_grade.Name = "label_grade";
            this.label_grade.Size = new System.Drawing.Size(54, 21);
            this.label_grade.TabIndex = 13;
            this.label_grade.Text = "成績";
            // 
            // M05_student_structform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_grade);
            this.Controls.Add(this.textbox_minmax);
            this.Controls.Add(this.textbox_showdata);
            this.Controls.Add(this.btn_show_minmax);
            this.Controls.Add(this.btn_show_saved);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textbox_mathscore);
            this.Controls.Add(this.textbox_englishscore);
            this.Controls.Add(this.textbox_chinesescore);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_math);
            this.Controls.Add(this.label_english);
            this.Controls.Add(this.label_chinese);
            this.Controls.Add(this.label_name);
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
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_chinesescore;
        private System.Windows.Forms.TextBox textbox_englishscore;
        private System.Windows.Forms.TextBox textbox_mathscore;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_show_saved;
        private System.Windows.Forms.Button btn_show_minmax;
        private System.Windows.Forms.TextBox textbox_showdata;
        private System.Windows.Forms.TextBox textbox_minmax;
        private System.Windows.Forms.Label label_grade;
    }
}