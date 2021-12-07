using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR_TextEditor
{
    public partial class Form_find : Form
    {
        private Form1 mainForm;
        public Form_find(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        int index = -1;
        private void found_btn_Click(object sender, EventArgs e)
        {
            if (mainForm.mainTextBox.Text.Length <= 0)
            {
                return;
            }

            int tmp_index = index;
            var length = mainForm.mainTextBox.SelectedText.Length;
            if (length == 0) length++;

            if (checkMatch.Checked && radioBtn_start.Checked)
            {
                tmp_index = mainForm.mainTextBox.Find(textBox_find.Text, tmp_index + length, RichTextBoxFinds.MatchCase);
            }
            else if (checkMatch.Checked && radioBtn_end.Checked)
            {
                var mode = RichTextBoxFinds.MatchCase | RichTextBoxFinds.Reverse;
                tmp_index = mainForm.mainTextBox.Find(textBox_find.Text, tmp_index + length, mode);
            }
            else if (!checkMatch.Checked && radioBtn_end.Checked)
            {
                tmp_index = mainForm.mainTextBox.Find(textBox_find.Text, tmp_index + length, RichTextBoxFinds.Reverse);
            }
            else if (!checkMatch.Checked && !radioBtn_end.Checked)
            {
                tmp_index = mainForm.mainTextBox.Find(textBox_find.Text, tmp_index + length, RichTextBoxFinds.None);
            }

            if (tmp_index >= 0)
            {
                mainForm.mainTextBox.Focus();
                mainForm.mainTextBox.Select(tmp_index, textBox_find.Text.Length);
                index = tmp_index;
            }
            mainForm.BringToFront();

        }

        private void textBox_find_TextChanged(object sender, EventArgs e)
        {
            index = 0;
            mainForm.mainTextBox.SelectedText = "";
        }
    }
}
