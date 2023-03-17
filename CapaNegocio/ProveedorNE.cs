using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatos;

namespace CapaNegocio
{
    public class ProveedorNE
    {
        CRUD_Proveedor objProv = new CRUD_Proveedor();

        public String insertarProductos(Proveedor pro)
        {

            return objProv.insertarProveedor(pro);
        }

        public List<Proveedor> listarProveedores()
        {

            return objProv.listarProveedor();
        }

        public Proveedor listarProveedor(int codigo)
        {
            return objProv.buscarProveedorByCodigo(codigo);
        }

        public String actualizarProveedor(Proveedor p)
        {
            return objProv.actualizarProveedor(p);
        }

        public String eliminarProveedor(int id)
        {
            return objProv.eliminarProveedor(id);
        }

        public int GenerarCodigoProveedor()
        {
            return objProv.GenerarCodigoProveedor();
        }

        public List<Proveedor> listarProveedoresByNombre(string nombre)
        {
            return objProv.listarProveedoresByNombre(nombre);
        }
    }
}
