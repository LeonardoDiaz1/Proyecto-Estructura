using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    internal class usuario
    {
        // Propiedades para el traslado de informacion
        public string? nombre { get; set; }
        public int edad { get; set; }
        // Metodo para concatenar los datos del nombre y edad
        public string cadena(string nombre, int edad)
        {
            return nombre + "_" + edad;
        }
    }
}
