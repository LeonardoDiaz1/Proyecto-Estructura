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
    public partial class Arreglo3 : Form
    {
        public Arreglo3()
        {
            InitializeComponent();
        }
        // Creacion del arreglo ArrayList
        ArrayList datosUsuarios = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Debe de ingresar el nombre del usuario");
                textBox1.Focus();
                return;
            }
            errorProvider1.SetError(textBox1, "");
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Debe de ingresar la edad del usuario");
                textBox2.Focus();
                return;
            }
            errorProvider1.SetError(textBox2, "");

            // Se genera la instancia para la clase usuario
            usuario miUsuario = new usuario();
            // Se envia la informacion de los cuadros a las propiedades de la clase usuario
            miUsuario.nombre = textBox1.Text;
            miUsuario.edad = Convert.ToInt32(textBox2.Text);

            // Agregar la informacion al ArrayList
            datosUsuarios.Add(miUsuario);

            // Agregar la informacion al dataGrid
            Datos.DataSource = null;
            Datos.DataSource = datosUsuarios;
            limpiar();
        }
        private void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardarArchivo();
        }
        // Crear un metodo para guardar la informacion en un archivo de texto
        public void guardarArchivo()
        {
            // Se genera una instancia a la clase usuario
            usuario miUsuario = new usuario();
            TextWriter escribir = new StreamWriter("Datos.txt");
            escribir.Close();
            foreach (usuario usuario in datosUsuarios)
            {
                StreamWriter agregar = File.AppendText("Datos.txt");
                agregar.WriteLine(usuario.nombre + "_" + usuario.edad);
                agregar.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        // Metodo para leer un archivo de texto 
        public void cargarArchivo()
        {
            try
            {
                StreamReader Leer = new StreamReader("Datos.txt");
                String aux;
                String linea;
                String nombre;
                int edad;
                int pos;
                // Se usa un ciclo para la lectura de los datos del usuario
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                while ((linea = Leer.ReadLine()) != null)
                {
                    // Se extrae el nombre
                    pos = linea.IndexOf('_');
                    aux = linea.Substring(0, pos);
                    nombre = aux;
                    linea = linea.Substring(pos + 1);
                    // Se extrae la edad
                    edad = Convert.ToInt32(linea);
                    // Se genera una instancia a la clase usuario
                    usuario miUsuario = new usuario();
                    miUsuario.nombre = nombre;
                    miUsuario.edad = edad;
                    // Se llena el arreglo de tipo ArrayList
                    datosUsuarios.Add(miUsuario);
                    Datos.DataSource = null;
                    Datos.DataSource = datosUsuarios;
                }
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
                Leer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}