using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura
{
    internal class cola
    {

        nodo _inicio;
        public void Encolar(nodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                nodo aux = BuscarUltimo(_inicio);
                aux.Siguiente = unNodo;
            }
        }

        public nodo BuscarUltimo(nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.Siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.Siguiente;
        }

        public nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }

        public bool Vacia()
        {
            return (_inicio == null);
        }
    }
}
