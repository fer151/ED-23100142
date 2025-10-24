using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cadena (tipo XML):");
            string input = Console.ReadLine();

            string error;
            int errorPos;

            Queue<string> tokens = Tokenize(input, out error, out errorPos);
            if (tokens == null)
            {
                Console.WriteLine($"[Tokenización] Error: {error} (pos {errorPos})");
                return;
            }

            
            bool ok = ValidateTokens(tokens, out error);
            if (ok)
                Console.WriteLine("Resultado: CORRECTO (todas las etiquetas abren/cierran bien)");
            else
                Console.WriteLine($"Resultado: ERROR {error}");
            Console.ReadKey();
        }

        static Queue<string> Tokenize(string s, out string error, out int errorPos)
        {
            error = "";
            errorPos = -1;

            var cola = new Queue<string>();
            if (string.IsNullOrEmpty(s)) return cola;

            int n = s.Length;

            for (int i = 0; i < n; i++)
            {
                if (s[i] != '<') continue; 

                int k = i + 1;
                while (k < n && s[k] != '>') k++;

                if (k == n)
                {
                    error = "Falta '>' de cierre para un token";
                    errorPos = i;
                    return null;
                }

                string token = s.Substring(i, k - i + 1);
                cola.Enqueue(token);

                i = k; 
            }

            return cola;
        }
        static bool ValidateTokens(Queue<string> cola, out string error)
        {
            error = "";
            var pila = new Stack<string>();

            while (cola.Count > 0)
            {
                string t = cola.Dequeue(); // token como "<...>"

                // Sanitizar mínimo
                if (t.Length < 3 || t[0] != '<' || t[t.Length - 1] != '>')
                {
                    error = $"Token inválido: {t}";
                    return false;
                }

                if (t.Length >= 4 && t[1] == '/')
                {
                    string nombre = t.Substring(2, t.Length - 3); 
                    if (pila.Count == 0)
                    {
                        error = $"Cierre sin apertura: </{nombre}>";
                        return false;
                    }

                    string top = pila.Peek();
                    if (!string.Equals(top, nombre, StringComparison.Ordinal))
                    {
                        error = $"Se esperaba </{top}> y llegó </{nombre}>.";
                        return false;
                    }

                    pila.Pop();
                    continue;
                }

                
                string inner = t.Substring(1, t.Length - 2).TrimEnd();
                bool selfClosing = inner.Length > 0 && inner[inner.Length - 1] == '/';
                if (selfClosing)
                {
                    continue;
                }

              
                string nombreApertura = inner;
                int sp = inner.IndexOf(' ');
                if (sp >= 0) nombreApertura = inner.Substring(0, sp);

                if (nombreApertura.Length == 0)
                {
                    error = $"Etiqueta de apertura sin nombre: {t}";
                    return false;
                }

                pila.Push(nombreApertura);
            }

            if (pila.Count > 0)
            {
                error = "Faltan cierres para: " + string.Join(", ", pila.ToArray());
                return false;
            }

            return true;
        }
    }
}
