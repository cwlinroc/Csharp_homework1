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
    public partial class form_M15a_inputbox : Form
    {
        public form_M15a_inputbox()
        {
            InitializeComponent();
            this.ActiveControl = textbox_inputnumber;
        }

        internal delegate void PortDelegate (string port);
        internal event PortDelegate portevent;
        private void btn_enter_Click(object sender, EventArgs e)
        {
            portevent(textbox_inputnumber.Text);
            textbox_inputnumber.SelectAll();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void M15a_inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                btn_enter.PerformClick();
            }
        }
    }
}
