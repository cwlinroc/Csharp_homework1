﻿using System.Windows.Forms;

namespace Csharp_homework1
{
    partial class form_M05_sutdents_grade
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "姓名",
            "國文",
            "英文",
            "數學",
            "總分",
            "平均",
            "最高",
            "最低"}, -1);
            this.label_name = new System.Windows.Forms.Label();
            this.label_chinesescore = new System.Windows.Forms.Label();
            this.label_englishscore = new System.Windows.Forms.Label();
            this.label_mathscore = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_chinesescore = new System.Windows.Forms.TextBox();
            this.textBox_englishscore = new System.Windows.Forms.TextBox();
            this.textBox_mathscore = new System.Windows.Forms.TextBox();
            this.btn_add_studentsdata = new System.Windows.Forms.Button();
            this.btn_add_randomdata = new System.Windows.Forms.Button();
            this.btn_statistic = new System.Windows.Forms.Button();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn_add_20randomdata = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listview_scoreboard = new System.Windows.Forms.ListView();
            this.listview_statistic = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView_header = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(8, 18);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "姓名";
            // 
            // label_chinesescore
            // 
            this.label_chinesescore.AutoSize = true;
            this.label_chinesescore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_chinesescore.Location = new System.Drawing.Point(8, 69);
            this.label_chinesescore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_chinesescore.Name = "label_chinesescore";
            this.label_chinesescore.Size = new System.Drawing.Size(49, 20);
            this.label_chinesescore.TabIndex = 3;
            this.label_chinesescore.Text = "國文";
            // 
            // label_englishscore
            // 
            this.label_englishscore.AutoSize = true;
            this.label_englishscore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_englishscore.Location = new System.Drawing.Point(8, 122);
            this.label_englishscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_englishscore.Name = "label_englishscore";
            this.label_englishscore.Size = new System.Drawing.Size(49, 20);
            this.label_englishscore.TabIndex = 4;
            this.label_englishscore.Text = "英文";
            // 
            // label_mathscore
            // 
            this.label_mathscore.AutoSize = true;
            this.label_mathscore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_mathscore.Location = new System.Drawing.Point(8, 172);
            this.label_mathscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_mathscore.Name = "label_mathscore";
            this.label_mathscore.Size = new System.Drawing.Size(49, 20);
            this.label_mathscore.TabIndex = 5;
            this.label_mathscore.Text = "數學";
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_name.Location = new System.Drawing.Point(92, 15);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(127, 31);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_chinesescore
            // 
            this.textBox_chinesescore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_chinesescore.Location = new System.Drawing.Point(92, 66);
            this.textBox_chinesescore.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_chinesescore.Name = "textBox_chinesescore";
            this.textBox_chinesescore.Size = new System.Drawing.Size(127, 31);
            this.textBox_chinesescore.TabIndex = 7;
            // 
            // textBox_englishscore
            // 
            this.textBox_englishscore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_englishscore.Location = new System.Drawing.Point(92, 119);
            this.textBox_englishscore.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_englishscore.Name = "textBox_englishscore";
            this.textBox_englishscore.Size = new System.Drawing.Size(127, 31);
            this.textBox_englishscore.TabIndex = 8;
            // 
            // textBox_mathscore
            // 
            this.textBox_mathscore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_mathscore.Location = new System.Drawing.Point(92, 170);
            this.textBox_mathscore.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_mathscore.Name = "textBox_mathscore";
            this.textBox_mathscore.Size = new System.Drawing.Size(127, 31);
            this.textBox_mathscore.TabIndex = 9;
            // 
            // btn_add_studentsdata
            // 
            this.btn_add_studentsdata.Location = new System.Drawing.Point(12, 14);
            this.btn_add_studentsdata.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_studentsdata.Name = "btn_add_studentsdata";
            this.btn_add_studentsdata.Size = new System.Drawing.Size(229, 40);
            this.btn_add_studentsdata.TabIndex = 10;
            this.btn_add_studentsdata.Text = "加入學生資料";
            this.btn_add_studentsdata.UseVisualStyleBackColor = true;
            this.btn_add_studentsdata.Click += new System.EventHandler(this.btn_add_studentsdata_Click);
            // 
            // btn_add_randomdata
            // 
            this.btn_add_randomdata.Location = new System.Drawing.Point(12, 62);
            this.btn_add_randomdata.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_randomdata.Name = "btn_add_randomdata";
            this.btn_add_randomdata.Size = new System.Drawing.Size(229, 40);
            this.btn_add_randomdata.TabIndex = 11;
            this.btn_add_randomdata.Text = "隨機儲存資料";
            this.btn_add_randomdata.UseVisualStyleBackColor = true;
            this.btn_add_randomdata.Click += new System.EventHandler(this.btn_add_randomdata_Click);
            // 
            // btn_statistic
            // 
            this.btn_statistic.Location = new System.Drawing.Point(12, 110);
            this.btn_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.Size = new System.Drawing.Size(229, 40);
            this.btn_statistic.TabIndex = 12;
            this.btn_statistic.Text = "各科統計";
            this.btn_statistic.UseVisualStyleBackColor = true;
            this.btn_statistic.Click += new System.EventHandler(this.btn_statistic_Click);
            // 
            // btn_clearall
            // 
            this.btn_clearall.Location = new System.Drawing.Point(12, 196);
            this.btn_clearall.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(229, 40);
            this.btn_clearall.TabIndex = 13;
            this.btn_clearall.Text = "重設所有資料";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // btn_add_20randomdata
            // 
            this.btn_add_20randomdata.Location = new System.Drawing.Point(12, 244);
            this.btn_add_20randomdata.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_20randomdata.Name = "btn_add_20randomdata";
            this.btn_add_20randomdata.Size = new System.Drawing.Size(229, 40);
            this.btn_add_20randomdata.TabIndex = 14;
            this.btn_add_20randomdata.Text = "隨機加入20筆資料";
            this.btn_add_20randomdata.UseVisualStyleBackColor = true;
            this.btn_add_20randomdata.Click += new System.EventHandler(this.btn_add_20randomdata_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_mathscore);
            this.groupBox1.Controls.Add(this.textBox_englishscore);
            this.groupBox1.Controls.Add(this.textBox_chinesescore);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label_mathscore);
            this.groupBox1.Controls.Add(this.label_englishscore);
            this.groupBox1.Controls.Add(this.label_chinesescore);
            this.groupBox1.Controls.Add(this.label_name);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(248, 219);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_add_20randomdata);
            this.groupBox2.Controls.Add(this.btn_clearall);
            this.groupBox2.Controls.Add(this.btn_statistic);
            this.groupBox2.Controls.Add(this.btn_add_randomdata);
            this.groupBox2.Controls.Add(this.btn_add_studentsdata);
            this.groupBox2.Location = new System.Drawing.Point(27, 265);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(285, 292);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // listview_scoreboard
            // 
            this.listview_scoreboard.BackColor = System.Drawing.SystemColors.Control;
            this.listview_scoreboard.FullRowSelect = true;
            this.listview_scoreboard.GridLines = true;
            this.listview_scoreboard.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listview_scoreboard.HideSelection = false;
            this.listview_scoreboard.Location = new System.Drawing.Point(4, 34);
            this.listview_scoreboard.Margin = new System.Windows.Forms.Padding(4);
            this.listview_scoreboard.Name = "listview_scoreboard";
            this.listview_scoreboard.ShowGroups = false;
            this.listview_scoreboard.Size = new System.Drawing.Size(696, 366);
            this.listview_scoreboard.TabIndex = 18;
            this.listview_scoreboard.UseCompatibleStateImageBehavior = false;
            this.listview_scoreboard.View = System.Windows.Forms.View.Details;
            // 
            // listview_statistic
            // 
            this.listview_statistic.BackColor = System.Drawing.SystemColors.Control;
            this.listview_statistic.BackgroundImageTiled = true;
            this.listview_statistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listview_statistic.FullRowSelect = true;
            this.listview_statistic.GridLines = true;
            this.listview_statistic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listview_statistic.HideSelection = false;
            this.listview_statistic.Location = new System.Drawing.Point(4, 4);
            this.listview_statistic.Margin = new System.Windows.Forms.Padding(4);
            this.listview_statistic.Name = "listview_statistic";
            this.listview_statistic.Size = new System.Drawing.Size(696, 96);
            this.listview_statistic.TabIndex = 19;
            this.listview_statistic.UseCompatibleStateImageBehavior = false;
            this.listview_statistic.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.listView_header);
            this.panel1.Controls.Add(this.listview_scoreboard);
            this.panel1.Location = new System.Drawing.Point(320, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 403);
            this.panel1.TabIndex = 1;
            // 
            // listView_header
            // 
            this.listView_header.BackColor = System.Drawing.SystemColors.Control;
            this.listView_header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_header.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView_header.FullRowSelect = true;
            this.listView_header.GridLines = true;
            this.listView_header.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView_header.HideSelection = false;
            this.listView_header.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_header.Location = new System.Drawing.Point(4, 4);
            this.listView_header.Margin = new System.Windows.Forms.Padding(4);
            this.listView_header.Name = "listView_header";
            this.listView_header.ShowGroups = false;
            this.listView_header.Size = new System.Drawing.Size(697, 22);
            this.listView_header.TabIndex = 19;
            this.listView_header.UseCompatibleStateImageBehavior = false;
            this.listView_header.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 50;
            // 
            // columnHeader7
            // 
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader9.Width = 50;
            // 
            // columnHeader10
            // 
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Width = 70;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listview_statistic);
            this.panel2.Location = new System.Drawing.Point(320, 449);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 98);
            this.panel2.TabIndex = 20;
            // 
            // form_M05_sutdents_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form_M05_sutdents_grade";
            this.Text = "成績系統2.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_chinesescore;
        private System.Windows.Forms.Label label_englishscore;
        private System.Windows.Forms.Label label_mathscore;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_chinesescore;
        private System.Windows.Forms.TextBox textBox_englishscore;
        private System.Windows.Forms.TextBox textBox_mathscore;
        private System.Windows.Forms.Button btn_add_studentsdata;
        private System.Windows.Forms.Button btn_add_randomdata;
        private System.Windows.Forms.Button btn_statistic;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn_add_20randomdata;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ListView listview_scoreboard;
        private ListView listview_statistic;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Panel panel1;
        private Panel panel2;
        private ListView listView_header;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}