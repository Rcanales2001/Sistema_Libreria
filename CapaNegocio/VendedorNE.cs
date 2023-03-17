using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ModeloDatos;

namespace CapaNegocio
{
    public class VendedorNE
    {
        public CRUD_Vendedor objVenDAO = new CRUD_Vendedor();

        public Vendedor buscarVendedorById(int idVendedor)
        {
            return objVenDAO.buscarVendodorById(idVendedor);
        }
    }
}
