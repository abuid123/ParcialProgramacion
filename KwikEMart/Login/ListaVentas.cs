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
    public partial class ListaVentas : Form
    {
        public ListaVentas()
        {
            InitializeComponent();
        }

        private void ListaVentas_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
        }

        private void CargarDataGrid() 
        {
            dgv_Empleados.DataSource = null;
            if (Inventario.ObtenerEmpleados().Count > 0)
            {
                dgv_Empleados.DataSource = Inventario.ObtenerEmpleados();
            }
        }

        private void dgv_Empleados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = (int)dgv_Empleados.CurrentRow.Cells["IdEmpleado"].Value;
            Empleado auxEmpleado = new Empleado();
            for (int i = 0; i < Inventario.ObtenerEmpleados().Count; i++)
            {
                if (Inventario.ObtenerEmpleados()[i].IdEmpleado == id)
                {
                    auxEmpleado = Inventario.ObtenerEmpleados()[i];
                    break;
                }
            }
            dgv_Ventas.DataSource = null;
            dgv_Ventas.DataSource = Inventario.VentasEmpleados(auxEmpleado.IdEmpleado);
        }
    }
}
