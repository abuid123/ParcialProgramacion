using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public abstract class Persona
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        #endregion

        #region Constructores
        public Persona() 
        {
            this.nombre = "Sin nombre";
            this.apellido = "Sin apellido";
        }

        public Persona(string nombre, string apellido) : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get 
            {
                return nombre;
            }
            set 
            {
                if (value.Length > 3)
                {
                    this.nombre = value;
                }
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                if (value.Length > 3)
                {
                    this.apellido = value;
                }
            }
        }
        #endregion
    }
}
