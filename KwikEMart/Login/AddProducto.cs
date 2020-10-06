using KwikEMart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class AddProducto : Form
    {
        public AddProducto()
        {
            InitializeComponent();
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = Char.ToUpper(((TextBox)sender).Text[0]) + ((TextBox)sender).Text.Substring(1);

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(
                        ((TextBox)sender).Text.Substring(0, posicion + 1),
                        Char.ToUpper(((TextBox)sender).Text[posicion + 1]),
                        ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Nombre.Text.Length < 3 )
            {
                MessageBox.Show("El nombre es demasiado corto");
            }
            else if (num_Cantidad.Value < 0)
            {
                MessageBox.Show("Ingrese una cantidad mayor a 0");
            }
            else if (num_Precio.Value < 0)
            {
                MessageBox.Show("Ingrese un precio mayor a 0");
            }
            else if (int.Parse(txt_Id.Text) < 0)
            {
                MessageBox.Show("Ingrese un id mayor a 0");
            }
            else
            {


                //Producto nuevoProducto = new Producto(txt_Nombre.Text, (double)num_Precio.Value, int.Parse(txt_Id.Text), (int)num_Cantidad.Value);

                //if (Inventario.ListaProductos != nuevoProducto)
                //{
                //    Inventario.ListaProductos.Add(nuevoProducto);
                //    MessageBox.Show("Producto cargado con exito");
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Ya existe un producto con ese ID");
                //}
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {
            this.comb_Tipo.DataSource = Enum.GetValues(typeof(Producto.ETipo));
        }
    }
}
