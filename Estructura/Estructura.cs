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
    public partial class Estructura : Form
    {
        public Estructura()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arreglos obj = new Arreglos();
            obj.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arreglo2 drogo = new Arreglo2();
            drogo.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arreglo3 drag = new Arreglo3();
            drag.Show();
        }

        private void ejercicios1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriz1 matr = new Matriz1();
            matr.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Recursividad1 recur = new Recursividad1();
            recur.Show();
        }

        private void ejercicio2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Recurisividad2 dosre = new Recurisividad2();
            dosre.Show();

        }

        private void ejcercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Recursividad3 retres = new Recursividad3();
            retres.Show();
        }

        private void ejercicio1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Pilas1 pila = new Pilas1();
            pila.Show();
        }

        private void ejercicio2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Pilas2 pil = new Pilas2();
            pil.Show();
        }

        private void ejercicio1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Colas1_2_3 cola = new Colas1_2_3();
            cola.Show();
        }
    }
}
