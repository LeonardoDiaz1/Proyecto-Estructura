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
    public partial class Colas_Ejercicio : Form
    {
        public Colas_Ejercicio()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            n = int.Parse(textBox1.Text);
            //laCola.Enqueue(n);
            MessageBox.Show("VALOR AGREGADO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n;
            //n = laCola.Dequeue();
            MessageBox.Show("SALIOD:" + n);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            laCola.Items.Clear();
            //for( i = 0; i <= laCola.Count - 1; i++ )
            {
                //laCola.Items.Add(laCola.ElementAt(i));
            }
        }
    }
}
