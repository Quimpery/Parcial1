using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal abstract class Producto
    {
        protected double precioBase;
        protected double largo;
        private int codigo;
        public int Codigo { get { return codigo; } }

        public Producto(double precio,double largo)
        {
            precioBase = precio;
            this.largo = largo;

        }
        public abstract double Peso();
        public abstract double Precio();
    }
}
