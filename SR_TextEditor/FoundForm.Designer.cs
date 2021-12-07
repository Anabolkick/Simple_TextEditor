
namespace SR_TextEditor
{
    partial class Form_find
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_find));
            this.textBox_find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.found_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtn_end = new System.Windows.Forms.RadioButton();
            this.radioBtn_start = new System.Windows.Forms.RadioButton();
            this.checkMatch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_find
            // 
            this.textBox_find.Location = new System.Drawing.Point(24, 48);
            this.textBox_find.Name = "textBox_find";
            this.textBox_find.Size = new System.Drawing.Size(347, 20);
            this.textBox_find.TabIndex = 0;
            this.textBox_find.TextChanged += new System.EventHandler(this.textBox_find_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Що треба знайти?";
            // 
            // found_btn
            // 
            this.found_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.found_btn.Location = new System.Drawing.Point(214, 123);
            this.found_btn.Name = "found_btn";
            this.found_btn.Size = new System.Drawing.Size(157, 37);
            this.found_btn.TabIndex = 1;
            this.found_btn.Text = "Знайти наступне";
            this.found_btn.UseVisualStyleBackColor = true;
            this.found_btn.Click += new System.EventHandler(this.found_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtn_end);
            this.groupBox1.Controls.Add(this.radioBtn_start);
            this.groupBox1.Location = new System.Drawing.Point(24, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // radioBtn_end
            // 
            this.radioBtn_end.AutoSize = true;
            this.radioBtn_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_end.Location = new System.Drawing.Point(6, 40);
            this.radioBtn_end.Name = "radioBtn_end";
            this.radioBtn_end.Size = new System.Drawing.Size(122, 20);
            this.radioBtn_end.TabIndex = 4;
            this.radioBtn_end.Text = "Шукати з кінця";
            this.radioBtn_end.UseVisualStyleBackColor = true;
            // 
            // radioBtn_start
            // 
            this.radioBtn_start.AutoSize = true;
            this.radioBtn_start.Checked = true;
            this.radioBtn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_start.Location = new System.Drawing.Point(6, 10);
            this.radioBtn_start.Name = "radioBtn_start";
            this.radioBtn_start.Size = new System.Drawing.Size(143, 20);
            this.radioBtn_start.TabIndex = 3;
            this.radioBtn_start.TabStop = true;
            this.radioBtn_start.Text = "Шукати з початку";
            this.radioBtn_start.UseVisualStyleBackColor = true;
            // 
            // checkMatch
            // 
            this.checkMatch.AutoSize = true;
            this.checkMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkMatch.Location = new System.Drawing.Point(24, 87);
            this.checkMatch.Name = "checkMatch";
            this.checkMatch.Size = new System.Drawing.Size(227, 20);
            this.checkMatch.TabIndex = 2;
            this.checkMatch.Text = "Пошук з урахуванням регістру";
            this.checkMatch.UseVisualStyleBackColor = true;
            // 
            // Form_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.checkMatch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.found_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_find);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 230);
            this.MinimumSize = new System.Drawing.Size(400, 230);
            this.Name = "Form_find";
            this.Text = "Пошук";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button found_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtn_end;
        private System.Windows.Forms.RadioButton radioBtn_start;
        private System.Windows.Forms.CheckBox checkMatch;
    }
}