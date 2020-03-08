using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Proveedor
    {
        private int id_Proveedor;
        private string descripcion;

       
        private List<Producto> listaProductos = new List<Producto>();

        public Proveedor(string descricpcion)
        {
            this.descripcion = descricpcion;
        }
        public Proveedor()
        { }

        

        public Proveedor(int id_Proveedor, string descripcion)
        {
            this.id_Proveedor = id_Proveedor;
            this.descripcion = descripcion;
         
        }

        public Proveedor(List<Producto>listaProductos)
        {
            this.listaProductos = listaProductos;
        }

        public int Id_Proveedor     { get { return id_Proveedor;    } set { id_Proveedor =  value; } }
        public string Descripcion   { get { return descripcion;     } set { descripcion =   value; } }
        

        public List<Producto> ListaProductos { get { return listaProductos; } set { listaProductos = value; } }
    }
}
