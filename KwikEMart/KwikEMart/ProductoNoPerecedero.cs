using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class ProductoNoPerecedero : Producto
    {
        public ProductoNoPerecedero(string nombre, double precio, int idProducto, int stock, ETipo tipoProducto) : base(nombre, precio, idProducto, stock, tipoProducto)
        {

        }

        public override string Descripcion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto no perecedero");
            sb.AppendLine("");
            sb.AppendLine(base.Descripcion());
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
