using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ModeloDatos
{
    public class CRUD_Proveedor
    {
        PedidosDataContext db = new PedidosDataContext();

        public String insertarProveedor(Proveedor pro)
        {
            string rpta = "";
            try
            {

                db.SP_Insertar_Proveedor(pro.idProveedor,
                                         pro.nombreProveedor,
                                         pro.RUCProveedor,
                                         pro.direccionProveedor,
                                         pro.TelefonoProveedor,
                                         pro.FechaRegistro);
                rpta = "Registro guardado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public List<Proveedor> listarProveedor()
        {
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                var consulta = db.SP_Listar_Proveedores();
                foreach (var prov in consulta)
                {
                    Proveedor pr = new Proveedor();
                    pr.idProveedor = prov.idProveedor;
                    pr.nombreProveedor = prov.nombreProveedor;
                    pr.RUCProveedor = prov.RUCProveedor;
                    pr.direccionProveedor = prov.direccionProveedor;
                    pr.TelefonoProveedor = prov.TelefonoProveedor;
                    pr.FechaRegistro = prov.FechaRegistro;
                    lista.Add(pr);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return lista;
        }

        public Proveedor buscarProveedorByCodigo(int codigo)
        {
            Proveedor pro = new Proveedor();
            try
            {
                var consulta = db.Sp_BuscarProveedor(codigo);
                foreach (var prov in consulta)
                {
                    pro.idProveedor = prov.idProveedor;
                    pro.nombreProveedor = prov.nombreProveedor;
                    pro.RUCProveedor = prov.RUCProveedor;
                    pro.direccionProveedor = prov.direccionProveedor;
                    pro.TelefonoProveedor = prov.TelefonoProveedor;
                    pro.FechaRegistro = prov.FechaRegistro;
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return pro;
        }

        public int GenerarCodigoProveedor()
        {
            int codigo = 0;
            try
            {
                var consulta = db.SP_Generar_Codigo_Proveedor();
                foreach (var item in consulta)
                {
                    codigo = (int)(item.CodProveedor);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return codigo;
        }

        public string eliminarProveedor(int id)
        {
            string rpta = "";
            try
            {
                db.SP_Eliminar_Proveedor(id);
                rpta = "OK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string actualizarProveedor(Proveedor pro)
        {
            string rpta = "";
            try
            {
                db.SP_Actualizar_Proveedor(pro.idProveedor,
                                           pro.nombreProveedor,
                                           pro.RUCProveedor,
                                           pro.direccionProveedor,
                                           pro.TelefonoProveedor,
                                           pro.FechaRegistro
                                           );
                rpta = "OK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public List<Proveedor> listarProveedoresByNombre(string nombre)
        {
            List<Proveedor> lista = new List<Proveedor>();
            try
            {
                var rs = db.SP_Buscar_ProveedoresByNombre(nombre);

                foreach (var pro in rs)
                {
                    Proveedor p = new Proveedor();
                    p.idProveedor = pro.idProveedor;
                    p.nombreProveedor = pro.nombreProveedor;
                    p.RUCProveedor = pro.RUCProveedor;
                    p.direccionProveedor = pro.direccionProveedor;
                    p.TelefonoProveedor = pro.TelefonoProveedor;
                    p.FechaRegistro = pro.FechaRegistro;
                    lista.Add(p);
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
