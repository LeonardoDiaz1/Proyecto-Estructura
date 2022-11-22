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
    public partial class Colas1_2_3 : Form
    {
        cola miCola = new cola();
        public Colas1_2_3()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (txtNombreNodo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre de nodo valido");
            }
            else
            {
                nodo unNuevoNuevo = new nodo();
                unNuevoNuevo.Nombre = txtNombreNodo.Text;
                miCola.Encolar(unNuevoNuevo);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if (miCola.Vacia())
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                miCola.Desencolar();
                MostrarCola();
            }
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            MostrarNodoEnPantalla(miCola.Inicio);
        }

        private void MostrarNodoEnPantalla(nodo unNodo)
        {
            if (unNodo != null)
            {
                lstCola.Items.Add(unNodo.Nombre);

                if (unNodo.Siguiente != null)
                {
                    MostrarNodoEnPantalla(unNodo.Siguiente);
                }
            }
        }
    }
}
