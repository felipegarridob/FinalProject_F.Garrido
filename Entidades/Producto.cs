using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private int numeroSerie;
        private string descripcion;
        private int valorCompra;
        private int valorVenta;
        private int cantidadStock;
        private int stockMinimo;
        private int id_tipoProducto;
        private int id_proveedor;
        private string descProv;
        private Proveedor proveedor;
        private TipoProducto tipoProducto;

        public Producto()
        { }

        public Producto(int numeroSerie,string descripcion, int valorCompra, int valorVenta, int cantidadStock, int stockMinimo, int id_tipoProducto, int id_proveedor)
        {
            this.numeroSerie = numeroSerie;
            this.descripcion = descripcion;
            this.valorCompra = valorCompra;
            this.valorVenta = valorVenta;
            this.cantidadStock = cantidadStock;
            this.stockMinimo = stockMinimo;
            this.id_tipoProducto = id_tipoProducto;
            this.id_proveedor = id_proveedor;
           
        }



        public Producto(string descripcion, int valorCompra, int valorVenta, int cantidadStock, int stockMinimo, int id_tipoProducto, int id_proveedor)
        {

            this.descripcion = descripcion;
            this.valorCompra = valorCompra;
            this.valorVenta = valorVenta;
            this.cantidadStock = cantidadStock;
            this.stockMinimo = stockMinimo;
            this.id_tipoProducto = id_tipoProducto;
            this.id_proveedor = id_proveedor;
        } 

        public Producto(Proveedor proveedorn)
        {
            this.proveedor = proveedor;
           
        }

       public Producto(string descProv, string descripcion)
        {
            this.descripcion = descripcion;
            this.descProv = descProv;
        }

        public Producto(TipoProducto tipoProducto)
        {
            this.tipoProducto = tipoProducto;
        }
        
        public int NumeroSerie      { get { return numeroSerie;     }   set { numeroSerie =     value; } }
        public string Descripcion   { get { return descripcion;     }   set { descripcion =     value; } }
        public int ValorCompra      { get { return valorCompra;     }   set { valorCompra =     value; } }
        public int ValorVenta       { get { return valorVenta;      }   set { valorVenta =      value; } }
        public int CantidadStock    { get { return cantidadStock;   }   set { cantidadStock =   value; } }
        public int StockMinimo      { get { return stockMinimo;     }   set { stockMinimo =     value; } }
        public int Id_tipoProducto  { get { return id_tipoProducto; }   set { id_tipoProducto = value; } }
        public int Id_proveedor     { get { return id_proveedor;    }   set { id_proveedor =    value; } }
        public Proveedor Proveedor          { get { return proveedor;       }   set { proveedor =       value; } }
        public TipoProducto TipoProducto    { get { return tipoProducto;    }   set { tipoProducto =    value; } }
    }
}
