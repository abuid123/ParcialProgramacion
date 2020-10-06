using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class Venta
    {
        Empleado vendedor;
        Cliente comprador;
        List<Compra> compras;
        double total;

        public Venta() 
        {
            compras = new List<Compra>();
        }

        public Venta(Empleado vendedor, Cliente comprador, List<Compra> compras, double total) : this() 
        {
            this.vendedor = vendedor;
            this.comprador = comprador;
            this.compras = compras;
            this.total = total;
        }

        public string VendedorNombre
        {
            get
            {
                return vendedor.Nombre;
            }
        }

        public string VendedorApellio
        {
            get
            {
                return vendedor.Apellido;
            }
        }

        public double VendedorId 
        {
            get 
            {
                return vendedor.IdEmpleado;
            }
        }

        public string CompradorNombre
        {
            get 
            {
                return comprador.Nombre;
            }
        }

        public string CompradorApellido
        {
            get
            {
                return comprador.Apellido;
            }
        }

        public double CompradorDni 
        {
            get 
            {
                return comprador.Dni;
            }
        }

        public int CantidadProductos 
        {
            get 
            {
                return compras.Count;
            }
        }

        public double Total 
        {
            get 
            {
                return total;
            }
        }
    }
}
