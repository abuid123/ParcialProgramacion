using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class Empleado : Persona
    {
        #region Atributos

        int idEmpleado;
        string nombreUsuario;

        #endregion

        #region Constructores

        public Empleado() :base()
        {

        }
        public Empleado(int id, string usuario, string nombre, string apellido) : base(nombre, apellido) 
        {
            this.idEmpleado = id;
            this.nombreUsuario = nombre;
        }

        #endregion

        #region Propiedades
        public string NombreUsuario 
        {
            get 
            {
                return this.nombreUsuario;
            }
        }
        
        public int IdEmpleado 
        {
            get
            {
                return this.idEmpleado;
            }
        }
        #endregion
    }
}
