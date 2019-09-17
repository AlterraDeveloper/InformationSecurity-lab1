namespace Project
{
    partial class FrequentDictForm
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
            this.dataGridFreqDict = new System.Windows.Forms.DataGridView();
            this.dataGridPrimaryFreqDict = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFreqDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrimaryFreqDict)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFreqDict
            // 
            this.dataGridFreqDict.AllowUserToAddRows = false;
            this.dataGridFreqDict.AllowUserToDeleteRows = false;
            this.dataGridFreqDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFreqDict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFreqDict.ColumnHeadersHeight = 40;
            this.dataGridFreqDict.Location = new System.Drawing.Point(12, 40);
            this.dataGridFreqDict.Name = "dataGridFreqDict";
            this.dataGridFreqDict.ReadOnly = true;
            this.dataGridFreqDict.Size = new System.Drawing.Size(326, 506);
            this.dataGridFreqDict.TabIndex = 0;
            // 
            // dataGridPrimaryFreqDict
            // 
            this.dataGridPrimaryFreqDict.AllowUserToAddRows = false;
            this.dataGridPrimaryFreqDict.AllowUserToDeleteRows = false;
            this.dataGridPrimaryFreqDict.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPrimaryFreqDict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPrimaryFreqDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPrimaryFreqDict.Location = new System.Drawing.Point(369, 40);
            this.dataGridPrimaryFreqDict.Name = "dataGridPrimaryFreqDict";
            this.dataGridPrimaryFreqDict.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPrimaryFreqDict.Size = new System.Drawing.Size(326, 506);
            this.dataGridPrimaryFreqDict.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Частотный словарь для зашифрованного текста";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Частотный словарь русского языка";
            // 
            // FrequentDictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridPrimaryFreqDict);
            this.Controls.Add(this.dataGridFreqDict);
            this.Name = "FrequentDictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrequentDict";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFreqDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPrimaryFreqDict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFreqDict;
        private System.Windows.Forms.DataGridView dataGridPrimaryFreqDict;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}