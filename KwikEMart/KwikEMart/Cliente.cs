using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class Cliente : Persona
    {
        #region Atributo
        double dni;
        #endregion

        #region Constructores
        public Cliente() : base()
        {
            this.dni = -1;
        }
        public Cliente(string nombre, string apellido, double dni) : base(nombre, apellido) 
        {
            this.dni = dni;
        }
        #endregion

        #region Propiedades
        public double Dni 
        {
            get 
            {
                return dni;
            }
            set 
            {
                if (value > 0) 
                {
                    this.dni = value;
                }
            }
        }
        #endregion

        public static bool operator ==(List<Cliente> listaClientes, Cliente cliente) 
        {
            bool retorno = false;
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (listaClientes[i].Dni == cliente.Dni)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(List<Cliente> listaClientes, Cliente cliente) 
        {
            return !(listaClientes == cliente);
        }
    }
}
