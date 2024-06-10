using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace desk3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            //listBox1.Items.Count // 항목 수 정수 반환
            //listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int a = listBox1.Items.Count;

            textBox1.Text = a.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
