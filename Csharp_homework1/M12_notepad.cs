using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Csharp_homework1
{
    public partial class M12_notepad : Form
    {
        public M12_notepad()
        {
            InitializeComponent();
        }

        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_main.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName,textbox_main.Text,Encoding.Default);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog1.FileName, textbox_main.Text, Encoding.Default);
                    openFileDialog1.FileName = saveFileDialog1.FileName;
                }
            }
            else
            {
                File.WriteAllText(openFileDialog1.FileName, textbox_main.Text, Encoding.Default);
            }
        }

        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            textbox_main.Clear();
        }

        private void 結束XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.Paste();
        }

        private void 全選AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.SelectAll();
        }

        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            新增NToolStripMenuItem.PerformClick();
        }

        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            開啟OToolStripMenuItem.PerformClick();
        }

        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            儲存SToolStripMenuItem.PerformClick();
        }

        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            剪下TToolStripMenuItem.PerformClick();
        }

        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            複製CToolStripMenuItem.PerformClick();
        }

        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            貼上PToolStripMenuItem.PerformClick();
        }

        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                textbox_main.ForeColor = colorDialog.Color;
            }
        }

        private void 字形VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog(this)== DialogResult.OK)
            {
                textbox_main.Font = fontDialog.Font;
            }
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.WordWrap = !textbox_main.WordWrap;
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.Text = textbox_main.Text.ToUpper();
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.Text = textbox_main.Text.ToLower();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox_main.ForeColor = Color.Black;
        }

        private void 關於AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
