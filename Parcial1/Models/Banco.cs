using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Banco:Producto
    {
        public Banco(double precio,double largo) : base(precio, largo)
        {
            base.precioBase = precio;
            base.largo=largo;
        }

        public override double Peso()
        {
            double peso;
            peso = (largo * 0.25) * 0.42;
            return peso;
        }
        public override double Precio()
        {
            double precio;
            precio = Peso() * precioBase * 1.15;
            return precio;
        }

    }
}
