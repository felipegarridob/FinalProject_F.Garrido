using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoProducto
    {
        private int id_TipoProducto;
        private string area;
      
        private List<Producto> listaProductosTipo = new List<Producto>();


        public TipoProducto()
        {
        }
        public TipoProducto(int id_TipoProducto, string area)
        {
            this.id_TipoProducto = id_TipoProducto;
            this.area = area;
           
        }
        public TipoProducto(string area)
        {
            this.area = area;
        }


        public TipoProducto(List<Producto> listaProductosTipo)
        {
            this.listaProductosTipo = listaProductosTipo;
        }

        public int Id_TipoProducto  { get { return id_TipoProducto; } set { id_TipoProducto =   value; } }
        public string Area          { get { return area;            } set { area =              value; } }
        public List<Producto> ListaProductosTipo { get { return listaProductosTipo; } set { listaProductosTipo = value; } }
    }
}
