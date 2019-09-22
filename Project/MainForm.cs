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
        Dictionary<char, double> _primaryDict = new Dictionary<char, double>
        {
            { 'о', 10.98},
            { 'е' , 8.45 },
            { 'а' , 8.01 },
            { 'и' , 7.37 },
            { 'н' , 6.70 },
            { 'т' , 6.32 },
            { 'с' , 5.47 },
            { 'р' , 4.75},
            { 'в' , 4.54 },
            { 'л' ,  4.34},
            { 'к' ,  3.49},
            { 'м' ,  3.21},
            { 'д' ,  2.98},
            { 'п' ,  2.81},
            { 'у' ,  2.62},
            { 'я' ,  2.01},
            { 'ы' ,  1.90},
            { 'ь' ,  1.74},
            { 'г' ,  1.69},
            { 'з' ,  1.64},
            { 'б' ,  1.59},
            { 'ч' ,  1.45},
            { 'й' ,  1.21},
            { 'х' ,  0.97},
            { 'ж' ,  0.94},
            { 'ш' ,  0.72},
            { 'ю' ,  0.64},
            { 'ц' ,  0.49},
            { 'щ' ,  0.36},
            { 'э' ,  0.33},
            { 'ф' ,  0.27},
            { 'ъ' ,  0.04},
            { 'ё' ,  0.02}
        };

        public MainForm()
        {
            InitializeComponent();

            caesarKeyInput.Maximum = 32;
            caesarKeyInput.Minimum = 1;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (radioBtnMonoEncoding.Checked)
            {
                outputTextBox.Text = new MonoEncoder().Encrypt(inputTextBox.Text);
            }

            if (radioBtnCaesarEncoding.Checked)
            {
                outputTextBox.Text = new CaesarEncoder((int)caesarKeyInput.Value).Encrypt(inputTextBox.Text);
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
            }
            else
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
        }

        private void btnLoadTextFromFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                var textFromFile = File.ReadAllText(explorer.FileName,Encoding.Default);

                inputTextBox.Text = textFromFile;
            }
        }

        private void btnSaveTextToFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(explorer.FileName, outputTextBox.Text);

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
            inputTextBox.Text = outputTextBox.Text;

            if (radioBtnMonoEncoding.Checked)
            {
                outputTextBox.Text = new MonoEncoder().Decrypt(inputTextBox.Text);
            }
            if (radioBtnCaesarEncoding.Checked)
            {
                Dictionary<int, double> sumArray = new Dictionary<int, double>();

                for (int i = 1; i < _primaryDict.Keys.Count; i++)
                {
                    var decryptText = new CaesarEncoder(-i).Encrypt(inputTextBox.Text);
                    double value;
                    sumArray[i] = decryptText.ToLower().Sum(ch => _primaryDict.TryGetValue(ch, out value) ? value : 0);
                }

                var caesarKey = sumArray.OrderByDescending(x => x.Value).First().Key;

                MessageBox.Show($"Ключ шифрования : {caesarKey}", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = new CaesarEncoder(caesarKey * (-1)).Encrypt(inputTextBox.Text);
            }
            if (radioBtnTritemiusEncoding.Checked)
            {
                outputTextBox.Text = new TritemiusEncoder(tritemiusWordInput.Text).Decrypt(inputTextBox.Text);
            }

            

            
        }
    }
}
