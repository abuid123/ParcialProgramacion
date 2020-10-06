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
    public partial class SingIn : Form
    {
        Dictionary<string, string> usuariosContraseñas;
        public SingIn()
        {
            InitializeComponent();
            UsuariosContraseñas = new Dictionary<string, string>();
        }

        public Dictionary<string, string> UsuariosContraseñas {set => usuariosContraseñas = value; }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            if (usuariosContraseñas.ContainsKey(txt_Nombre.Text))
            {
                MessageBox.Show("Ya tenemos registrado a un usuario con ese nombre");
            }
            else
            {
                if (txt_Contraseña.Text == txt_ConfirmContraseña.Text)
                {
                    usuariosContraseñas.Add(txt_Nombre.Text, txt_Contraseña.Text);
                    MessageBox.Show("Usuario registrado con exito!");
                    log.UsuarioContraseña = usuariosContraseñas;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir!");
                }
            }
        }
    }
}
