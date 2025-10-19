using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaSupermercado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pila = new ClasePilaDinamica<ProductoSupermercado>();

            var producto1 = new ProductoSupermercado("Leche", 25.5, "Lácteos");
            var producto2 = new ProductoSupermercado("Pan", 15.0, "Panadería");
            var producto3 = new ProductoSupermercado("Atún", 19.9, "Enlatados");

            pila.Push(producto1);
            pila.Push(producto2);
            pila.Push(producto3);

            Console.WriteLine("Productos en pila:");
            foreach (var producto in pila)
            {
                Console.WriteLine(producto);
            }

            Console.WriteLine("\nPop:");
            var eliminado = pila.Pop();
            Console.WriteLine(eliminado);

            Console.WriteLine("\nPila después del pop:");
            foreach (var producto in pila)
            {
                Console.WriteLine(producto);
            }
            Console.ReadLine();
        }
    }
}
