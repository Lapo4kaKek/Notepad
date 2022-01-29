
namespace Notepad
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.IntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.changeSettingsButton = new System.Windows.Forms.Button();
            this.formatGroupBox = new System.Windows.Forms.GroupBox();
            this.withoutSavingButton = new System.Windows.Forms.RadioButton();
            this.withSavingButton = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.changeSettingsButton2 = new System.Windows.Forms.Button();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.DarkRadioButton = new System.Windows.Forms.RadioButton();
            this.LightRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.formatGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IntervalNumericUpDown
            // 
            this.IntervalNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IntervalNumericUpDown.Location = new System.Drawing.Point(311, 15);
            this.IntervalNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalNumericUpDown.Name = "IntervalNumericUpDown";
            this.IntervalNumericUpDown.Size = new System.Drawing.Size(81, 37);
            this.IntervalNumericUpDown.TabIndex = 1;
            this.IntervalNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(8, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(284, 30);
            this.label.TabIndex = 2;
            this.label.Text = "Частота сохранений (мин):";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(495, 377);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.changeSettingsButton);
            this.tabPage1.Controls.Add(this.formatGroupBox);
            this.tabPage1.Controls.Add(this.label);
            this.tabPage1.Controls.Add(this.IntervalNumericUpDown);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(487, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авто-сохранения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // changeSettingsButton
            // 
            this.changeSettingsButton.Location = new System.Drawing.Point(358, 288);
            this.changeSettingsButton.Name = "changeSettingsButton";
            this.changeSettingsButton.Size = new System.Drawing.Size(112, 34);
            this.changeSettingsButton.TabIndex = 6;
            this.changeSettingsButton.Text = "OK";
            this.changeSettingsButton.UseVisualStyleBackColor = true;
            this.changeSettingsButton.Click += new System.EventHandler(this.changeSettingsButton_Click);
            // 
            // formatGroupBox
            // 
            this.formatGroupBox.Controls.Add(this.withoutSavingButton);
            this.formatGroupBox.Controls.Add(this.withSavingButton);
            this.formatGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formatGroupBox.Location = new System.Drawing.Point(8, 81);
            this.formatGroupBox.Name = "formatGroupBox";
            this.formatGroupBox.Size = new System.Drawing.Size(300, 150);
            this.formatGroupBox.TabIndex = 5;
            this.formatGroupBox.TabStop = false;
            this.formatGroupBox.Text = "Форматирование";
            // 
            // withoutSavingButton
            // 
            this.withoutSavingButton.AutoSize = true;
            this.withoutSavingButton.Location = new System.Drawing.Point(33, 77);
            this.withoutSavingButton.Name = "withoutSavingButton";
            this.withoutSavingButton.Size = new System.Drawing.Size(198, 34);
            this.withoutSavingButton.TabIndex = 1;
            this.withoutSavingButton.Text = "без сохранения";
            this.withoutSavingButton.UseVisualStyleBackColor = true;
            // 
            // withSavingButton
            // 
            this.withSavingButton.AutoSize = true;
            this.withSavingButton.Checked = true;
            this.withSavingButton.Location = new System.Drawing.Point(33, 36);
            this.withSavingButton.Name = "withSavingButton";
            this.withSavingButton.Size = new System.Drawing.Size(189, 34);
            this.withSavingButton.TabIndex = 0;
            this.withSavingButton.TabStop = true;
            this.withSavingButton.Text = "с сохранением";
            this.withSavingButton.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.changeSettingsButton2);
            this.tabPage2.Controls.Add(this.colorGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(487, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Цветовая схема";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // changeSettingsButton2
            // 
            this.changeSettingsButton2.Location = new System.Drawing.Point(355, 286);
            this.changeSettingsButton2.Name = "changeSettingsButton2";
            this.changeSettingsButton2.Size = new System.Drawing.Size(112, 34);
            this.changeSettingsButton2.TabIndex = 7;
            this.changeSettingsButton2.Text = "OK";
            this.changeSettingsButton2.UseVisualStyleBackColor = true;
            this.changeSettingsButton2.Click += new System.EventHandler(this.changeSettingsButton_Click);
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.DarkRadioButton);
            this.colorGroupBox.Controls.Add(this.LightRadioButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorGroupBox.Location = new System.Drawing.Point(23, 20);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(366, 213);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Цветовая схема";
            // 
            // DarkRadioButton
            // 
            this.DarkRadioButton.AutoSize = true;
            this.DarkRadioButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DarkRadioButton.Location = new System.Drawing.Point(26, 113);
            this.DarkRadioButton.Name = "DarkRadioButton";
            this.DarkRadioButton.Size = new System.Drawing.Size(136, 42);
            this.DarkRadioButton.TabIndex = 1;
            this.DarkRadioButton.TabStop = true;
            this.DarkRadioButton.Text = "Темная";
            this.DarkRadioButton.UseVisualStyleBackColor = true;
            // 
            // LightRadioButton
            // 
            this.LightRadioButton.AutoSize = true;
            this.LightRadioButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LightRadioButton.Location = new System.Drawing.Point(26, 55);
            this.LightRadioButton.Name = "LightRadioButton";
            this.LightRadioButton.Size = new System.Drawing.Size(143, 42);
            this.LightRadioButton.TabIndex = 0;
            this.LightRadioButton.TabStop = true;
            this.LightRadioButton.Text = "Светлая";
            this.LightRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 377);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            ((System.ComponentModel.ISupportInitialize)(this.IntervalNumericUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.formatGroupBox.ResumeLayout(false);
            this.formatGroupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown IntervalNumericUpDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox formatGroupBox;
        private System.Windows.Forms.RadioButton withoutSavingButton;
        private System.Windows.Forms.RadioButton withSavingButton;
        private System.Windows.Forms.Button changeSettingsButton;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton DarkRadioButton;
        private System.Windows.Forms.Button changeSettingsButton2;
        private System.Windows.Forms.RadioButton LightRadioButton;
    }
}