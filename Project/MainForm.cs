using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                outputTextBox.Text = new CaesarEncoder(1).Encrypt(inputTextBox.Text);
            }
            if (radioBtnTritemiusEncoding.Checked)
            {
                outputTextBox.Text = new TritemiusEncoder("шифр").Encrypt(inputTextBox.Text); 
            }
        }

        private void enableCryptButton(object sender, EventArgs e)
        {
            if (inputTextBox.Text != string.Empty &&
                (radioBtnCaesarEncoding.Checked || radioBtnMonoEncoding.Checked || radioBtnTritemiusEncoding.Checked))
            {
                btnEncrypt.Enabled = true;
            }
            else
            {
                btnEncrypt.Enabled = false;
            }
        }
    }
}
