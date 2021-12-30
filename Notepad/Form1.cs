using Notepad.Memento;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        private string _input;
        private string find;
        CommandBase disableCopy, enableCopy, disableUndo, enableUndo, disableFind, enableFind, disableGoto, enableGoto, disableReplace, disableSave, enableSave;

        Stack<string> undoList = new Stack<string>();

        //Memento for Undo,Redo
        Caretaker caretaker = new Caretaker();
        Originator originator = new Originator();
        int savedFile, currentArticle;
        //

        public Form1()
        {
            InitializeComponent();
            disableCopy = new DisableCommand(colorToolStripMenuItem, copyToolStripButton, copyToolStripMenuItem, cutToolStripButton, cutToolStripMenuItem, deleteToolStripMenuItem, toolStripButton1);
            enableCopy = new EnanbleCommand(colorToolStripMenuItem, copyToolStripButton, copyToolStripMenuItem, cutToolStripButton, cutToolStripMenuItem, deleteToolStripMenuItem, toolStripButton1);

            disableReplace = new DisableCommand(replaceToolStripMenuItem);

            disableUndo = new DisableCommand(undoToolStripMenuItem);
            enableUndo = new EnanbleCommand(undoToolStripMenuItem);

            disableFind = new DisableCommand(findToolStripMenuItem);
            enableFind = new EnanbleCommand(findToolStripMenuItem);

            disableGoto = new DisableCommand(gotoToolStripMenuItem);
            enableGoto = new EnanbleCommand(gotoToolStripMenuItem);

            disableSave = new DisableCommand(saveAsToolStripMenuItem, saveToolStripMenuItem, saveToolStripButton);
            enableSave = new EnanbleCommand(saveAsToolStripMenuItem, saveToolStripMenuItem, saveToolStripButton);


            disableCopy.excute();
            disableSave.excute();
            disableReplace.excute();
            disableGoto.excute();
            disableUndo.excute();
            disableFind.excute();

            //Memento
            savedFile = 0;
            currentArticle = 0;
            //
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            originator.Set(richTextBox1.Text);
            caretaker.AddMemento(originator.StoreInMemento());
            savedFile += 1;
            currentArticle = savedFile;
            //
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            enableSave.excute();
            undoList.Push(richTextBox1.Text);
            enableFind.excute();
            enableUndo.excute();

            if (richTextBox1.Lines.Length > 1)
            {
                enableGoto.excute();
            }
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.SelectedText))
            {
                disableCopy.excute();
            }
            else
            {
                enableCopy.excute();
            }

            UpdateStatus();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            disableSave.excute();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            disableSave.excute();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            disableSave.excute();

        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            PrintDialog pDlg = new PrintDialog();
            PrintDocument pDoc = new PrintDocument();
            pDoc.DocumentName = "Print Document";
            pDlg.Document = pDoc;
            pDlg.AllowSelection = true;
            pDlg.AllowSomePages = true;
            if (pDlg.ShowDialog() == DialogResult.OK)
            {
                pDoc.Print();
            }
            else
            {
                MessageBox.Show("Đã hủy in");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoList.Count > 1)
            {
                undoList.Pop();
                richTextBox1.Text = undoList.Peek();
            }
            else
            {
                richTextBox1.Text = "";
            }

            richTextBox1.TextChanged -= new EventHandler(richTextBox1_TextChanged);
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog1.Color;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wordRemove = richTextBox1.SelectedText;
            RemoveWordFromRichTextBox(richTextBox1, wordRemove);
        }

        private void RemoveWordFromRichTextBox(RichTextBox richTextBox, string word)
        {
            int index;
            do
            {
                index = richTextBox.Find(word);
                if (index >= 0)
                {
                    richTextBox.Select(index, word.Length);
                    richTextBox.SelectedText = String.Empty;
                }
            }
            while (index >= 0);
        }

        //undo
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (currentArticle >= 1)
            {
                currentArticle -= 1;
                Memento.Memento prev = caretaker.GetMemento(currentArticle);
                string prevArticle = originator.RestoreFromMemento(prev);
                richTextBox1.Text = prevArticle;
                toolStripButton4.Enabled = true;
            }
            else
            {
                toolStripButton3.Enabled = false;
            }
        }

        //redo
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (currentArticle < savedFile - 1)
            {
                currentArticle += 1;
                Memento.Memento next = caretaker.GetMemento(currentArticle);
                string nextArticle = originator.RestoreFromMemento(next);
                richTextBox1.Text = nextArticle;
                toolStripButton3.Enabled = true;
            }
            else
            {
                toolStripButton4.Enabled = false;
            }
        }

        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 32)
            {
                //Memento Save
                originator.Set(richTextBox1.Text);
                caretaker.AddMemento(originator.StoreInMemento());
                savedFile = caretaker.GetCountOfSavedArticles();
                currentArticle = savedFile;
                //
                if (currentArticle > 0)
                {
                    toolStripButton3.Enabled = true;
                }
            }
        }

        private void gotoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (GotoForm form = new GotoForm())
            {
                form.ShowDialog();
                _input = form.Message;
            }
            int line = Convert.ToInt32(_input);
            if (line > richTextBox1.Lines.Length)
            {
                MessageBox.Show("Số dòng muốn tìm lớn hơn số dòng hiện có");
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Find(richTextBox1.Lines[line - 1]);
                richTextBox1.ScrollToCaret();
            }

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FindForm form = new FindForm())
            {
                form.ShowDialog();
                find = form.Findtext;
            }
            findString(find);
        }
        private void findString(string fint)
        {
            int index = 0;
            var temp = richTextBox1.Text;
            richTextBox1.Text = "";
            richTextBox1.Text = temp;

            while (index < richTextBox1.Text.LastIndexOf(find))
            {
                richTextBox1.Find(find, index, richTextBox1.TextLength, RichTextBoxFinds.None);
                richTextBox1.SelectionBackColor = Color.Yellow;

                index = richTextBox1.Text.IndexOf(find, index) + 1;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            richTextBox1.AppendText(" " + time);
        }

        private void wordWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = wordWToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip2.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void UpdateStatus()
        {
            int pos = richTextBox1.SelectionStart;
            int line = richTextBox1.GetLineFromCharIndex(pos) + 1;
            int col = pos - richTextBox1.GetFirstCharIndexOfCurrentLine() + 1;

            status.Text = "Ln" + line + ", Col" + col;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (About frm = new About())
            {
                frm.ShowDialog();
            }
        }
    }
}
