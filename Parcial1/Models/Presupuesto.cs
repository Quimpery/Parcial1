using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Models
{
    internal class Presupuesto
    {
        public double Precio {  get; set; }
        private Cliente solicitante;
        private ArrayList listaProductos;

        public Presupuesto(string nombre, string dirrecion)
        {
            solicitante=new Cliente(nombre,dirrecion);
            listaProductos=new ArrayList();
        }

        public void AgregarProducto(Producto unProducto)
        {
            listaProductos.Add(unProducto);
        }

        public bool QuitarProducto(int codigo)
        {
            bool removido = false;
            Producto p=BuscarProducto(codigo);
            if (p != null)
            {
                listaProductos.Remove(p);
                removido = true;
            }
            return removido;
        }

        private Producto BuscarProducto(int codigo)
        {
            Producto buscado=null;

            foreach(Producto p in listaProductos)
            {
                if(p.Codigo== codigo) 
                    buscado = p;
            }
            return buscado;
        }

        public string[] Resumen()
        {
            int contadorResumen = 0;
            string[]resumen=new string[listaProductos.Count];
            foreach(Producto p in listaProductos)
            {
                resumen[contadorResumen] ="Codigo: " + p.Codigo.ToString() + "Tipo: " + p.GetType() + "Precio: " +p.Precio().ToString();
                contadorResumen++;
            }
            return resumen;
        }
    }
}
