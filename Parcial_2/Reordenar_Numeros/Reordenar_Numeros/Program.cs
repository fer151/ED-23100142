using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reordenar_Numeros
{
    internal class Program
    {
        const int MAX = 100;
        static int[] Pila = new int[MAX];
        static int TopP = -1;

        static int[] Fila = new int[MAX];
        static int TopF = -1;
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos elementos quieres? ");
            int numDatos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numDatos; i++)
            {
                Console.WriteLine("Dato: " + i);
                int dato = int.Parse(Console.ReadLine());
                InsertarFila(dato);
            }
            Console.WriteLine("\nFila original: ");
            MostrarFila();


            for (int j = 0; j < numDatos; j++)
            {
                int valor = EliminarFila();
                InsertarPila(valor);

            }
            for (int k = 0; k < numDatos; k++)
            {
                int valor = EliminarPila();
                InsertarFila(valor);
            }
            Console.WriteLine("\nFila reordenada: ");
            MostrarFila();

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();

        }
        static bool InsertarPila(int n)
        {
            if (TopP == MAX - 1) return false; // pila llena
            TopP++;
            Pila[TopP] = n;
            return true;
        }

        static int EliminarPila()
        {
            if (TopP == -1) return -99;
            int n = Pila[TopP];
            TopP--;
            return n;
        }
        static bool InsertarFila(int n)
        {
            if (TopF == MAX - 1) return false; // fila llena
            TopF++;
            Fila[TopF] = n;
            return true;
        }
        static int EliminarFila()
        {
            if (TopF == -1) return -99; // fila vacía
            int n = Fila[0];
            for (int x = 0; x < TopF; x++)
            {
                Fila[x] = Fila[x + 1]; // recorrer
            }
            TopF--;
            return n;
        }
        static void MostrarFila()
        {
            Console.Write("[ ");
            for (int i = 0; i <= TopF; i++)
            {
                Console.Write(Fila[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}

