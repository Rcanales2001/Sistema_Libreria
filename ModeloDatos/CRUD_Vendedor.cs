using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatos
{
    public class CRUD_Vendedor
    {
        public PedidosDataContext db = new PedidosDataContext();
        public Vendedor buscarVendodorById(int idVendedor)
        {
            Vendedor v = new Vendedor();
            try
            {
                var consulta = db.Sp_BuscarVendedor(idVendedor);
                foreach (var item in consulta)
                {
                    v.IdVendedor = item.IdVendedor;
                    v.NombreVendedor = item.NombreVendedor;
                    v.ApellidoVendedor = item.ApellidoVendedor;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return v;
        }
        public String insertarVendedor(Vendedor V)
        {
            string rpta = "";

            try
            {

                db.SP_Insertar_Vendedor(V.IdVendedor, V.NombreVendedor, V.ApellidoVendedor, V.DireccionVendedor, V.DNIVendedor);
                rpta = "Registro guardado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        public String actualizarVendedor(Vendedor V)
        {
            string rpta = "";

            try
            {
                db.SP_Actualizar_Vendedor(V.IdVendedor, V.NombreVendedor, V.ApellidoVendedor, V.DNIVendedor, V.DireccionVendedor);
                rpta = "Registro actualizado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        public Vendedor buscarVendedor(int codigo)
        {
            Vendedor v = new Vendedor();

            try
            {
                var consulta = db.Sp_BuscarVendedor(codigo);
                foreach (var cli in consulta)
                {

                    v.IdVendedor = cli.IdVendedor;
                    v.NombreVendedor = cli.NombreVendedor;
                    v.ApellidoVendedor = cli.ApellidoVendedor;
                    v.DNIVendedor = cli.DNIVendedor;
                    v.DireccionVendedor = cli.DireccionVendedor;
                   
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            return v;
        }
        public String eliminarVendedor(int codigo)
        {
            String rpta = "";

            try
            {
                db.SP_Eliminar_Vendedor(codigo);
                rpta = "Vendedor eliminado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

    }
}
