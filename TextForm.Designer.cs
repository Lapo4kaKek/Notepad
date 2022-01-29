
namespace Notepad
{
    partial class TextForm
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
            this.text = new System.Windows.Forms.RichTextBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuFontDialog = new System.Windows.Forms.FontDialog();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AcceptsTab = true;
            this.text.BackColor = System.Drawing.SystemColors.Window;
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Name = "text";
            this.text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.text.Size = new System.Drawing.Size(581, 450);
            this.text.TabIndex = 0;
            this.text.Text = "";
            this.text.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.changeFontToolStripMenuItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(240, 164);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.selectAllToolStripMenuItem.Text = "Выбрать весь текст";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.cutToolStripMenuItem.Text = "Вырезать";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.copyToolStripMenuItem.Text = "Копировать";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.pasteToolStripMenuItem.Text = "Вставить";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.changeFontToolStripMenuItem.Text = "Задать формат";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // contextMenuFontDialog
            // 
            this.contextMenuFontDialog.ShowColor = true;
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.text);
            this.Name = "TextForm";
            this.Text = "Form2";
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog contextMenuFontDialog;
    }
}