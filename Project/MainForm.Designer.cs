namespace Project
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.radioBtnsGroupCryptMethods = new System.Windows.Forms.GroupBox();
            this.caesarKeyInput = new System.Windows.Forms.NumericUpDown();
            this.tritemiusWordInput = new System.Windows.Forms.TextBox();
            this.radioBtnTritemiusEncoding = new System.Windows.Forms.RadioButton();
            this.radioBtnCaesarEncoding = new System.Windows.Forms.RadioButton();
            this.radioBtnMonoEncoding = new System.Windows.Forms.RadioButton();
            this.btnLoadTextFromFile = new System.Windows.Forms.Button();
            this.btnSaveTextToFile = new System.Windows.Forms.Button();
            this.btnShowFrequencyDictionaryForOutputText = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.radioBtnsGroupCryptMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarKeyInput)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 30);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(562, 187);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.enableCryptButton);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 385);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(562, 187);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(12, 241);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(203, 37);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Зашифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // radioBtnsGroupCryptMethods
            // 
            this.radioBtnsGroupCryptMethods.Controls.Add(this.caesarKeyInput);
            this.radioBtnsGroupCryptMethods.Controls.Add(this.tritemiusWordInput);
            this.radioBtnsGroupCryptMethods.Controls.Add(this.radioBtnTritemiusEncoding);
            this.radioBtnsGroupCryptMethods.Controls.Add(this.radioBtnCaesarEncoding);
            this.radioBtnsGroupCryptMethods.Controls.Add(this.radioBtnMonoEncoding);
            this.radioBtnsGroupCryptMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnsGroupCryptMethods.Location = new System.Drawing.Point(243, 241);
            this.radioBtnsGroupCryptMethods.Name = "radioBtnsGroupCryptMethods";
            this.radioBtnsGroupCryptMethods.Size = new System.Drawing.Size(318, 138);
            this.radioBtnsGroupCryptMethods.TabIndex = 3;
            this.radioBtnsGroupCryptMethods.TabStop = false;
            this.radioBtnsGroupCryptMethods.Text = "Метод шифрования";
            // 
            // caesarKeyInput
            // 
            this.caesarKeyInput.Location = new System.Drawing.Point(161, 60);
            this.caesarKeyInput.Name = "caesarKeyInput";
            this.caesarKeyInput.Size = new System.Drawing.Size(120, 26);
            this.caesarKeyInput.TabIndex = 5;
            this.caesarKeyInput.ValueChanged += new System.EventHandler(this.caesarKeyInput_TextChanged);
            // 
            // tritemiusWordInput
            // 
            this.tritemiusWordInput.Location = new System.Drawing.Point(193, 95);
            this.tritemiusWordInput.Name = "tritemiusWordInput";
            this.tritemiusWordInput.Size = new System.Drawing.Size(119, 26);
            this.tritemiusWordInput.TabIndex = 4;
            // 
            // radioBtnTritemiusEncoding
            // 
            this.radioBtnTritemiusEncoding.AutoSize = true;
            this.radioBtnTritemiusEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnTritemiusEncoding.Location = new System.Drawing.Point(14, 96);
            this.radioBtnTritemiusEncoding.Name = "radioBtnTritemiusEncoding";
            this.radioBtnTritemiusEncoding.Size = new System.Drawing.Size(172, 20);
            this.radioBtnTritemiusEncoding.TabIndex = 2;
            this.radioBtnTritemiusEncoding.TabStop = true;
            this.radioBtnTritemiusEncoding.Text = "Алгоритм Тритемиуса";
            this.radioBtnTritemiusEncoding.UseVisualStyleBackColor = true;
            this.radioBtnTritemiusEncoding.CheckedChanged += new System.EventHandler(this.enableCryptButton);
            // 
            // radioBtnCaesarEncoding
            // 
            this.radioBtnCaesarEncoding.AutoSize = true;
            this.radioBtnCaesarEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnCaesarEncoding.Location = new System.Drawing.Point(14, 61);
            this.radioBtnCaesarEncoding.Name = "radioBtnCaesarEncoding";
            this.radioBtnCaesarEncoding.Size = new System.Drawing.Size(140, 20);
            this.radioBtnCaesarEncoding.TabIndex = 1;
            this.radioBtnCaesarEncoding.TabStop = true;
            this.radioBtnCaesarEncoding.Text = "Алгоритм Цезаря";
            this.radioBtnCaesarEncoding.UseVisualStyleBackColor = true;
            this.radioBtnCaesarEncoding.CheckedChanged += new System.EventHandler(this.enableCryptButton);
            // 
            // radioBtnMonoEncoding
            // 
            this.radioBtnMonoEncoding.AutoSize = true;
            this.radioBtnMonoEncoding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtnMonoEncoding.Location = new System.Drawing.Point(14, 25);
            this.radioBtnMonoEncoding.Name = "radioBtnMonoEncoding";
            this.radioBtnMonoEncoding.Size = new System.Drawing.Size(298, 20);
            this.radioBtnMonoEncoding.TabIndex = 0;
            this.radioBtnMonoEncoding.TabStop = true;
            this.radioBtnMonoEncoding.Text = "Алгоритм моно алфавитной подстановки";
            this.radioBtnMonoEncoding.UseVisualStyleBackColor = true;
            this.radioBtnMonoEncoding.CheckedChanged += new System.EventHandler(this.enableCryptButton);
            // 
            // btnLoadTextFromFile
            // 
            this.btnLoadTextFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadTextFromFile.Location = new System.Drawing.Point(596, 30);
            this.btnLoadTextFromFile.Name = "btnLoadTextFromFile";
            this.btnLoadTextFromFile.Size = new System.Drawing.Size(149, 66);
            this.btnLoadTextFromFile.TabIndex = 4;
            this.btnLoadTextFromFile.Text = "Загрузить текст из файла";
            this.btnLoadTextFromFile.UseVisualStyleBackColor = true;
            this.btnLoadTextFromFile.Click += new System.EventHandler(this.btnLoadTextFromFile_Click);
            // 
            // btnSaveTextToFile
            // 
            this.btnSaveTextToFile.Enabled = false;
            this.btnSaveTextToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveTextToFile.Location = new System.Drawing.Point(596, 385);
            this.btnSaveTextToFile.Name = "btnSaveTextToFile";
            this.btnSaveTextToFile.Size = new System.Drawing.Size(149, 66);
            this.btnSaveTextToFile.TabIndex = 6;
            this.btnSaveTextToFile.Text = "Сохранить текст в файл";
            this.btnSaveTextToFile.UseVisualStyleBackColor = true;
            this.btnSaveTextToFile.Click += new System.EventHandler(this.btnSaveTextToFile_Click);
            // 
            // btnShowFrequencyDictionaryForOutputText
            // 
            this.btnShowFrequencyDictionaryForOutputText.Enabled = false;
            this.btnShowFrequencyDictionaryForOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFrequencyDictionaryForOutputText.Location = new System.Drawing.Point(596, 457);
            this.btnShowFrequencyDictionaryForOutputText.Name = "btnShowFrequencyDictionaryForOutputText";
            this.btnShowFrequencyDictionaryForOutputText.Size = new System.Drawing.Size(149, 66);
            this.btnShowFrequencyDictionaryForOutputText.TabIndex = 8;
            this.btnShowFrequencyDictionaryForOutputText.Text = "Показать частотный словарь";
            this.btnShowFrequencyDictionaryForOutputText.UseVisualStyleBackColor = true;
            this.btnShowFrequencyDictionaryForOutputText.Click += new System.EventHandler(this.btnShowFrequencyDictionaryForOutputText_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrypt.Location = new System.Drawing.Point(13, 285);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(202, 37);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Расшифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 584);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnShowFrequencyDictionaryForOutputText);
            this.Controls.Add(this.btnSaveTextToFile);
            this.Controls.Add(this.btnLoadTextFromFile);
            this.Controls.Add(this.radioBtnsGroupCryptMethods);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.radioBtnsGroupCryptMethods.ResumeLayout(false);
            this.radioBtnsGroupCryptMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caesarKeyInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox radioBtnsGroupCryptMethods;
        private System.Windows.Forms.RadioButton radioBtnTritemiusEncoding;
        private System.Windows.Forms.RadioButton radioBtnCaesarEncoding;
        private System.Windows.Forms.RadioButton radioBtnMonoEncoding;
        private System.Windows.Forms.Button btnLoadTextFromFile;
        private System.Windows.Forms.Button btnSaveTextToFile;
        private System.Windows.Forms.Button btnShowFrequencyDictionaryForOutputText;
        private System.Windows.Forms.TextBox tritemiusWordInput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.NumericUpDown caesarKeyInput;
    }
}

