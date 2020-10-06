using System.Collections.Generic;
using System.Configuration;
using System.Net.NetworkInformation;
using System.Text;

namespace KwikEMart
{
    public abstract class Producto
    {
        #region Atributos
        protected string nombre;
        protected double precio;
        protected int stock;
        protected int idProducto;
        protected int vendidos;
        protected ETipo tipoProducto;
        #endregion

        public enum ETipo 
        {
            Perecedero, No_perecedero
        }

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (ValidarNombre(value))
                {
                    this.nombre = value;
                }
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }
            set
            {
                if (value > 0)
                {
                    this.precio = value;
                }
            }
        }

        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        public int IdPruducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                if (value > -1)
                    this.idProducto = value;
            }
        }

        public int Vendidos
        {
            get
            {
                return vendidos;
            }
            set
            {
                if (value > -1)
                {
                    this.vendidos = value;
                }
            }
        }

        #endregion

        #region Constructores
        public Producto()
        {
            this.nombre = "Sin nombre";
            this.precio = -1;
            this.stock = -1;
            this.idProducto = -1;
            this.vendidos = 0;
        }

        public Producto(string nombre, double precio, int stock, int idProducto, int cantidadVendido, ETipo tipoProducto) : this(nombre, precio, idProducto, stock, tipoProducto)
        {
            this.Vendidos = cantidadVendido;
        }

        public Producto(string nombre, double precio, int id, int cantidad, ETipo tipoProducto) : this()
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.IdPruducto = id;
            this.Stock = cantidad;
            this.tipoProducto = tipoProducto;
        }
        #endregion

        #region Metodos
        public static bool ValidarNombre(string nombre)
        {
            int contador = 0;
            bool retorno = false;
            for (int i = 0; i < nombre.Length; i++)
            {
                contador++;
                if (contador > 3)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator ==(List<Producto> listaProducto, Producto producto) 
        {
            bool retorno = false;
            for (int i = 0; i < listaProducto.Count; i++)
            {
                if (listaProducto[i].IdPruducto == producto.IdPruducto)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(List<Producto> listaProducto, Producto producto) 
        {

            return !(listaProducto == producto);
        }

        public static bool operator +(List<Producto> listaProducto, Producto producto) 
        {
            bool retorno = false;
            if (listaProducto != producto)
            {
                listaProducto.Add(producto);
                retorno = true;
            }
            else 
            {
                for (int i = 0; i < listaProducto.Count; i++)
                {
                    if (listaProducto[i].IdPruducto == producto.IdPruducto)
                    {
                        listaProducto[i].Stock = producto.Stock;
                    }
                }
            }
            return retorno;
        }

        public static bool operator -(List<Producto> listaProducto, Producto producto) 
        {
            bool retorno = false;
            if ((listaProducto == producto) == true) 
            {
                listaProducto.Remove(producto);
                retorno = true;
            }
            return retorno;
        }

        public virtual string Descripcion() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Precio: {this.precio.ToString()}");
            sb.AppendLine($"Stock: {this.stock.ToString()}");

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.Descripcion();
        }
        #endregion
    }
}
