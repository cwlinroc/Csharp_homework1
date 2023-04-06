using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Csharp_homework1
{
    public partial class M03_barapp : Form
    {

        
        public M03_barapp()
        {
            InitializeComponent();
            shoplist = new ShoppingList();
        }

        private void btn_menu_beer_Click(object sender, EventArgs e)
        {
            shoplist.Add("Beer");
            textbox_shoppinglist.Text = shoplist.GetNewText();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            
        }

        private void btn_menu_tequila_Click(object sender, EventArgs e)
        {
            shoplist.Add("Tequila");
            textbox_shoppinglist.Text = shoplist.GetNewText();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            
        }

        private void btn_menu_whisky_Click(object sender, EventArgs e)
        {
            shoplist.Add("Whisky");
            textbox_shoppinglist.Text = shoplist.GetNewText();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            
        }

        private void btn_menu_wine_Click(object sender, EventArgs e)
        {
            shoplist.Add("Wine");
            textbox_shoppinglist.Text = shoplist.GetNewText();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            
        }

        private void btn_shoppinglist_clear_Click(object sender, EventArgs e)
        {
            shoplist.Clear();
            textbox_shoppinglist.Text = "尚未點單";
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
            textbox_total_price.Text = shoplist.PrintTotalPrice();
        }


        private void btn_payment_cash_Click(object sender, EventArgs e)
        {
            string text="總金額： $" + shoplist.totalprice ;
            string caption="確認付款";

            MessageBox.Show(text, caption, MessageBoxButtons.OKCancel);
        }

        private void btn_payment_creddit_Click(object sender, EventArgs e)
        {
            string text = "總金額： $" + shoplist.totalprice + "\n折扣後金額： $" 
                + (int)( shoplist.totalprice * 0.87) ;
            string caption = "確認付款";

            MessageBox.Show(text, caption, MessageBoxButtons.OKCancel);
        }

        private ShoppingList shoplist;
        private class ShoppingList
        {
            private Alcohol[] listboard ;
            public int totalprice = 0;


            public ShoppingList()
            {
                listboard = new Alcohol[4];

                listboard[0].Name = "啤酒Beer";
                listboard[0].Price = 120;
                listboard[0].Numbers = 0;

                listboard[1].Name = "龍舌蘭Tequila";
                listboard[1].Price = 180;
                listboard[1].Numbers = 0;

                listboard[2].Name = "威士忌Whisky";
                listboard[2].Price = 350;
                listboard[2].Numbers = 0;

                listboard[3].Name = "紅酒Wine";
                listboard[3].Price = 320;
                listboard[3].Numbers = 0;
            }

            public void Add (string alcohol)
            {
                switch(alcohol)
                {

                    case "Beer":
                        listboard[0].Numbers++;
                        totalprice += listboard[0].Price;
                        break;

                    case "Tequila":
                        listboard[1].Numbers++;
                        totalprice += listboard[1].Price;
                        break;

                    case "Whisky":
                        listboard[2].Numbers++;
                        totalprice += listboard[2].Price;
                        break;

                    case "Wine":
                        listboard[3].Numbers++;
                        totalprice += listboard[3].Price;
                        break;

                }
            }

            public void Clear ()
            {
                for(int i = 0; i < listboard.Length; i++) 
                {
                    listboard[i].Numbers = 0;
                }

                totalprice = 0;

            }

            public string GetNewText() 
            {
                string message="";

                for (int i = 0; i < listboard.Length; i++)
                {
                    if(listboard[i].Numbers != 0)
                    {
                        message = message +listboard[i].Name + "x" + listboard[i].Numbers 
                            + ", 共 NT"+listboard[i].Price*listboard[i].Numbers + "元\r\n";
                    }
                }

                return message;
            }

            public string PrintTotalPrice()
            {               
                return totalprice.ToString()+"元";
            }


            
        }

        private struct Alcohol
        {
            public string Name;
            public int Price;            
            public int Numbers;
        }

        
    }
}
