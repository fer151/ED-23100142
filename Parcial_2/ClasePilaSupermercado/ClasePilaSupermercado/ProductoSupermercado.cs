using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePilaSupermercado
{
    internal class ProductoSupermercado : IEquatable<ProductoSupermercado>
    {
        private string _strNombre;
        private double _dblPrecio;
        private string _strCategorias;

        public ProductoSupermercado(string nombre, double precio, string categoria)
        {
            _strNombre = nombre;
            _dblPrecio = precio;
            _strCategorias = categoria;
        }

        public string Nombre
        {
            get => _strNombre;
            set => _strNombre = value;
        }

        public double Precio
        {
            get => _dblPrecio;
            set => _dblPrecio = value;
        }

        public string Categoria
        {
            get => _strCategorias;
            set => _strCategorias = value;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Precio: {Precio:C}, Categoría: {Categoria}";
        }

        public bool Equals(ProductoSupermercado other)
        {
            if (other == null) return false;
            return this.Nombre == other.Nombre &&
                   this.Precio == other.Precio &&
                   this.Categoria == other.Categoria;
        }
    }
}
