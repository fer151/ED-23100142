using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaSupermercado
{
    internal class ClaseNodo<Tipo>
    {
        private Tipo _objetoConDatos;
        private ClaseNodo<Tipo> _siguiente;

        public ClaseNodo(Tipo datos)
        {
            _objetoConDatos = datos;
            _siguiente = null;
        }

        public Tipo ObjetoConDatos
        {
            get => _objetoConDatos;
            set => _objetoConDatos = value;
        }

        public ClaseNodo<Tipo> Siguiente
        {
            get => _siguiente;
            set => _siguiente = value;
        }
    }
}
