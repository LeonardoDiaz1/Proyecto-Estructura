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
    public partial class Pilas2 : Form
    {
        public Pilas2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaPilas.Items.Clear();
            Random numero = new Random();
            int n = numero.Next(1, 99);

            ListaColas.Items.Add(n.ToString());

            int i;

            for (i = ListaColas.Items.Count - 1; i >= 0; i--)
            {
                ListaPilas.Items.Add(ListaColas.Items[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ListaColas.Items.RemoveAt(0);
            ListaPilas.Items.RemoveAt(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaColas.Items.Clear();
            ListaPilas.Items.Clear();

        }
    }
}
