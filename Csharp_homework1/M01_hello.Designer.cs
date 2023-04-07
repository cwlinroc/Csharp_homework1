namespace Csharp_homework1
{
    partial class form_M01_hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_M01_hello));
            this.label_name = new System.Windows.Forms.Label();
            this.label_english_name = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_constellation = new System.Windows.Forms.Label();
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.textbox_english_name = new System.Windows.Forms.TextBox();
            this.textbox_gender = new System.Windows.Forms.TextBox();
            this.textbox_constellation = new System.Windows.Forms.TextBox();
            this.btn_say_hi = new System.Windows.Forms.Button();
            this.btn_say_hello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_name.Location = new System.Drawing.Point(191, 82);
            this.label_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(69, 34);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "姓名";
            // 
            // label_english_name
            // 
            this.label_english_name.AutoSize = true;
            this.label_english_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_english_name.Location = new System.Drawing.Point(191, 168);
            this.label_english_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_english_name.Name = "label_english_name";
            this.label_english_name.Size = new System.Drawing.Size(123, 34);
            this.label_english_name.TabIndex = 1;
            this.label_english_name.Text = "英文名字";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_gender.Location = new System.Drawing.Point(191, 255);
            this.label_gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(69, 34);
            this.label_gender.TabIndex = 2;
            this.label_gender.Text = "性別";
            // 
            // label_constellation
            // 
            this.label_constellation.AutoSize = true;
            this.label_constellation.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_constellation.Location = new System.Drawing.Point(191, 344);
            this.label_constellation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_constellation.Name = "label_constellation";
            this.label_constellation.Size = new System.Drawing.Size(69, 34);
            this.label_constellation.TabIndex = 3;
            this.label_constellation.Text = "星座";
            // 
            // textbox_name
            // 
            this.textbox_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_name.Location = new System.Drawing.Point(595, 79);
            this.textbox_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(132, 42);
            this.textbox_name.TabIndex = 4;
            // 
            // textbox_english_name
            // 
            this.textbox_english_name.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_english_name.Location = new System.Drawing.Point(595, 158);
            this.textbox_english_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_english_name.Name = "textbox_english_name";
            this.textbox_english_name.Size = new System.Drawing.Size(132, 42);
            this.textbox_english_name.TabIndex = 5;
            // 
            // textbox_gender
            // 
            this.textbox_gender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_gender.Location = new System.Drawing.Point(595, 245);
            this.textbox_gender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_gender.Name = "textbox_gender";
            this.textbox_gender.Size = new System.Drawing.Size(132, 42);
            this.textbox_gender.TabIndex = 6;
            // 
            // textbox_constellation
            // 
            this.textbox_constellation.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_constellation.Location = new System.Drawing.Point(595, 334);
            this.textbox_constellation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textbox_constellation.Name = "textbox_constellation";
            this.textbox_constellation.Size = new System.Drawing.Size(132, 42);
            this.textbox_constellation.TabIndex = 7;
            // 
            // btn_say_hi
            // 
            this.btn_say_hi.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_say_hi.Location = new System.Drawing.Point(197, 446);
            this.btn_say_hi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_say_hi.Name = "btn_say_hi";
            this.btn_say_hi.Size = new System.Drawing.Size(200, 52);
            this.btn_say_hi.TabIndex = 8;
            this.btn_say_hi.Text = "說 Hi";
            this.btn_say_hi.UseVisualStyleBackColor = true;
            this.btn_say_hi.Click += new System.EventHandler(this.btn_say_hi_Click);
            // 
            // btn_say_hello
            // 
            this.btn_say_hello.Font = new System.Drawing.Font("新細明體-ExtB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_say_hello.Location = new System.Drawing.Point(595, 446);
            this.btn_say_hello.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_say_hello.Name = "btn_say_hello";
            this.btn_say_hello.Size = new System.Drawing.Size(200, 52);
            this.btn_say_hello.TabIndex = 9;
            this.btn_say_hello.Text = "Say Hello";
            this.btn_say_hello.UseVisualStyleBackColor = true;
            this.btn_say_hello.Click += new System.EventHandler(this.btn_say_hello_Click);
            // 
            // form_M01_hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1003, 530);
            this.Controls.Add(this.btn_say_hello);
            this.Controls.Add(this.btn_say_hi);
            this.Controls.Add(this.textbox_constellation);
            this.Controls.Add(this.textbox_gender);
            this.Controls.Add(this.textbox_english_name);
            this.Controls.Add(this.textbox_name);
            this.Controls.Add(this.label_constellation);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_english_name);
            this.Controls.Add(this.label_name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "form_M01_hello";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_english_name;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_constellation;
        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.TextBox textbox_english_name;
        private System.Windows.Forms.TextBox textbox_gender;
        private System.Windows.Forms.TextBox textbox_constellation;
        private System.Windows.Forms.Button btn_say_hi;
        private System.Windows.Forms.Button btn_say_hello;
    }
}

