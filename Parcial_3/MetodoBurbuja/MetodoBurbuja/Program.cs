using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoBurbuja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.Write("¿Cuántos elementos tendrá el arreglo?: ");
            n = int.Parse(Console.ReadLine());

            int[] arreglo = new int[n];

            // Pedir los valores del arreglo
            for (i = 0; i < n; i++)
            {
                Console.Write($"Elemento [{i}]: ");
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            // Llamada al método Burbuja
            Burbuja(arreglo);

            // Mostrar arreglo ordenado
            Console.WriteLine("\nArreglo ordenado:");
            for (i = 0; i < n; i++)
            {
                Console.Write(arreglo[i] + " ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
        static void Burbuja(int[] Arreglo)
        {
            int i, j, Temporal;

            for (i = 0; i < Arreglo.Length - 1; i++)
            {
                for (j = 0; j < Arreglo.Length - 1 - i; j++)
                {
                    if (Arreglo[j] > Arreglo[j + 1])
                    {
                        Temporal = Arreglo[j];
                        Arreglo[j] = Arreglo[j + 1];
                        Arreglo[j + 1] = Temporal;
                    }
                }
            }
        }
    }
}
