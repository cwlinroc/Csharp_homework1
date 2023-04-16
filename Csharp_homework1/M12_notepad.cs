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
using System.Drawing.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Csharp_homework1
{
    public partial class form_M12_notepad : Form
    {
        public form_M12_notepad()
        {
            InitializeComponent();
            RefreshClock();
        }

        #region -- menu_strip bottons --

        //復原, 取消復原在undo redo
        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_main.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            RefreshUndoRedo();
        }
        private void 另存新檔AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textbox_main.Text, Encoding.Default);
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }
        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
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
            RefreshUndoRedo();
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

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textbox_main.ForeColor = colorDialog.Color;
            }
        }

        private void 字形VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog(this) == DialogResult.OK)
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
            form_M12a_notepad_about m12a = new form_M12a_notepad_about();

            m12a.ShowDialog();
            
        }



        #endregion


        #region -- tool_strip buttons --
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
            關於AToolStripMenuItem.PerformClick();
        }

        #endregion

        #region -- clock --

        private void timer_clock_Tick(object sender, EventArgs e)
        {
            RefreshClock();
        }

        private void RefreshClock()
        {
            string message;

            if (DateTime.Now.Hour < 12)
            {
                message = $"上午  {DateTime.Now.Hour.ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }
            else if (DateTime.Now.Hour == 12)
            {
                message = $"下午  {DateTime.Now.Hour.ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }
            else
            {
                message = $"下午  {(DateTime.Now.Hour - 12).ToString("D2")}" +
                    $":{DateTime.Now.Minute.ToString("D2")}:{DateTime.Now.Second.ToString("D2")}";
            }

            toolstriplabel_clock.Text = message;
        }

        #endregion

        /****Undo Redo****/

        #region -- undo redo --


        // copy all solution(waste of memory)
        /**
        private Stack<string> edit_history = new Stack<string>();
        private Stack<string> undo_history = new Stack<string>();


        private bool canUndo = false;
        private bool canRedo = false;

        private void textbox_main_TextChanged(object sender, EventArgs e)
        {
            if (textbox_main.Modified)
            {
                RecordEdit();
            }
        }
        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(canUndo)
            {
                ImplementUndo();
            }
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(canRedo)
            {
                ImplementRedo();
            }
        }


        private void RecordEdit()
        {
            edit_history.Push(textbox_main.Text);
            canUndo = true;
            undo_history.Clear();
            canRedo = false;
        }

        private void ImplementUndo()
        {
            undo_history.Push(edit_history.Pop());
            canRedo = true;
            textbox_main.Text = edit_history.Peek();
            canUndo = edit_history.Count > 1;
        }


        private void ImplementRedo()
        {
            edit_history.Push(undo_history.Pop());
            canRedo = undo_history.Count > 0;
            textbox_main.Text = edit_history.Peek();
            canUndo = true ;
        }
        **/

        private string lastContent = "";

        private Stack<EditRecord> edit_history = new Stack<EditRecord>();
        private Stack<EditRecord> undo_history = new Stack<EditRecord>();

        private bool canUndo = false;
        private bool canRedo = false;


        private struct EditRecord
        {
            public bool isInsertion;
            public int editLength;
            public string editString;
            public int selecstart;
        }


        private void textbox_main_TextChanged(object sender, EventArgs e)
        {
            if (textbox_main.Modified)
            {
                RecordEdit();
            }
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canUndo)
            {
                ImplementUndo();
            }
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (canRedo)
            {
                ImplementRedo();
            }
        }

        private void RecordEdit()
        {
            EditRecord newedit = new EditRecord();

            newedit.isInsertion = IsInsertion(textbox_main, lastContent);

            newedit.editLength = GetEditLength(textbox_main, lastContent);

            newedit.selecstart = textbox_main.SelectionStart;

            newedit.editString = GetEditString(textbox_main.Text, lastContent, newedit.isInsertion, newedit.selecstart, newedit.editLength);


            edit_history.Push(newedit);
            undo_history.Clear();

            canUndo = true;
            canRedo = false;

            復原UToolStripMenuItem.Enabled = canUndo;
            取消復原RToolStripMenuItem.Enabled = canRedo;

            lastContent = textbox_main.Text;

        }

        private void ImplementUndo()
        {
            undo_history.Push(edit_history.Pop());

            EditRecord record = undo_history.Peek();

            if (record.isInsertion)
            {
                textbox_main.Text = textbox_main.Text.Remove(record.selecstart - record.editLength, record.editLength);
            }
            else
            {
                textbox_main.Text = textbox_main.Text.Insert(record.selecstart, record.editString);
            }

            canRedo = true;
            canUndo = edit_history.Count > 1;

            復原UToolStripMenuItem.Enabled = canUndo;
            取消復原RToolStripMenuItem.Enabled = canRedo;

        }


        private void ImplementRedo()
        {

            edit_history.Push(undo_history.Pop());

            EditRecord record = edit_history.Peek();

            if (record.isInsertion)
            {
                textbox_main.Text = textbox_main.Text.Insert(record.selecstart - record.editLength, record.editString);
            }
            else
            {
                textbox_main.Text = textbox_main.Text.Remove(record.selecstart, record.editLength);
            }

            canRedo = undo_history.Count > 0;
            canUndo = true;

            復原UToolStripMenuItem.Enabled = canUndo;
            取消復原RToolStripMenuItem.Enabled = canRedo;
        }



        private bool IsInsertion(TextBox editor, string last_content)
        {
            return editor.TextLength > last_content.Length;
        }

        private int GetEditLength(TextBox editor, string last_content)
        {
            return Math.Abs(editor.TextLength - last_content.Length);
        }

        private string GetEditString(string content, string last_content, bool isInsertion, int selecstart, int len)
        {
            if (isInsertion)
            {
                return content.Substring(selecstart - len, len);
            }
            else
            {
                return last_content.Substring(selecstart, len);
            }
        }


        private void RefreshUndoRedo()
        {
            lastContent = textbox_main.Text;

            edit_history.Clear();
            undo_history.Clear();

            復原UToolStripMenuItem.Enabled = false;
            取消復原RToolStripMenuItem.Enabled = false;

            canUndo = false;
            canRedo = false;
        }

        #endregion

    }
}
