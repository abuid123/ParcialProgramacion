using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public class ProductoPerecedero : Producto
    {
        public ProductoPerecedero(string nombre, int idProducto, double precio, int stock, ETipo tipoProducto) : base(nombre,precio,idProducto,stock,tipoProducto)
        {

        }

        public override string Descripcion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Producto perecedero");
            sb.AppendLine("");
            sb.AppendLine(base.Descripcion());
            sb.AppendLine("");

            return sb.ToString();
        }
    }
}
