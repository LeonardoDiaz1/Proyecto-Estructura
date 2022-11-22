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
    public partial class Recursividad1 : Form
    {
        public Recursividad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numero = 0;
            int unidad = 0;
            int decena = 0;
            int centena = 0;
            int invertido = 0;

            numero = int.Parse(textBox1.Text);

            unidad = numero % 10;
            decena = (numero / 10) % 10;
            centena = numero = 100;
            invertido = (unidad = 100) + (decena * 10) + centena;

            textBox2.Text = invertido.ToString();


        }

    }
}


       
        
        


