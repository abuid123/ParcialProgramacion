using KwikEMart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        #region Atributos
        private Dictionary<string, string> usuarioContraseña;
        #endregion

        #region Propiedades
        public Dictionary<string, string> UsuarioContraseña {set => usuarioContraseña = value; }
        #endregion

        #region Constructores
        public Login()
        {
            InitializeComponent();
            UsuarioContraseña = new Dictionary<string, string>();
        }
        #endregion

        #region Metodos
        private void Form1_Load(object sender, EventArgs e)
        {
            usuarioContraseña.Add("Agustin","123456");
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            string usuario = txt_Nombre.Text;
            bool banderita = false;
            string nombre;
            foreach (KeyValuePair<string,string> item in usuarioContraseña)
            {
                if (item.Key == txt_Nombre.Text && item.Value == txt_Contraseña.Text) 
                {
                    nombre = txt_Nombre.Text;
                    this.Hide();
                    Mercado merc = new Mercado(usuario);
                    merc.Show();
                    banderita = true;
                }
            }
            if (banderita == false) 
            {
                MessageBox.Show("Escribiste mal el usuario o la contraseña");
            }
        }

        private void linkLbl_Registrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingIn singIn = new SingIn();
            singIn.UsuariosContraseñas = usuarioContraseña;
            singIn.ShowDialog();
        }
        #endregion

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
