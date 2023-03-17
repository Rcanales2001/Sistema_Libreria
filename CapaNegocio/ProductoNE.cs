using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatos;

namespace CapaNegocio
{
    public class ProductoNE
    {

        CRUD_Productos objProd = new CRUD_Productos();


        public String insertarProductos(Producto pro)
        {
            return objProd.insertarProducto(pro);
        }

        public List<Producto> listarProductos()
        {
            return objProd.listarProductos();
        }

        public Producto listarProducto(int codigo)
        {
            return objProd.buscarProductosByCodigo(codigo);
        }

        public List<Producto> listarProductosByNombre(string nombre)
        {
            return objProd.listarProductoByNombre(nombre);
        }

        public String actualizarProductos(Producto p)
        {
            return objProd.actualizarProductos(p);
        }

        public String eliminarProducto(int id)
        {
            return objProd.eliminarProducto(id);
        }

        public int GenerarCodigoProducto()
        {
            return objProd.GenerarCodigoProducto();
        }

    }
}
