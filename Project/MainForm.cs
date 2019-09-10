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
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
                btnShowFrequencyDictionaryForInputText.Enabled = true;
            }
            else
            {
                btnDecrypt.Enabled = false;
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
                File.AppendAllText(explorer.FileName, outputTextBox.Text);

                MessageBox.Show($"Файл {explorer.FileName}  успешно сохранен!", "Success", MessageBoxButtons.OK);

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
            if (int.TryParse(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")), out inputKey))
            {
                if (inputKey > 0 && inputKey < 10)
                {
                    caesarKeyInput.Text = inputKey.ToString();
                    return;
                }

            }
            caesarKeyInput.Text = string.Empty;

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Dictionary<char, double> primaryDict = new Dictionary<char, double>
            {
                { 'е' , 8.45 },
                { 'а' , 8.01 },
                { 'и' , 7.35 },
                { 'н' , 6.70 },
                { 'т' , 6.26 },
                { 'с' , 5.47 },
                { 'р' , 4.73},
                { 'в' , 4.54 },
                { 'л' ,  4.40},
                { 'к' ,  3.49},
                { 'м' ,  3.21},
                { 'д' ,  2.98},
                { 'п' ,  2.81},
                { 'у' ,  2.62},
                { 'я' ,  2.01},
                { 'ы' ,  1.90},
                { 'ь' ,  1.74},
                { 'г' ,  1.70},
                { 'з' ,  1.65},
                { 'б' ,  1.59},
                { 'ч' ,  1.44},
                { 'й' ,  1.21},
                { 'х' ,  0.97},
                { 'ж' ,  0.94},
                { 'ш' ,  0.73},
                { 'ю' ,  0.64},
                { 'ц' ,  0.48},
                { 'щ' ,  0.36},
                { 'э' ,  0.32},
                { 'ф' ,  0.26},
                { 'ъ' ,  0.04},
                { 'ё' ,  0.04}
            };

            for (int i = 1; i < 10; i++)
            {
                var decryptText = new CaesarEncoder(-i).Encrypt(inputTextBox.Text);

            }
        }
    }
}
