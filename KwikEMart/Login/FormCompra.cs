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
    public partial class FormCompra : Form
    {
        public FormCompra()
        {
            InitializeComponent();
        }
        public FormCompra(string usuario) 
        {
            InitializeComponent();
            this.textBox1.Text = usuario;
        }

        private void btn_ClienteExistente_Click(object sender, EventArgs e)
        {
            CompraClienteExistente compraClienteExistente = new CompraClienteExistente(textBox1.Text);
            this.Close();
            if (compraClienteExistente.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Gracias!!  Vuelva prontosss","KwikEMark");
            }
            
        }

        private void btn_ClienteNuevo_Click(object sender, EventArgs e)
        {
            ClienteNuevo formClienteNuevo = new ClienteNuevo();
            if (formClienteNuevo.ShowDialog() == DialogResult.OK)
            {
                CompraClienteExistente compraClienteExistente = new CompraClienteExistente(textBox1.Text);
                this.Close();
                if (compraClienteExistente.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Gracias!!  Vuelva prontosss", "KwikEMark");
                }
            }
        }
    }
}
