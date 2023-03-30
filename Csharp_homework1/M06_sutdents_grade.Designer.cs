using System.Windows.Forms;

namespace Csharp_homework1
{
    partial class M06_sutdents_grade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_name = new System.Windows.Forms.Label();
            this.label_chinesescore = new System.Windows.Forms.Label();
            this.label_englishscore = new System.Windows.Forms.Label();
            this.label_mathscore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_add_studentsdata = new System.Windows.Forms.Button();
            this.btn_add_randomdata = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn_add_20randomdata = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_statisticboard = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listview_scoreboard = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listview_scoreboard);
            this.panel1.Location = new System.Drawing.Point(315, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 280);
            this.panel1.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 12);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 12);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "姓名";
            // 
            // label_chinesescore
            // 
            this.label_chinesescore.AutoSize = true;
            this.label_chinesescore.Location = new System.Drawing.Point(6, 65);
            this.label_chinesescore.Name = "label_chinesescore";
            this.label_chinesescore.Size = new System.Drawing.Size(29, 12);
            this.label_chinesescore.TabIndex = 3;
            this.label_chinesescore.Text = "國文";
            // 
            // label_englishscore
            // 
            this.label_englishscore.AutoSize = true;
            this.label_englishscore.Location = new System.Drawing.Point(6, 117);
            this.label_englishscore.Name = "label_englishscore";
            this.label_englishscore.Size = new System.Drawing.Size(29, 12);
            this.label_englishscore.TabIndex = 4;
            this.label_englishscore.Text = "英文";
            // 
            // label_mathscore
            // 
            this.label_mathscore.AutoSize = true;
            this.label_mathscore.Location = new System.Drawing.Point(6, 169);
            this.label_mathscore.Name = "label_mathscore";
            this.label_mathscore.Size = new System.Drawing.Size(29, 12);
            this.label_mathscore.TabIndex = 5;
            this.label_mathscore.Text = "數學";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(83, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(83, 22);
            this.textBox4.TabIndex = 9;
            // 
            // btn_add_studentsdata
            // 
            this.btn_add_studentsdata.Location = new System.Drawing.Point(12, 11);
            this.btn_add_studentsdata.Name = "btn_add_studentsdata";
            this.btn_add_studentsdata.Size = new System.Drawing.Size(178, 21);
            this.btn_add_studentsdata.TabIndex = 10;
            this.btn_add_studentsdata.Text = "加入學生資料";
            this.btn_add_studentsdata.UseVisualStyleBackColor = true;
            // 
            // btn_add_randomdata
            // 
            this.btn_add_randomdata.Location = new System.Drawing.Point(12, 48);
            this.btn_add_randomdata.Name = "btn_add_randomdata";
            this.btn_add_randomdata.Size = new System.Drawing.Size(178, 21);
            this.btn_add_randomdata.TabIndex = 11;
            this.btn_add_randomdata.Text = "隨機儲存資料";
            this.btn_add_randomdata.UseVisualStyleBackColor = true;
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(12, 79);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(178, 21);
            this.btn_statistic.TabIndex = 12;
            this.btn_statistic.Text = "各科統計";
            this.btn_statistic.UseVisualStyleBackColor = true;
            // 
            // btn_clearall
            // 
            this.btn_clearall.Location = new System.Drawing.Point(8, 127);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(178, 21);
            this.btn_clearall.TabIndex = 13;
            this.btn_clearall.Text = "重設所有資料";
            this.btn_clearall.UseVisualStyleBackColor = true;
            // 
            // btn_add_20randomdata
            // 
            this.btn_add_20randomdata.Location = new System.Drawing.Point(8, 171);
            this.btn_add_20randomdata.Name = "btn_add_20randomdata";
            this.btn_add_20randomdata.Size = new System.Drawing.Size(178, 21);
            this.btn_add_20randomdata.TabIndex = 14;
            this.btn_add_20randomdata.Text = "隨機加入20筆資料";
            this.btn_add_20randomdata.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_mathscore);
            this.groupBox1.Controls.Add(this.label_englishscore);
            this.groupBox1.Controls.Add(this.label_chinesescore);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(20, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_statisticboard);
            this.panel2.Location = new System.Drawing.Point(317, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 121);
            this.panel2.TabIndex = 16;
            // 
            // textBox_statisticboard
            // 
            this.textBox_statisticboard.Location = new System.Drawing.Point(27, 17);
            this.textBox_statisticboard.Name = "textBox_statisticboard";
            this.textBox_statisticboard.Size = new System.Drawing.Size(372, 22);
            this.textBox_statisticboard.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_20randomdata);
            this.groupBox2.Controls.Add(this.btn_clearall);
            this.groupBox2.Controls.Add(this.btn_statistic);
            this.groupBox2.Controls.Add(this.btn_add_randomdata);
            this.groupBox2.Controls.Add(this.btn_add_studentsdata);
            this.groupBox2.Location = new System.Drawing.Point(20, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 199);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // listview_scoreboard
            // 
            this.listview_scoreboard.HideSelection = false;
            this.listview_scoreboard.Location = new System.Drawing.Point(29, 38);
            this.listview_scoreboard.Name = "listview_scoreboard";
            this.listview_scoreboard.Size = new System.Drawing.Size(384, 218);
            this.listview_scoreboard.TabIndex = 18;
            this.listview_scoreboard.UseCompatibleStateImageBehavior = false;
            // 
            // M06_sutdents_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "M06_sutdents_grade";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_chinesescore;
        private System.Windows.Forms.Label label_englishscore;
        private System.Windows.Forms.Label label_mathscore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btn_add_studentsdata;
        private System.Windows.Forms.Button btn_add_randomdata;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn_add_20randomdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_statisticboard;
        private System.Windows.Forms.GroupBox groupBox2;
        private ListView listview_scoreboard;
    }
}