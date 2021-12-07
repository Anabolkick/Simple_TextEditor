using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var font = mainTextBox.Font;
            status_lable.Text = $"Font: {font.Name} | Size: {font.Size} | Bold: {font.Bold} | Italic: {font.Italic}";

        }

        private FontConverter converter = new FontConverter();
        private string currPath;
        void SaveGalyshFormat(string path)
        {
            List<string> strList = new List<string>();
            strList.Add("FF:" + converter.ConvertToString(mainTextBox.Font));
            strList.Add("WW:" + mainTextBox.WordWrap);
            strList.Add(mainTextBox.Text);
            File.WriteAllLines(path, strList);
        }

        void SaveTxtFormat(string path)
        {
            List<string> strList = new List<string>();
            strList.Add(mainTextBox.Text);
            File.WriteAllLines(path, strList);
        }

        private void відкритиНовийФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Galysh|*.galysh|TXT|*.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currPath = openFileDialog1.FileName;
                var text = File.ReadAllLines(currPath);
                bool isFontFound = false;
                bool isWrapFound = false;
                mainTextBox.Clear();

                foreach (var line in text)
                {
                    if (!isFontFound && line.Contains("FF:"))
                    {
                        int index = line.IndexOf(':');
                        var font_str = line.Substring(index + 1, line.Length - (index + 1));
                        Font font = converter.ConvertFromString(font_str) as Font;
                        mainTextBox.Font = font;
                    }
                    else if (!isWrapFound && line.Contains("WW:"))
                    {
                        int index = line.IndexOf(':');
                        bool ww = (Convert.ToBoolean(line.Substring(index + 1, line.Length - (index + 1))));
                        mainTextBox.WordWrap = ww;
                        переносРядківToolStripMenuItem.Checked = ww;
                    }
                    else
                    {
                        mainTextBox.Text += line;
                        mainTextBox.Text += Environment.NewLine;
                    }
                }
                this.Text = $"{openFileDialog1.SafeFileName} - Galysh Text Editor";
                openFileDialog1.FileName = "";
            }
        }

        private void зберігтиФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Galysh|*.galysh";

            if (currPath != "")
            {
                if (currPath.EndsWith(".galysh"))
                {
                    SaveGalyshFormat(currPath);
                    MessageBox.Show("Файл збережено у форматі .galysh!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(currPath.EndsWith(".txt"))
                {
                    SaveTxtFormat(currPath);
                    MessageBox.Show("Файл збережено у форматі .txt!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currPath = saveFileDialog1.FileName;
                SaveGalyshFormat(saveFileDialog1.FileName);
                var name = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('\\') + 1);
                this.Text = $"{name} - Galysh Text Editor";
                saveFileDialog1.FileName = "";
            }
        }

        private void зберігтиФайлЯкToolStripMenuItem_Click(object sender, EventArgs e) //наследованеи
        {
            saveFileDialog1.Filter = "Galysh|*.galysh|TXT|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currPath = saveFileDialog1.FileName;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        SaveGalyshFormat(currPath);
                        break;
                    case 2:
                        SaveTxtFormat(currPath);
                        break;
                    default:
                        SaveTxtFormat(currPath);
                        break;
                }

                var name = saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.LastIndexOf('\\') + 1);
                this.Text = $"{name} - Galysh Text Editor";
                saveFileDialog1.FileName = "";
            }
        }

        private void обратиШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = mainTextBox.Font;
            fontDialog1.ShowDialog();
            mainTextBox.Font = fontDialog1.Font;
        }

        private void переносРядківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainTextBox.WordWrap = !mainTextBox.WordWrap;
            переносРядківToolStripMenuItem.Checked = !переносРядківToolStripMenuItem.Checked;
        }

        private void збільшитиШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontFamily = mainTextBox.Font.FontFamily;
            float size = mainTextBox.Font.Size + 1.5f;
            mainTextBox.Font = new Font(fontFamily, size, mainTextBox.Font.Style);
        }

        private void зменшитиШрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fontFamily = mainTextBox.Font.FontFamily;
            float size = mainTextBox.Font.Size - 1.5f;
            mainTextBox.Font = new Font(fontFamily, size, mainTextBox.Font.Style);
        }

        private void richTextBox1_FontChanged(object sender, EventArgs e)
        {
            var font = mainTextBox.Font;
            status_lable.Text = $"Font: {font.Name} | Size: {font.Size} | Bold: {font.Bold} | Italic: {font.Italic}";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int size;
            if (Int32.TryParse(FontSizeTool.Text, out size))
            {
                var fontFamily = mainTextBox.Font.FontFamily;
                if (size > 0)
                {
                    mainTextBox.Font = new Font(fontFamily, size, mainTextBox.Font.Style);
                }
                else
                {
                    MessageBox.Show("Введіть розмір більше 0!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                MessageBox.Show("Введіть число починаючи з 0!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Font = mainTextBox.Font;
            Properties.Settings.Default.WordWrap = mainTextBox.WordWrap;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainTextBox.Font = Properties.Settings.Default.Font;
            mainTextBox.WordWrap = Properties.Settings.Default.WordWrap;
            переносРядківToolStripMenuItem.Checked = Properties.Settings.Default.WordWrap;
        }

        private void проРозробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Розроблено Галиш Олегом з групи КНТ-120", "Розробник", MessageBoxButtons.OK, MessageBoxIcon.Information);
           Form_dev formDev = new Form_dev();
           formDev.Show();
        }

        private void пошукToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_find formFind = new Form_find(this);
            formFind.Show();
        }
    }
}
