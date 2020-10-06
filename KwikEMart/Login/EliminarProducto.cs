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
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
        }

        private void EliminarProducto_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid() 
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Inventario.ListaProductos;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Producto auxProducto = new Producto();
            int id;
            if (MessageBox.Show("Esta seguro que desea eliminar el producto?", "Elimanando", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = (int)dataGridView1.CurrentRow.Cells["IdPruducto"].Value;

                for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                {
                    if (Inventario.ListaProductos[i].IdPruducto == id)
                    {
                        auxProducto = Inventario.ListaProductos[i];
                        break;
                    }
                }

                if (Inventario.ListaProductos - auxProducto)
                {
                    this.dataGridView1.DataSource = null;
                    this.dataGridView1.DataSource = Inventario.ListaProductos;
                    MessageBox.Show("Se elimino con exito!");
                }
                else
                {
                    MessageBox.Show("Error");
                }

                //foreach (Producto item in Inventario.ListaProductos)
                //{
                //    if (item.IdPruducto == id)
                //    {
                //        if (Inventario.ListaProductos - item)
                //        {
                //            MessageBox.Show("Se elimino con exito!");
                //            this.dataGridView1.DataSource = null;
                //            this.dataGridView1.DataSource = Inventario.ListaProductos;
                //            break;
                //        }
                //        else
                //        {
                //            MessageBox.Show("Error");
                //        }
                //    }
                //}
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
