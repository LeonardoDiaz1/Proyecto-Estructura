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
    public partial class Arreglo2 : Form
    {
        public Arreglo2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int numero = 1; numero <= 100; numero += 2)
            {
                listBox1.Items.Add(numero);
            }
        }
    }
}
