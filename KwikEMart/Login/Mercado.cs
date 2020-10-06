using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KwikEMart;

namespace Login
{
    public partial class Mercado : Form
    {
        #region Constructores
        public Mercado()
        {
            InitializeComponent();
        }

        public Mercado(string usuario) 
        {
            InitializeComponent();
            this.textBox1.Text = usuario;
        }
        #endregion

        #region Metodos
        private void Mercado_Load(object sender, EventArgs e)
        {
            Harcodeo();
            SetTimer();
        }
        

        private void Harcodeo() 
        {
            Inventario.HarcodeoProductos();
            Inventario.HarcodeoClientes();
            Inventario.HarcodeoEmpleados();
        }


        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Close();
            log.Show();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            AddProducto agregarProducto = new AddProducto();
            agregarProducto.ShowDialog();
        }

        private void bbtn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto elim = new EliminarProducto();
            elim.ShowDialog();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Stock formStock = new Stock();
            formStock.ShowDialog();
        }

        private void btn_RealizarCompra_Click(object sender, EventArgs e)
        {
            FormCompra formCompra = new FormCompra(textBox1.Text);
            formCompra.ShowDialog();
        }

        private void btn_CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SetTimer() 
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

            t.Interval = 120000;
            t.Tick += new EventHandler(timer1_Tick);
            t.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login log = new Login();
            MessageBox.Show("Se cerro la sesion por inactividad");
            this.Close();
            log.Show();
        }
        #endregion

        private void btn_Lista_Click(object sender, EventArgs e)
        {
            ListaVentas listaVentas = new ListaVentas();
            listaVentas.Show();
        }
    }
}
