using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public partial class FrequentDictForm : Form
    {
        public FrequentDictForm(Dictionary<char,double> dataSource)
        {
            InitializeComponent();

            dataGridFreqDict.DataSource =
                (from pair in dataSource orderby pair.Value descending select new {letterColumn = pair.Key, countColumn = pair.Value}).ToList();

            dataGridFreqDict.Columns[0].HeaderText = "Буква";
            dataGridFreqDict.Columns[1].HeaderText = "Частота появления в %";

        }
    }
}
