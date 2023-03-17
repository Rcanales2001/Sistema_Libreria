using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;

namespace ModeloDatos
{
    public class CRUD_Detalle
    {
        PedidosDataContext db = new PedidosDataContext();

        public String insertarDetalles(List<Detalle> detalle)
        {
            string rpta = "";
            try
            {

                foreach (Detalle det in detalle)
                {
                    db.Sp_GrabarDetalle_Venta(det.num_fact,
                                              det.IdProducto,
                                              det.CantidadVenta,
                                              det.PrecioVenta,
                                              det.Importe);
                }
                rpta = "Detalle Guardado Correctamente";
            }
            catch (Exception ex)
            {

                rpta = ex.Message;
                System.Console.Write(ex.ToString());
            }

            return rpta;


        }

        public List<Detalle> reportarDetalle(int fac)
        {
            List<Detalle> lista = new List<Detalle>();


            try
            {
                var consulta = db.Sp_MostrarDetalle(fac);
                foreach (var det in consulta)
                {
                    Detalle deta = new Detalle();
                    Producto p = new Producto();
                    p.IdProducto = det.IdProducto;

                    p.NombreProducto = det.Descripcion;
                    deta.Producto = p;
                    //deta.IdProducto = det.IdProducto;
                    deta.PrecioVenta = det.Precio_Venta;

                    deta.CantidadVenta = det.Cantidad;
                    deta.Importe = det.Importe;

                    //p.NombreProducto = det.Descripcion;
                    //deta.Producto = p;

                    lista.Add(deta);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);

            }
            return lista;
        }
    }
}

