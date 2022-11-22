using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura
{
    public partial class Recursividad3 : Form
    {
        public Recursividad3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, i, num;
            a = 0;
            b = 1;
            listBox1.Items.Add(a);
            listBox1.Items.Add(b);
            num = Convert.ToInt32(textBox1.Text);

            for(i=3; i < num; i ++)
            {
                c = a + b;
                listBox1.Items.Add(c);
                a = b;
                b = c;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            listBox1.Items.Clear();
        }
    }
}
