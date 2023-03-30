namespace Csharp_homework1
{
    partial class M04_barapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M04_barapp));
            this.textbox_shoppinglist = new System.Windows.Forms.TextBox();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label_menu = new System.Windows.Forms.Label();
            this.btn_menu_wine = new System.Windows.Forms.Button();
            this.btn_menu_whisky = new System.Windows.Forms.Button();
            this.btn_menu_tequila = new System.Windows.Forms.Button();
            this.btn_menu_beer = new System.Windows.Forms.Button();
            this.panel_total_price = new System.Windows.Forms.Panel();
            this.label_total_price = new System.Windows.Forms.Label();
            this.textbox_total_price = new System.Windows.Forms.TextBox();
            this.panel_payment = new System.Windows.Forms.Panel();
            this.label_payment = new System.Windows.Forms.Label();
            this.btn_payment_creddit = new System.Windows.Forms.Button();
            this.btn_payment_cash = new System.Windows.Forms.Button();
            this.panel_shoppinglist = new System.Windows.Forms.Panel();
            this.label_shoppinglist = new System.Windows.Forms.Label();
            this.btn_shoppinglist_clear = new System.Windows.Forms.Button();
            this.label_discount = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            this.panel_total_price.SuspendLayout();
            this.panel_payment.SuspendLayout();
            this.panel_shoppinglist.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_shoppinglist
            // 
            this.textbox_shoppinglist.AcceptsTab = true;
            this.textbox_shoppinglist.BackColor = System.Drawing.Color.White;
            this.textbox_shoppinglist.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_shoppinglist.Location = new System.Drawing.Point(8, 39);
            this.textbox_shoppinglist.Multiline = true;
            this.textbox_shoppinglist.Name = "textbox_shoppinglist";
            this.textbox_shoppinglist.ReadOnly = true;
            this.textbox_shoppinglist.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textbox_shoppinglist.Size = new System.Drawing.Size(262, 215);
            this.textbox_shoppinglist.TabIndex = 0;
            this.textbox_shoppinglist.Text = "尚未點單";
            this.textbox_shoppinglist.WordWrap = false;
            // 
            // panel_menu
            // 
            this.panel_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_menu.Controls.Add(this.label_menu);
            this.panel_menu.Controls.Add(this.btn_menu_wine);
            this.panel_menu.Controls.Add(this.btn_menu_whisky);
            this.panel_menu.Controls.Add(this.btn_menu_tequila);
            this.panel_menu.Controls.Add(this.btn_menu_beer);
            this.panel_menu.Location = new System.Drawing.Point(24, 46);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(258, 264);
            this.panel_menu.TabIndex = 1;
            // 
            // label_menu
            // 
            this.label_menu.AutoSize = true;
            this.label_menu.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_menu.Location = new System.Drawing.Point(11, 8);
            this.label_menu.Name = "label_menu";
            this.label_menu.Size = new System.Drawing.Size(111, 27);
            this.label_menu.TabIndex = 4;
            this.label_menu.Text = "菜單menu";
            // 
            // btn_menu_wine
            // 
            this.btn_menu_wine.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu_wine.ForeColor = System.Drawing.Color.Navy;
            this.btn_menu_wine.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_wine.Image")));
            this.btn_menu_wine.Location = new System.Drawing.Point(132, 152);
            this.btn_menu_wine.Name = "btn_menu_wine";
            this.btn_menu_wine.Size = new System.Drawing.Size(100, 100);
            this.btn_menu_wine.TabIndex = 3;
            this.btn_menu_wine.Text = "紅酒\r\nWine\r\nNT 320";
            this.btn_menu_wine.UseVisualStyleBackColor = true;
            this.btn_menu_wine.Click += new System.EventHandler(this.btn_menu_wine_Click);
            // 
            // btn_menu_whisky
            // 
            this.btn_menu_whisky.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu_whisky.ForeColor = System.Drawing.Color.Navy;
            this.btn_menu_whisky.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_whisky.Image")));
            this.btn_menu_whisky.Location = new System.Drawing.Point(23, 152);
            this.btn_menu_whisky.Name = "btn_menu_whisky";
            this.btn_menu_whisky.Size = new System.Drawing.Size(100, 100);
            this.btn_menu_whisky.TabIndex = 2;
            this.btn_menu_whisky.Text = "威士忌\r\nWhisky\r\nNT 350";
            this.btn_menu_whisky.UseVisualStyleBackColor = true;
            this.btn_menu_whisky.Click += new System.EventHandler(this.btn_menu_whisky_Click);
            // 
            // btn_menu_tequila
            // 
            this.btn_menu_tequila.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu_tequila.ForeColor = System.Drawing.Color.Navy;
            this.btn_menu_tequila.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu_tequila.Image")));
            this.btn_menu_tequila.Location = new System.Drawing.Point(132, 43);
            this.btn_menu_tequila.Name = "btn_menu_tequila";
            this.btn_menu_tequila.Size = new System.Drawing.Size(100, 100);
            this.btn_menu_tequila.TabIndex = 1;
            this.btn_menu_tequila.Text = "龍舌蘭\r\nTequila\r\nNT 180";
            this.btn_menu_tequila.UseVisualStyleBackColor = true;
            this.btn_menu_tequila.Click += new System.EventHandler(this.btn_menu_tequila_Click);
            // 
            // btn_menu_beer
            // 
            this.btn_menu_beer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_menu_beer.BackgroundImage")));
            this.btn_menu_beer.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_menu_beer.ForeColor = System.Drawing.Color.Navy;
            this.btn_menu_beer.Location = new System.Drawing.Point(23, 43);
            this.btn_menu_beer.Name = "btn_menu_beer";
            this.btn_menu_beer.Size = new System.Drawing.Size(100, 100);
            this.btn_menu_beer.TabIndex = 0;
            this.btn_menu_beer.Text = "啤酒\r\nBeer\r\nNT 120";
            this.btn_menu_beer.UseVisualStyleBackColor = true;
            this.btn_menu_beer.Click += new System.EventHandler(this.btn_menu_beer_Click);
            // 
            // panel_total_price
            // 
            this.panel_total_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_total_price.Controls.Add(this.label_total_price);
            this.panel_total_price.Controls.Add(this.textbox_total_price);
            this.panel_total_price.Location = new System.Drawing.Point(288, 47);
            this.panel_total_price.Name = "panel_total_price";
            this.panel_total_price.Size = new System.Drawing.Size(221, 89);
            this.panel_total_price.TabIndex = 2;
            // 
            // label_total_price
            // 
            this.label_total_price.AutoSize = true;
            this.label_total_price.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_total_price.Location = new System.Drawing.Point(12, 7);
            this.label_total_price.Name = "label_total_price";
            this.label_total_price.Size = new System.Drawing.Size(174, 27);
            this.label_total_price.TabIndex = 5;
            this.label_total_price.Text = "總金額total price";
            // 
            // textbox_total_price
            // 
            this.textbox_total_price.BackColor = System.Drawing.SystemColors.MenuText;
            this.textbox_total_price.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textbox_total_price.ForeColor = System.Drawing.SystemColors.Window;
            this.textbox_total_price.Location = new System.Drawing.Point(17, 42);
            this.textbox_total_price.Name = "textbox_total_price";
            this.textbox_total_price.ReadOnly = true;
            this.textbox_total_price.Size = new System.Drawing.Size(176, 27);
            this.textbox_total_price.TabIndex = 0;
            this.textbox_total_price.Text = "0元";
            // 
            // panel_payment
            // 
            this.panel_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_payment.Controls.Add(this.label_payment);
            this.panel_payment.Controls.Add(this.btn_payment_creddit);
            this.panel_payment.Controls.Add(this.btn_payment_cash);
            this.panel_payment.Location = new System.Drawing.Point(288, 158);
            this.panel_payment.Name = "panel_payment";
            this.panel_payment.Size = new System.Drawing.Size(221, 141);
            this.panel_payment.TabIndex = 3;
            // 
            // label_payment
            // 
            this.label_payment.AutoSize = true;
            this.label_payment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_payment.Location = new System.Drawing.Point(13, 9);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(96, 27);
            this.label_payment.TabIndex = 5;
            this.label_payment.Text = "付款方式";
            // 
            // btn_payment_creddit
            // 
            this.btn_payment_creddit.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_payment_creddit.Location = new System.Drawing.Point(121, 40);
            this.btn_payment_creddit.Name = "btn_payment_creddit";
            this.btn_payment_creddit.Size = new System.Drawing.Size(87, 50);
            this.btn_payment_creddit.TabIndex = 2;
            this.btn_payment_creddit.Text = "信用卡付款";
            this.btn_payment_creddit.UseVisualStyleBackColor = true;
            this.btn_payment_creddit.Click += new System.EventHandler(this.btn_payment_creddit_Click);
            // 
            // btn_payment_cash
            // 
            this.btn_payment_cash.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_payment_cash.Location = new System.Drawing.Point(18, 40);
            this.btn_payment_cash.Name = "btn_payment_cash";
            this.btn_payment_cash.Size = new System.Drawing.Size(87, 50);
            this.btn_payment_cash.TabIndex = 1;
            this.btn_payment_cash.Text = "現金付款";
            this.btn_payment_cash.UseVisualStyleBackColor = true;
            this.btn_payment_cash.Click += new System.EventHandler(this.btn_payment_cash_Click);
            // 
            // panel_shoppinglist
            // 
            this.panel_shoppinglist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_shoppinglist.Controls.Add(this.label_shoppinglist);
            this.panel_shoppinglist.Controls.Add(this.btn_shoppinglist_clear);
            this.panel_shoppinglist.Controls.Add(this.textbox_shoppinglist);
            this.panel_shoppinglist.Location = new System.Drawing.Point(527, 47);
            this.panel_shoppinglist.Name = "panel_shoppinglist";
            this.panel_shoppinglist.Size = new System.Drawing.Size(285, 329);
            this.panel_shoppinglist.TabIndex = 4;
            // 
            // label_shoppinglist
            // 
            this.label_shoppinglist.AutoSize = true;
            this.label_shoppinglist.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_shoppinglist.Location = new System.Drawing.Point(3, 5);
            this.label_shoppinglist.Name = "label_shoppinglist";
            this.label_shoppinglist.Size = new System.Drawing.Size(96, 27);
            this.label_shoppinglist.TabIndex = 5;
            this.label_shoppinglist.Text = "購物清單";
            // 
            // btn_shoppinglist_clear
            // 
            this.btn_shoppinglist_clear.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_shoppinglist_clear.Location = new System.Drawing.Point(183, 261);
            this.btn_shoppinglist_clear.Name = "btn_shoppinglist_clear";
            this.btn_shoppinglist_clear.Size = new System.Drawing.Size(87, 50);
            this.btn_shoppinglist_clear.TabIndex = 2;
            this.btn_shoppinglist_clear.Text = "清除清單";
            this.btn_shoppinglist_clear.UseVisualStyleBackColor = true;
            this.btn_shoppinglist_clear.Click += new System.EventHandler(this.btn_shoppinglist_clear_Click);
            // 
            // label_discount
            // 
            this.label_discount.AutoSize = true;
            this.label_discount.Font = new System.Drawing.Font("新細明體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_discount.Location = new System.Drawing.Point(390, 270);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(127, 16);
            this.label_discount.TabIndex = 5;
            this.label_discount.Text = "信用卡可打87折";
            // 
            // M04_barapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 409);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.panel_shoppinglist);
            this.Controls.Add(this.panel_total_price);
            this.Controls.Add(this.panel_payment);
            this.Controls.Add(this.panel_menu);
            this.Name = "M04_barapp";
            this.Text = "Bar App";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel_total_price.ResumeLayout(false);
            this.panel_total_price.PerformLayout();
            this.panel_payment.ResumeLayout(false);
            this.panel_payment.PerformLayout();
            this.panel_shoppinglist.ResumeLayout(false);
            this.panel_shoppinglist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_shoppinglist;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_total_price;
        private System.Windows.Forms.Panel panel_payment;
        private System.Windows.Forms.Button btn_menu_wine;
        private System.Windows.Forms.Button btn_menu_whisky;
        private System.Windows.Forms.Button btn_menu_tequila;
        private System.Windows.Forms.Button btn_menu_beer;
        private System.Windows.Forms.TextBox textbox_total_price;
        private System.Windows.Forms.Button btn_payment_creddit;
        private System.Windows.Forms.Button btn_payment_cash;
        private System.Windows.Forms.Panel panel_shoppinglist;
        private System.Windows.Forms.Button btn_shoppinglist_clear;
        private System.Windows.Forms.Label label_menu;
        private System.Windows.Forms.Label label_total_price;
        private System.Windows.Forms.Label label_payment;
        private System.Windows.Forms.Label label_shoppinglist;
        private System.Windows.Forms.Label label_discount;
    }
}