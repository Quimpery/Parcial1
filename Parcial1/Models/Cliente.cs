using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Cliente
    {
        private string nombre;
        private string dirreccion;

        public Cliente(string nombre, string dirreccion)
        {
            this.nombre= nombre;
            this.dirreccion= dirreccion;

        }

        public string ToStringg()
        {
            return ("Nombre: \n" + nombre + " Dirreccion: " + dirreccion);
        }
    }
}
