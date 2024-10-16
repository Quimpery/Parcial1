using Parcial1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Presupuesto presupuesto;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto;

            double preciobase=Convert.ToDouble(tbPrecio.Text);
            double largo=Convert.ToDouble(tbLargo.Text);    
            int codigo=Convert.ToInt32(tbCodigo.Text);
            double ancho=Convert.ToDouble(tbAncho.Text);
            double grosor=Convert.ToDouble(tbGrosor.Text);


            if(ancho == 0 && grosor == 0)
            {
                producto = new Banco(preciobase,largo);
                producto.Codigo = codigo;
            }
            else
            {
                producto= new Mesa(preciobase,largo,ancho,grosor);
                producto.Codigo = codigo;
            }
            presupuesto.AgregarProducto(producto);
            cbProducto.Items.Add(codigo);
        }

        private void btnIPresupuesto_Click(object sender, EventArgs e)
        {
            string nombre=tbNombre.Text;
            string dirreccion = tbDireccion.Text;

            presupuesto = new Presupuesto(nombre,dirreccion);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(cbProducto.SelectedIndex != -1)
            {
                int codigoBorrable = Convert.ToInt32(cbProducto.Text);
                presupuesto.QuitarProducto(codigoBorrable);
            }
            else
            {
                MessageBox.Show("Selecione algun codigo");
            }
           
        }

        private void btnCPresupuesto_Click(object sender, EventArgs e)
        {
            FPresupuesto vPresupuesto = new FPresupuesto();
            
            StringBuilder sb = new StringBuilder(); 
            
            foreach (string a in presupuesto.Resumen())
            {
                sb.AppendLine(a);

            }

            vPresupuesto.lbResultados.Items.Add(sb);
            vPresupuesto.Show();
            
        }
    }
}
