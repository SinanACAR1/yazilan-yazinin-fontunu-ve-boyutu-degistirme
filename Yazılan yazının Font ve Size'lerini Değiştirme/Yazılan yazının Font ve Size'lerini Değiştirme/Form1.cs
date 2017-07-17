using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.InstalledFontCollection yazitipi = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily eklenen in yazitipi.Families)
            {
                comboBox1.Items.Add(eklenen.Name);
            }
            numericUpDown1.Minimum = 8;
            numericUpDown1.Maximum = 80;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           richTextBox1.Font = new Font(comboBox1.Text,richTextBox1.Font.Size);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int deger = int.Parse(numericUpDown1.Value.ToString());

           richTextBox1.Font = new Font(richTextBox1.Font.FontFamily.Name, deger);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox2.Text;
        }
    }
}
