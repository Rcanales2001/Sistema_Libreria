using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatos
{
    public class CRUD_Factura
    {

        PedidosDataContext db = new PedidosDataContext();

        public String insertarFactura(Facturas factura)
        {
            String rpta = "";
            try
            {
                db.Sp_GrabarFactura(factura.num_fact,
                                    factura.IdVendedor,
                                    factura.IdCliente,
                                    factura.Sub_total,
                                    factura.Igv,
                                    factura.Total,
                                    factura.Fecha,
                                    true);
                rpta = "Factura Guardada Correctamente";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public List<Facturas> listarPedidosByFechas(DateTime fini, DateTime ffin)
        {
            List<Facturas> lista = new List<Facturas>();

            try
            {
                var consulta = db.SP_Listar_Pedidos_By_Fechas(fini, ffin);
                foreach (var item in consulta)
                {
                    Facturas f = new Facturas();
                    f.num_fact = item.num_fact;

                    Cliente c = new Cliente();
                    c.NombreCliente = item.DatosCliente;
                    c.DireccionCliente = item.DireccionCliente;
                    f.Cliente = c;
                    f.Fecha = item.Fecha;
                    lista.Add(f);

                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }

        public List<Facturas> listarFacturasById(int idpedido)
        {
            List<Facturas> lista = new List<Facturas>();
            try
            {
                var consulta = db.SP_Listar_Pedidos_By_IdPedido(idpedido);
                foreach (var item in consulta)
                {
                    Facturas f = new Facturas();
                    f.num_fact = item.num_fact;

                    Cliente c = new Cliente();
                    c.NombreCliente = item.DatosCliente;
                    c.DireccionCliente = item.DireccionCliente;
                    f.Cliente = c;
                    f.Fecha = item.Fecha;
                    lista.Add(f);
                }
            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }
            return lista;
        }

        public List<Facturas> listarFacturas()
        {
            List<Facturas> lista = new List<Facturas>();
            try
            {
                var consulta = db.Sp_Listar_Facturas_Pedido();
                foreach (var item in consulta)
                {
                    Facturas f = new Facturas();
                    f.num_fact = item.num_fact;

                    Cliente c = new Cliente();
                    c.NombreCliente = item.DatosCliente;
                    c.DireccionCliente = item.DireccionCliente;
                    f.Cliente = c;
                    f.Fecha = item.Fecha;
                    lista.Add(f);
                }
            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }
            return lista;


        }

        public int codigoFactura()
        {
            int codigo = 0;
            try
            {
                var consulta = db.SP_Generar_Codigo_Factura();
                foreach (var item in consulta)
                {
                    codigo = (int)item.NumFactura;
                }
            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }
            return codigo;

        }

    }
}
