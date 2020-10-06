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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid() 
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = Inventario.ListaProductos;
        }

        private void CargarMenorADiez() 
        {
            List<Producto> listaAux = new List<Producto>();

            listaAux = Inventario.StockDiezUnidades();

            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = listaAux;
        }

        private void btn_Todos_Click(object sender, EventArgs e)
        {
            CargarDataGrid();
            int cantidad = Inventario.StockTodo();
            MessageBox.Show("Se han cargado todos los productos y hay un total de " + cantidad + " productos en stock");
        }

        private void btn_DiezUnidades_Click(object sender, EventArgs e)
        {
            CargarMenorADiez();
            MessageBox.Show("Se han cargado los productos con menos de 10 unidades en stock!");
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
