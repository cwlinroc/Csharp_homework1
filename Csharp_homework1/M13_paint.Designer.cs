namespace Csharp_homework1
{
    partial class form_M13_paint
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_changecolor = new System.Windows.Forms.Button();
            this.btn_showcolor = new System.Windows.Forms.Button();
            this.trackBar_penwidth = new System.Windows.Forms.TrackBar();
            this.label_trackbarvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_penwidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 566);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btn_changecolor
            // 
            this.btn_changecolor.Location = new System.Drawing.Point(695, 45);
            this.btn_changecolor.Name = "btn_changecolor";
            this.btn_changecolor.Size = new System.Drawing.Size(85, 43);
            this.btn_changecolor.TabIndex = 2;
            this.btn_changecolor.Text = "顏色";
            this.btn_changecolor.UseVisualStyleBackColor = true;
            this.btn_changecolor.Click += new System.EventHandler(this.btn_changecolor_Click);
            // 
            // btn_showcolor
            // 
            this.btn_showcolor.BackColor = System.Drawing.Color.Black;
            this.btn_showcolor.Enabled = false;
            this.btn_showcolor.Location = new System.Drawing.Point(695, 111);
            this.btn_showcolor.Name = "btn_showcolor";
            this.btn_showcolor.Size = new System.Drawing.Size(84, 49);
            this.btn_showcolor.TabIndex = 3;
            this.btn_showcolor.UseVisualStyleBackColor = false;
            // 
            // trackBar_penwidth
            // 
            this.trackBar_penwidth.Location = new System.Drawing.Point(707, 184);
            this.trackBar_penwidth.Maximum = 100;
            this.trackBar_penwidth.Minimum = 1;
            this.trackBar_penwidth.Name = "trackBar_penwidth";
            this.trackBar_penwidth.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_penwidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_penwidth.Size = new System.Drawing.Size(56, 251);
            this.trackBar_penwidth.TabIndex = 4;
            this.trackBar_penwidth.Value = 1;
            this.trackBar_penwidth.ValueChanged += new System.EventHandler(this.trackBar_penwidth_ValueChanged);
            // 
            // label_trackbarvalue
            // 
            this.label_trackbarvalue.AutoSize = true;
            this.label_trackbarvalue.Location = new System.Drawing.Point(712, 436);
            this.label_trackbarvalue.Name = "label_trackbarvalue";
            this.label_trackbarvalue.Size = new System.Drawing.Size(14, 15);
            this.label_trackbarvalue.TabIndex = 5;
            this.label_trackbarvalue.Text = "1";
            // 
            // form_M13_paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 566);
            this.Controls.Add(this.label_trackbarvalue);
            this.Controls.Add(this.trackBar_penwidth);
            this.Controls.Add(this.btn_showcolor);
            this.Controls.Add(this.btn_changecolor);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "form_M13_paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_penwidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_changecolor;
        private System.Windows.Forms.Button btn_showcolor;
        private System.Windows.Forms.TrackBar trackBar_penwidth;
        private System.Windows.Forms.Label label_trackbarvalue;
    }
}