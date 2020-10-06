using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KwikEMart
{
    public static class Inventario
    {
        #region Atributos
        static List<Producto> listaProductos;
        static List<Persona> listaPersona;
        static List<Venta> listaVentas;

        #endregion

        #region Propiedades
        public static List<Producto> ListaProductos 
        {
            get 
            { 
                return listaProductos;
            } 
        }

        public static List<Persona> ListaPersona 
        {
            get 
            {
                return listaPersona;
            }
        }

        public static List<Venta> ListaVenta 
        {
            get { return listaVentas; }
        }
        #endregion

        #region Constructores
        static Inventario()
        {
            listaProductos = new List<Producto>();
            listaPersona = new List<Persona>();
            listaVentas = new List<Venta>();
        }

        #endregion

        #region Metodos
        public static void HarcodeoProductos() 
        {
            listaProductos.Add(new ProductoNoPerecedero("Gelatina",200,1,1,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Frutillas",299,2,123456, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Tomate",1000,3,2, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Helado",200,64,4, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Hamburguesa",200,5,4,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Pizza",200,6,5,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Maruchan",220,7,6,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Panchos",230,8,7,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Mermelada",240,9,8,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Levadura",250,10,9, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Cereales",260,12,10,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Te",3129,13,11,Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoNoPerecedero("Dog chow",22330,14,12, Producto.ETipo.No_perecedero));
            listaProductos.Add(new ProductoPerecedero("Fideos spaguetti",200,64,20, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Sopa instantanea",200,64,21, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Dulce de leche",200,64,22, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Arroz",200,64,23, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Papa",200,64,24, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Vinagre",200,64,25, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Aceite",200,64,26, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Ravioles",23,5,27, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Noquis",2222,64,28, Producto.ETipo.Perecedero));
            listaProductos.Add(new ProductoPerecedero("Salsa Tomate",22300,64,29, Producto.ETipo.Perecedero));
        }

        public static void HarcodeoClientes()
        {
            listaPersona.Add(new Cliente("Bart", "Simpson", 424173321));
            listaPersona.Add(new Cliente("Homero", "Simpson", 23232323));
            listaPersona.Add(new Cliente("Marge", "Simpson", 2323558788));
            listaPersona.Add(new Cliente("Ned", "Flanders", 9999999999));
            listaPersona.Add(new Cliente("Milhouse", "Van Houten", 40888222));
        }

        public static void HarcodeoEmpleados() 
        {
            listaPersona.Add(new Empleado(1,"Lucas123","Lucas","Rodriguez"));
            listaPersona.Add(new Empleado(2, "Eze321", "Ezequiel", "Oggioni"));
            listaPersona.Add(new Empleado(3, "Carlitos1", "Carlos", "Gutierrez"));
            listaPersona.Add(new Empleado(4, "Agusss", "Agustin", "Fernandez"));
        }

        public static List<Venta> VentasEmpleados(int idEmpleado) 
        {
            List<Venta> auxLista = new List<Venta>();

            foreach (Venta item in listaVentas)
            {
                if (item.VendedorId == idEmpleado)
                {
                    auxLista.Add(item);
                }
            }
            return auxLista;
        }

        public static List<Cliente> ObtenerClientes() 
        {
            List<Cliente> auxLista = new List<Cliente>();

            foreach (Persona item in listaPersona)
            {
                if (item is Cliente)
                {
                    auxLista.Add((Cliente)item);
                }
            }
            return auxLista;
        }

        public static List<Empleado> ObtenerEmpleados() 
        {
            List<Empleado> auxLista = new List<Empleado>();

            foreach (Persona item in listaPersona)
            {
                if (item is Empleado) 
                {
                    auxLista.Add((Empleado)item);
                }
            }
            return auxLista;
        }

        public static int StockTodo() 
        {
            int contador = 0;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                contador += listaProductos[i].Stock;
            }
            return contador;
        }

        public static List<Producto> StockDiezUnidades()
        {
            List<Producto> listaAux = new List<Producto>();
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Stock < 10)
                {
                    listaAux.Add(listaProductos[i]);
                }
            }
            return listaAux;
        }

        public static bool ValidarStock(string nombre, int stock) 
        {
            bool retorno = false;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                if (listaProductos[i].Nombre == nombre && listaProductos[i].Stock >= stock)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool FamiliaSimpson(Cliente cliente) 
        {
            if (cliente.Apellido == "Simpson")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
