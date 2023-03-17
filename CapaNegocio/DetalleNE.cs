using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ModeloDatos;

namespace CapaNegocio
{
    public class DetalleNE
    {
        CRUD_Detalle objdet = new CRUD_Detalle();
        public List<Detalle> mostrarDetalle(int fact)
        {
            return objdet.reportarDetalle(fact);
        }
        public string AgregarDetalles1(List<Detalle> detalle)
        {
            return objdet.insertarDetalles(detalle);
        }

    }
}
