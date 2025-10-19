using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCarcteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Cadena:");
            string cadena = Console.ReadLine() ?? string.Empty;

            string detalle;
            bool ok = ValidaCadena(cadena, out detalle);

            Console.WriteLine(ok ? "Cadena válida ✅" : "Cadena inválida ❌");
            Console.WriteLine(detalle);
            Console.ReadLine();
        }
        /// Valida pares de delimitadores: (), [], {}, <> según el flujo del diagrama.
        static bool ValidaCadena(string cadena, out string detalle)
        {
            var pila = new Stack<char>();
            int n = cadena.Length;

            for (int i = 0; i < n; i++) // For (i = 0; i < len(Cadena); i++)
            {
                char v = cadena[i];     // V = Valor(i)

                if (EsApertura(v))      // V = ( [ { <
                {
                    pila.Push(v);        // InsertarPila(V)
                    continue;            // → vuelve al FOR
                }

                if (EsCierre(v))         // V = ) ] } >
                {
                    if (pila.Count == 0) // ¿Vacía?
                    {
                        detalle = $"Error: cierre '{v}' en índice {i} pero la pila está vacía.";
                        return false;    // "Error"
                    }

                    char dentro = pila.Peek(); // Dentro = Vacio(Pila) (cima)
                    if (!Coincide(dentro, v))
                    {
                        // Ramas del diagrama:
                        // V = ')' y Dentro ≠ '('  → "Error", etc.
                        detalle = $"Error: en índice {i} se leyó '{v}', " +
                                  $"pero en la pila había '{dentro}'.";
                        return false;
                    }

                    pila.Pop(); // Par correcto
                }
                // Cualquier otro carácter se ignora para la validación de paréntesis
            }

            if (pila.Count > 0)
            {
                // Quedó algo "Dentro = *" (cima pendiente) → "Error"
                char pendiente = pila.Peek();
                detalle = $"Error: fin de cadena con apertura '{pendiente}' sin cerrar.";
                return false;
            }

            detalle = "Todos los delimitadores están correctamente balanceados.";
            return true;
        }
        static bool EsApertura(char v)
        {
            return v == '(' || v == '[' || v == '{' || v == '<';
        }
        static bool EsCierre(char v)
        {
            return v == ')' || v == ']' || v == '}' || v == '>';
        }
        static bool Coincide(char apertura, char cierre)
        {
            switch (apertura)
            {
                case '(': return cierre == ')';
                case '[': return cierre == ']';
                case '{': return cierre == '}';
                case '<': return cierre == '>';
                default: return false;
            }

        }
        
    }
}
