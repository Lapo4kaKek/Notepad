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

namespace Notepad
{
    public partial class TextForm : Form
    {
        public string fileName { get; private set; }
        public bool IsChanged { get; private set; }
        public TextForm(string name)
        {
            fileName = name;
            InitializeComponent();
            this.Text = Path.GetFileName(fileName);
            text.ContextMenuStrip = contextMenu;
            ReadFile();
        }
        private void ReadFile()
        {
            try
            {
                if (Path.GetExtension(fileName) == ".rtf")
                    text.LoadFile(fileName, RichTextBoxStreamType.RichText);
                else
                    text.LoadFile(fileName, RichTextBoxStreamType.PlainText);
                IsChanged = false;
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show($"Ошибка при чтении файла {fileName}!", "Ошибка",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Retry)
                    this.ReadFile();
                else
                    this.Close();
            }
        }
        public void SaveFile(bool asRtf)
        {
            try
            {
                if (asRtf)
                {
                    if (Path.GetExtension(fileName) != ".rtf")
                    {
                        File.Delete(fileName);
                        fileName += ".rtf";
                    }
                    text.SaveFile(fileName, RichTextBoxStreamType.RichText);
                }
                else
                    text.SaveFile(fileName, RichTextBoxStreamType.PlainText);
                IsChanged = false;
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show($"Ошибка при сохранении файла {fileName}!", "Ошибка",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Retry)
                    this.SaveFile(asRtf);
                else
                    return;
            }
        }
        public void SaveFileHow(string newFileName)
        {
            try
            {
                if (Path.GetExtension(newFileName) == ".rtf")
                    text.SaveFile(newFileName, RichTextBoxStreamType.RichText);
                else
                    text.SaveFile(newFileName, RichTextBoxStreamType.PlainText);
            }
            catch (Exception)
            {
                DialogResult result = MessageBox.Show($"Ошибка при сохранении файла {newFileName}!", "Ошибка",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Retry)
                    this.SaveFileHow(newFileName);
                else
                    return;
            }
        }
        public void MakeItalics()
        {
            if (text.SelectionFont != null)
            {
                if (!text.SelectionFont.Italic)
                    text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style | FontStyle.Italic);
                else
                    text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style & ~FontStyle.Italic);
            }
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }
        public void MakeBold()
        {
            if (text.SelectionFont != null)
            {
                if (!text.SelectionFont.Bold)
                    text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style | FontStyle.Bold);
                else
                    text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style & ~FontStyle.Bold);
            }
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }
        public void MakeStrikeout()
        {
            if (text.SelectionFont != null)
            {
                if (!text.SelectionFont.Strikeout)
                text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style | FontStyle.Strikeout);
            else
                text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style & ~FontStyle.Strikeout);
            }
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }

        public void MakeUnderline()
        {
            if (text.SelectionFont != null)
            {
                if (!text.SelectionFont.Underline)
                text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style | FontStyle.Underline);
            else
                text.SelectionFont = new Font(text.SelectionFont, text.SelectionFont.Style & ~FontStyle.Underline);
            }
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }
        public void ChangeRegister()
        {
            if (text.SelectedText.Length >= 1)
            {
                if (Char.IsUpper(text.SelectedText, 0))
                    text.SelectedText = text.SelectedText.ToLower();
                else
                    text.SelectedText = text.SelectedText.ToUpper();
            }
        }
        public void ChangeSelectedFont(string fontName)
        {
            if(text.SelectionFont != null)
                text.SelectionFont = new Font(fontName, text.SelectionFont.Size, text.SelectionFont.Style);
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }
        public void ChangeSelectionColor(Color newColor)
        {
            text.SelectionColor = newColor;
        }
        public void ChangeSize(int newSize)
        {
            if(text.SelectionFont!=null)
                text.SelectionFont = new Font(text.SelectionFont.FontFamily, newSize, text.SelectionFont.Style);
            else
                MessageBox.Show("Невозможно одновременно изменить текст разных шрифтов, выделите их по отдельности", "Ошибка");
        }
        public void ChangeFont(Font newFont, Color newColor)
        {
            text.Font = newFont;
            text.ForeColor = newColor;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            IsChanged = true;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Paste();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.Cut();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            text.SelectAll();
        }
        public void Undo() => text.Undo();
        public void Redo() => text.Redo();
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (contextMenuFontDialog.ShowDialog() == DialogResult.Cancel)
                return;
            text.SelectionFont = contextMenuFontDialog.Font;
            text.SelectionColor = contextMenuFontDialog.Color;
        }
    }
}
