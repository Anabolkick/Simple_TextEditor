
namespace SR_TextEditor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиНовийФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберігтиФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберігтиФайлЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратиШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.збільшитиШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зменшитиШрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.FontSizeTool = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносРядківToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРозробникуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проРозробникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lable = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.text_groupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.text_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.шрифтToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.оРозробникуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиНовийФайлToolStripMenuItem,
            this.зберігтиФайлToolStripMenuItem,
            this.зберігтиФайлЯкToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // відкритиНовийФайлToolStripMenuItem
            // 
            this.відкритиНовийФайлToolStripMenuItem.Name = "відкритиНовийФайлToolStripMenuItem";
            this.відкритиНовийФайлToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.відкритиНовийФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.відкритиНовийФайлToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.відкритиНовийФайлToolStripMenuItem.Text = "Відкрити файл";
            this.відкритиНовийФайлToolStripMenuItem.Click += new System.EventHandler(this.відкритиНовийФайлToolStripMenuItem_Click);
            // 
            // зберігтиФайлToolStripMenuItem
            // 
            this.зберігтиФайлToolStripMenuItem.Name = "зберігтиФайлToolStripMenuItem";
            this.зберігтиФайлToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.зберігтиФайлToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.зберігтиФайлToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.зберігтиФайлToolStripMenuItem.Text = "Зберігти файл";
            this.зберігтиФайлToolStripMenuItem.Click += new System.EventHandler(this.зберігтиФайлToolStripMenuItem_Click);
            // 
            // зберігтиФайлЯкToolStripMenuItem
            // 
            this.зберігтиФайлЯкToolStripMenuItem.Name = "зберігтиФайлЯкToolStripMenuItem";
            this.зберігтиФайлЯкToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.зберігтиФайлЯкToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.зберігтиФайлЯкToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.зберігтиФайлЯкToolStripMenuItem.Text = "Зберігти як";
            this.зберігтиФайлЯкToolStripMenuItem.Click += new System.EventHandler(this.зберігтиФайлЯкToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обратиШрифтToolStripMenuItem,
            this.збільшитиШрифтToolStripMenuItem,
            this.зменшитиШрифтToolStripMenuItem,
            this.toolStripComboBox1});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.шрифтToolStripMenuItem.Text = "Шрифт";
            // 
            // обратиШрифтToolStripMenuItem
            // 
            this.обратиШрифтToolStripMenuItem.Name = "обратиШрифтToolStripMenuItem";
            this.обратиШрифтToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+F";
            this.обратиШрифтToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.обратиШрифтToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.обратиШрифтToolStripMenuItem.Text = "Обрати шрифт";
            this.обратиШрифтToolStripMenuItem.Click += new System.EventHandler(this.обратиШрифтToolStripMenuItem_Click);
            // 
            // збільшитиШрифтToolStripMenuItem
            // 
            this.збільшитиШрифтToolStripMenuItem.Name = "збільшитиШрифтToolStripMenuItem";
            this.збільшитиШрифтToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+";
            this.збільшитиШрифтToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Add)));
            this.збільшитиШрифтToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.збільшитиШрифтToolStripMenuItem.Text = "Збільшити розмір";
            this.збільшитиШрифтToolStripMenuItem.Click += new System.EventHandler(this.збільшитиШрифтToolStripMenuItem_Click);
            // 
            // зменшитиШрифтToolStripMenuItem
            // 
            this.зменшитиШрифтToolStripMenuItem.Name = "зменшитиШрифтToolStripMenuItem";
            this.зменшитиШрифтToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-";
            this.зменшитиШрифтToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Subtract)));
            this.зменшитиШрифтToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.зменшитиШрифтToolStripMenuItem.Text = "Зменшити розмір";
            this.зменшитиШрифтToolStripMenuItem.Click += new System.EventHandler(this.зменшитиШрифтToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontSizeTool,
            this.toolStripMenuItem2});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(220, 22);
            this.toolStripComboBox1.Text = "Обрати певний розмір";
            // 
            // FontSizeTool
            // 
            this.FontSizeTool.Name = "FontSizeTool";
            this.FontSizeTool.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "Зберігти";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносРядківToolStripMenuItem,
            this.пошукToolStripMenuItem});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // переносРядківToolStripMenuItem
            // 
            this.переносРядківToolStripMenuItem.Checked = true;
            this.переносРядківToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.переносРядківToolStripMenuItem.Name = "переносРядківToolStripMenuItem";
            this.переносРядківToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+W";
            this.переносРядківToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.переносРядківToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.переносРядківToolStripMenuItem.Text = "Перенесення рядків";
            this.переносРядківToolStripMenuItem.Click += new System.EventHandler(this.переносРядківToolStripMenuItem_Click);
            // 
            // пошукToolStripMenuItem
            // 
            this.пошукToolStripMenuItem.Name = "пошукToolStripMenuItem";
            this.пошукToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.пошукToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.пошукToolStripMenuItem.Size = new System.Drawing.Size(229, 22);
            this.пошукToolStripMenuItem.Text = "Пошук";
            this.пошукToolStripMenuItem.Click += new System.EventHandler(this.пошукToolStripMenuItem_Click);
            // 
            // оРозробникуToolStripMenuItem
            // 
            this.оРозробникуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проРозробникаToolStripMenuItem});
            this.оРозробникуToolStripMenuItem.Name = "оРозробникуToolStripMenuItem";
            this.оРозробникуToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.оРозробникуToolStripMenuItem.Text = "Інформація";
            // 
            // проРозробникаToolStripMenuItem
            // 
            this.проРозробникаToolStripMenuItem.Name = "проРозробникаToolStripMenuItem";
            this.проРозробникаToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+I";
            this.проРозробникаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.проРозробникаToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.проРозробникаToolStripMenuItem.Text = "Про програму";
            this.проРозробникаToolStripMenuItem.Click += new System.EventHandler(this.проРозробникаToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lable
            // 
            this.status_lable.Name = "status_lable";
            this.status_lable.Size = new System.Drawing.Size(0, 17);
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTextBox.Location = new System.Drawing.Point(3, 16);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(794, 385);
            this.mainTextBox.TabIndex = 1;
            this.mainTextBox.Text = "";
            this.mainTextBox.FontChanged += new System.EventHandler(this.richTextBox1_FontChanged);
            // 
            // text_groupBox
            // 
            this.text_groupBox.Controls.Add(this.mainTextBox);
            this.text_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_groupBox.Location = new System.Drawing.Point(0, 24);
            this.text_groupBox.Name = "text_groupBox";
            this.text_groupBox.Size = new System.Drawing.Size(800, 404);
            this.text_groupBox.TabIndex = 3;
            this.text_groupBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Galysh Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.text_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зберігтиФайлЯкToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem відкритиНовийФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберігтиФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратиШрифтToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem форматToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переносРядківToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem збільшитиШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зменшитиШрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox FontSizeTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status_lable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.GroupBox text_groupBox;
        private System.Windows.Forms.ToolStripMenuItem оРозробникуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проРозробникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошукToolStripMenuItem;
        public System.Windows.Forms.RichTextBox mainTextBox;
    }
}

