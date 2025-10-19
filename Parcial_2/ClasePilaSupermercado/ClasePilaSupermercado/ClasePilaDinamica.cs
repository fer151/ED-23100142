using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaSupermercado
{
    internal class ClasePilaDinamica<Tipo> : IEnumerable<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _Top;

        public ClasePilaDinamica()
        {
            _Top = null;
        }

        public ClaseNodo<Tipo> Top
        {
            get => _Top;
            set => _Top = value;
        }

        public bool Vacia => _Top == null;

        public void Push(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>(objeto)
            {
                Siguiente = _Top
            };
            _Top = nuevoNodo;
        }

        public Tipo Pop()
        {
            if (Vacia)
                throw new InvalidOperationException("La pila está vacía.");

            Tipo dato = _Top.ObjetoConDatos;
            _Top = _Top.Siguiente;
            return dato;
        }

        public Tipo Pop(Tipo objeto)
        {
            if (Vacia)
                throw new InvalidOperationException("La pila está vacía.");

            if (_Top.ObjetoConDatos.Equals(objeto))
            {
                return Pop();
            }

            ClaseNodo<Tipo> anterior = _Top;
            ClaseNodo<Tipo> actual = _Top.Siguiente;

            while (actual != null)
            {
                if (actual.ObjetoConDatos.Equals(objeto))
                {
                    anterior.Siguiente = actual.Siguiente;
                    return actual.ObjetoConDatos;
                }

                anterior = actual;
                actual = actual.Siguiente;
            }

            throw new InvalidOperationException("Elemento no encontrado en la pila.");
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> actual = _Top;

            while (actual != null)
            {
                if (actual.ObjetoConDatos.Equals(objeto))
                {
                    return actual.ObjetoConDatos;
                }

                actual = actual.Siguiente;
            }

            throw new InvalidOperationException("Elemento no encontrado.");
        }

        public void Vaciar()
        {
            _Top = null;
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> actual = _Top;
            while (actual != null)
            {
                yield return actual.ObjetoConDatos;
                actual = actual.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
