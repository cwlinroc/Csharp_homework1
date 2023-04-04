namespace Csharp_homework1
{
    partial class M16_alarmclock
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
            this.components = new System.ComponentModel.Container();
            this.datetimepicker_alarmtime = new System.Windows.Forms.DateTimePicker();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label_clock = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // datetimepicker_alarmtime
            // 
            this.datetimepicker_alarmtime.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.datetimepicker_alarmtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetimepicker_alarmtime.Location = new System.Drawing.Point(64, 71);
            this.datetimepicker_alarmtime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.datetimepicker_alarmtime.Name = "datetimepicker_alarmtime";
            this.datetimepicker_alarmtime.Size = new System.Drawing.Size(116, 31);
            this.datetimepicker_alarmtime.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(17, 154);
            this.btn_start.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(86, 40);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "開啟";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(136, 154);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(86, 40);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "關閉";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_clock.Location = new System.Drawing.Point(48, 21);
            this.label_clock.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(107, 35);
            this.label_clock.TabIndex = 3;
            this.label_clock.Text = "default";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_status.Location = new System.Drawing.Point(83, 108);
            this.label_status.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(82, 29);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "未啟動";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // M16_alarmclock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 217);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.datetimepicker_alarmtime);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "M16_alarmclock";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetimepicker_alarmtime;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Timer timer1;
    }
}