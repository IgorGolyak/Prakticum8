using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = textBox1.Text;
            int r = Convert.ToInt32(textBox2.Text);
            double v = Convert.ToDouble(textBox3.Text);
            People p = new People();
            p.FIO = fio;
            p.rost = r;
            p.ves = v;
            listBox1.Items.Add(p);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex== -1)
            {
                MessageBox.Show("Не выбран объект для удаления");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(k);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран объект для редактирования");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                People p = listBox1.Items[k] as People;
                textBox1.Text = p.FIO;
                textBox2.Text = p.rost.ToString();
                textBox3.Text = p.ves.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                People p = listBox1.Items[i] as People;
                sum += p.rost;
            }
            MessageBox.Show((sum / listBox1.Items.Count).ToString());
        }
    }
}
