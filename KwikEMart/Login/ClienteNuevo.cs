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
    public partial class ClienteNuevo : Form
    {
        public ClienteNuevo()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (txt_Apellido.Text.Length > 3 && txt_Nombre.Text.Length > 3)
            {
                if (numeric_Dni.Value > 0)
                {
                    Cliente nuevoCliente = new Cliente(txt_Nombre.Text, txt_Apellido.Text, (int)numeric_Dni.Value);

                    if (Inventario.ObtenerClientes() != nuevoCliente)
                    {
                        Inventario.ListaPersona.Add(nuevoCliente);
                        MessageBox.Show("Clientes cargados con exitos!!!");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Ya tenemos cargado a ese cliente");
                    }
                }
                else
                {
                    MessageBox.Show("Encima que no te valido que sea de 8 digitos, al menos pone un valor positivo");
                }
            }
            else
            {
                MessageBox.Show("ERROR!: El nombre o el apellido es demasiado corto");
            }
        }

        private void txt_Nombre_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = String.Concat(Char.ToUpper(((TextBox)sender).Text[0]), ((TextBox)sender).Text.Substring(1));

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(((TextBox)sender).Text.Substring(0, posicion + 1),
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]), ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }
        }

        private void txt_Apellido_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).Text = ((TextBox)sender).Text.Trim();

            ((TextBox)sender).Text = ((TextBox)sender).Text.ToLower();

            if (((TextBox)sender).Text.Length > 1)
            {
                ((TextBox)sender).Text = String.Concat(Char.ToUpper(((TextBox)sender).Text[0]), ((TextBox)sender).Text.Substring(1));

                int posicion = 1;
                while (((TextBox)sender).Text.IndexOf(' ', posicion) > 0)
                {
                    posicion = ((TextBox)sender).Text.IndexOf(' ', posicion);
                    ((TextBox)sender).Text = String.Concat(((TextBox)sender).Text.Substring(0, posicion + 1),
                    Char.ToUpper(((TextBox)sender).Text[posicion + 1]), ((TextBox)sender).Text.Substring(posicion + 2));

                    posicion++;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
