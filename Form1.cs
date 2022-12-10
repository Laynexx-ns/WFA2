using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA2
{
    public partial class Form1 : Form
    {
        //метод инициализации
        public Form1()
        {
            InitializeComponent();
        }
        //метод нажатия кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "=^-^";
            button1.BackColor = Color.LightBlue;
            button1.Enabled = false;

        }
        //метод загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Do not PUDGE";
            label1.Text = "made by nn";
            textBox1.Text = "delete here";
            label1.Text = textBox1.Text;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //метод ресета
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.BackColor = Color.CadetBlue;
            button1.Text = "тут скример";

        }
    }
}
