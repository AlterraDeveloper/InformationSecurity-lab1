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

namespace Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (radioBtnMonoEncoding.Checked)
            {
                outputTextBox.Text = new MonoEncoder().Encrypt(inputTextBox.Text);
            }

            if (radioBtnCaesarEncoding.Checked)
            {
                outputTextBox.Text = new CaesarEncoder(int.Parse(caesarKeyInput.Text)).Encrypt(inputTextBox.Text);
            }
            if (radioBtnTritemiusEncoding.Checked)
            {
                outputTextBox.Text = new TritemiusEncoder(tritemiusWordInput.Text).Encrypt(inputTextBox.Text); 
            }
        }

        private void enableCryptButton(object sender, EventArgs e)
        {
            if (inputTextBox.Text != string.Empty &&
                (radioBtnCaesarEncoding.Checked || radioBtnMonoEncoding.Checked || radioBtnTritemiusEncoding.Checked))
            {
                btnEncrypt.Enabled = true;
                btnShowFrequencyDictionaryForInputText.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = false;
                btnShowFrequencyDictionaryForInputText.Enabled = false;
            }
        }

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                var textFromFile = File.ReadAllText(explorer.FileName);

                inputTextBox.Text = textFromFile;
            }
        }

        private void btnSaveTextToFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllText(explorer.FileName,outputTextBox.Text);

                MessageBox.Show($"Файл {explorer.FileName}  успешно сохранен!","Success",MessageBoxButtons.OK);

                outputTextBox.Text = string.Empty;
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (outputTextBox.Text != string.Empty)
            {
                btnSaveTextToFile.Enabled = true;
                btnShowFrequencyDictionaryForOutputText.Enabled = true;
            }
            else
            {
                btnSaveTextToFile.Enabled = false;
                btnShowFrequencyDictionaryForOutputText.Enabled = false;
            }
        }

        private void btnShowFrequencyDictionaryForInputText_Click(object sender, EventArgs e)
        {
            new FrequentDictForm(FrequentCounter.countAppearencesOfLetter(inputTextBox.Text)).Show();
        }

        private void btnShowFrequencyDictionaryForOutputText_Click(object sender, EventArgs e)
        {
            new FrequentDictForm(FrequentCounter.countAppearencesOfLetter(outputTextBox.Text)).Show();
        }

        private void caesarKeyInput_TextChanged(object sender, EventArgs e)
        {
            int inputKey;
            if ( int.TryParse(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")),out inputKey))
            {
                if (inputKey > 0 && inputKey < 10)
                {
                    caesarKeyInput.Text = inputKey.ToString();
                    return;
                }
                
            }
            caesarKeyInput.Text = string.Empty;
            
        }
    }
}
