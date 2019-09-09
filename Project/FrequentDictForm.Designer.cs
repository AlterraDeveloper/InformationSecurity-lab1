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
            this.components = new System.ComponentModel.Container();
            this.dataGridFreqDict = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.frequentCounterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFreqDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequentCounterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFreqDict
            // 
            this.dataGridFreqDict.AllowUserToAddRows = false;
            this.dataGridFreqDict.AllowUserToDeleteRows = false;
            this.dataGridFreqDict.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFreqDict.ColumnHeadersHeight = 40;
            this.dataGridFreqDict.Location = new System.Drawing.Point(12, 46);
            this.dataGridFreqDict.Name = "dataGridFreqDict";
            this.dataGridFreqDict.ReadOnly = true;
            this.dataGridFreqDict.Size = new System.Drawing.Size(453, 460);
            this.dataGridFreqDict.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Частотный словарь";
            // 
            // frequentCounterBindingSource
            // 
            this.frequentCounterBindingSource.DataSource = typeof(Project.FrequentCounter);
            // 
            // FrequentDictForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridFreqDict);
            this.Name = "FrequentDictForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrequentDict";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFreqDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequentCounterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFreqDict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource frequentCounterBindingSource;
    }
}