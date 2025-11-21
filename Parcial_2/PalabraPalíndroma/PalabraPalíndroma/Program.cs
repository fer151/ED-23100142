using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraPalindroma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una palabra o frase (o 'salir' para terminar):");

            while (true)
            {
                Console.Write("> ");
                string entrada = Console.ReadLine();
                if (entrada == null) entrada = string.Empty;

                if (entrada.Trim().Equals("salir", StringComparison.OrdinalIgnoreCase))
                    break;

                bool esPal = EsPalindromoConPila(entrada);

                Console.WriteLine(esPal
                    ? "\"" + entrada + "\" es palíndromo"
                    : "\"" + entrada + "\" no es palíndromo");
            }

            Console.WriteLine("Fin. Presiona Enter para cerrar...");
            Console.ReadLine();
        }

        static bool EsPalindromoConPila(string strCadena)
        {
            ClasePilaDinamica<char> pila = new ClasePilaDinamica<char>();

            for (int i = 0; i < strCadena.Length; i++)
            {
                char c = strCadena[i];
                pila.Push(c);
            }

            string cadenaInv = string.Empty;
            while (!pila.Vacia())
            {
                char c = pila.Pop();
                cadenaInv += c;
            }

            return strCadena == cadenaInv;
        }
    }

    
    public class ClaseNodo<Tipo>
    {
        public Tipo ObjetoConDatos { get; set; }
        public ClaseNodo<Tipo> Siguiente { get; set; }

        public ClaseNodo(Tipo datos)
        {
            ObjetoConDatos = datos;
            Siguiente = null;
        }
    }

    public class ClasePilaDinamica<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _Top;

        public ClasePilaDinamica()
        {
            _Top = null;
        }

        public bool Vacia()
        {
            return _Top == null;
        }

        public void Push(Tipo objeto)
        {
            ClaseNodo<Tipo> nuevoNodo = new ClaseNodo<Tipo>(objeto);
            nuevoNodo.Siguiente = _Top;
            _Top = nuevoNodo;
        }

        public Tipo Pop()
        {
            if (Vacia())
                throw new InvalidOperationException("La pila está vacía.");

            Tipo valor = _Top.ObjetoConDatos;
            _Top = _Top.Siguiente;
            return valor;
        }

        public void Vaciar()
        {
            _Top = null;
        }
    }
}
