using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura
{
    public partial class Arreglos : Form
    {
        ArrayList Vector01;
        public Arreglos()
        {
            InitializeComponent();
            Vector01 = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vector01.Add(textBox1.Text.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < Vector01.Count; i++)
            {
                listBox1.Items.Add(Vector01[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int posicion;

            posicion = Int32.Parse(textBox2.Text);
            textBox3.Text = Vector01[posicion].ToString();

        }
    }
}
