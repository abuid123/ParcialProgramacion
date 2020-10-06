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
using System.Media;

namespace Login
{
    public partial class CompraClienteExistente : Form
    {
        List<Compra> listaCompra;
        List<Cliente> listAux;
        Cliente auxCliente;
        double precioTotal;
        string nombre;
        string apellido;
        double dni;
        string empleadoAuxiliar;

        public CompraClienteExistente()
        {
            InitializeComponent();
            listaCompra = new List<Compra>();
            listAux = new List<Cliente>();
            auxCliente = new Cliente();
        }

        public CompraClienteExistente(string empleado) 
        {
            InitializeComponent();
            listaCompra = new List<Compra>();
            listAux = new List<Cliente>();
            auxCliente = new Cliente();
            empleadoAuxiliar = empleado;
        }

        private void CargarDataGrid()
        {
            dgv_Mercado.DataSource = null;
            dgv_Mercado.DataSource = Inventario.ListaProductos;
            if (listaCompra.Count > 0)
            {
                dgv_Carrito.DataSource = null;
                dgv_Carrito.DataSource = listaCompra;
            }
            
        }

        private void CargarDataGridClientes()
        {
            listAux = Inventario.ObtenerClientes();

            dgv_Cliente.DataSource = null;
            dgv_Cliente.DataSource = listAux;
        }

        private void CompraClienteExistente_Load(object sender, EventArgs e)
        {
            CargarDataGrid();
            CargarDataGridClientes();
            this.cmb_Empleados.DataSource = Inventario.ObtenerEmpleados();
            this.cmb_Empleados.DisplayMember = "Nombre";
            this.cmb_Empleados.ValueMember = "Nombre";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string nombre;
            double precio;
            int cantidad;
            if (int.TryParse(txt_Cantidad.Text, out cantidad))
            {
                nombre = dgv_Mercado.CurrentRow.Cells["Nombre"].Value.ToString();
                precio = (double)dgv_Mercado.CurrentRow.Cells["Precio"].Value;

                if (cantidad > 0)
                {
                    if (Inventario.ValidarStock(nombre,cantidad))
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            listaCompra.Add(new Compra(nombre, precio));
                        }

                        for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                        {
                            if (nombre == Inventario.ListaProductos[i].Nombre)
                            {
                                Inventario.ListaProductos[i].Stock -= cantidad;
                            }
                        }
                        precioTotal += (precio * cantidad);
                        CargarDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("No tenemos tanto stock de "+ nombre + " como usted eligio");
                    }
                }
            }
            else
            {
                MessageBox.Show("Primero debe agregar una cantidad a comprar");
            }
        }
        private void dataGridView2_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            string nombre;
            double precio;
            Compra auxCompra = new Compra();

            if (listaCompra.Count > 0)
            {
                nombre = dgv_Mercado.CurrentRow.Cells["Nombre"].Value.ToString();
                precio = (double)dgv_Mercado.CurrentRow.Cells["Precio"].Value;

                for (int i = 0; i < listaCompra.Count; i++)
                {
                    if (listaCompra[i].Nombre == nombre)
                    {
                        //listaCompra.Remove(listaCompra[i]);
                        auxCompra = listaCompra[i];
                        break;
                    }
                }

                if (listaCompra - auxCompra)
                {
                    dgv_Carrito.DataSource = null;
                    dgv_Carrito.DataSource = listaCompra;
                }

                for (int i = 0; i < Inventario.ListaProductos.Count; i++)
                {
                    if (Inventario.ListaProductos[i].Nombre == nombre)
                    {
                        Inventario.ListaProductos[i].Stock += 1;
                    }
                }
                precioTotal -= precio;
                CargarDataGrid();
            }
            else
            {
                MessageBox.Show("Primero debe agregar un producto a el carrito");
            }
        }

        private void dataGridView3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             nombre = dgv_Cliente.CurrentRow.Cells["Nombre"].Value.ToString();
             apellido = dgv_Cliente.CurrentRow.Cells["Apellido"].Value.ToString();
             dni = (double)dgv_Cliente.CurrentRow.Cells["Dni"].Value;

            auxCliente.Apellido = apellido;
            auxCliente.Nombre = nombre;
            auxCliente.Dni = dni;


            if (Inventario.FamiliaSimpson(auxCliente))
            {
                MessageBox.Show("Por ser miembros de la familia Simpson tiene un descuentos del 13%");
            }
            else
            {
                MessageBox.Show("Cliente seleccionado!");
            }
        }

        private void btn_Compra_Click(object sender, EventArgs e)
        {
            double precioFinal = precioTotal;
            List<Empleado> auxLista = new List<Empleado>(); 
            Empleado auxEmpleado = new Empleado();
            SoundPlayer sp = new SoundPlayer("caja.wav");

            auxLista = Inventario.ObtenerEmpleados();
            if (dgv_Carrito.DataSource != null)
            {
                for (int i = 0; i < auxLista.Count; i++)
                {
                    if (auxLista[i].Nombre == cmb_Empleados.SelectedValue.ToString())
                    {
                        auxEmpleado = auxLista[i];
                        break;
                    }
                }

                if (Inventario.FamiliaSimpson(auxCliente))
                {
                    precioFinal = precioTotal * 0.13;
                    if (MessageBox.Show("Confirmar compra", "KwikEMark", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        MessageBox.Show($"Precio sin descuento: ${precioTotal}\n Precio con descuento: ${precioTotal - precioFinal}");
                        Inventario.ListaVenta.Add(new Venta(auxEmpleado, auxCliente, listaCompra, precioFinal));
                        sp.Play();
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Usted cancelo la compra! Moriras en el infiernosss");
                    }
                }
                else
                {
                    MessageBox.Show($"Precio Final: ${precioTotal}");
                    Inventario.ListaVenta.Add(new Venta(auxEmpleado, auxCliente, listaCompra, precioTotal));
                    sp.Play();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar algo");
            }
        }
    }
}
