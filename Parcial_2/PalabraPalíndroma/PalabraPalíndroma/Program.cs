using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalabraPalíndroma
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
            // PILA
            Stack<char> pila = new Stack<char>();

            // for (i = 0; i < len(strCadena); i++) { c = strCadena[i]; push(c); }
            for (int i = 0; i < strCadena.Length; i++)
            {
                char c = strCadena[i];
                pila.Push(c);
            }

            // Mientras pila.tamanio > 0: c = Pop(); CadenaInv = CadenaInv + c
            string cadenaInv = string.Empty;
            while (pila.Count > 0)
            {
                char c = pila.Pop();
                cadenaInv += c;
            }

            // strCadena == cadenaInv ? es palíndromo : no es palíndromo
            return strCadena == cadenaInv;
        }
    }
}
