using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class Compra
    {
        #region Atributos
        string nombre;
        double precio;
        #endregion

        #region Constructores
        public Compra() 
        {
            this.nombre = "Sin descripcion";
            this.precio = -1;
        }

        public Compra(string descripcion, double precio) : this() 
        {
            this.precio = precio;
            this.nombre = descripcion;
        }
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            }
        }

        public double Precio 
        {
            get 
            {
                return this.precio;
            }
        }
        #endregion

        public static bool operator ==(List<Compra> listaCompra, Compra compra)
        {
            bool retorno = false;
            for (int i = 0; i < listaCompra.Count; i++)
            {
                if (listaCompra[i].nombre == compra.nombre)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(List<Compra> listaCompra, Compra compra)
        {

            return !(listaCompra == compra);
        }

        public static bool operator +(List<Compra> listaCompra, Compra compra)
        {
            bool retorno = false;
            if (listaCompra != compra)
            {
                listaCompra.Add(compra);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator -(List<Compra> listaCompra, Compra compra)
        {
            bool retorno = false;
            if ((listaCompra == compra) == true)
            {
                listaCompra.Remove(compra);
                retorno = true;
            }
            return retorno;
        }
    }
}
