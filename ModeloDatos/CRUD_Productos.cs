using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ModeloDatos
{
    public class CRUD_Productos
    {
        PedidosDataContext db = new PedidosDataContext();

        public String insertarProducto(Producto pro)
        {
            String rpta = "";
            try
            {
                db.SP_Insertar_Producto(pro.IdProducto,
                                       pro.NombreProducto,
                                       (pro.PCProducto).ToString(),
                                       (pro.PVProducto).ToString(),
                                       pro.StockProducto,
                                       (pro.FechaActProducto),
                                       pro.MarcaProducto,
                                       pro.UnidMedProducto,
                                       pro.EstadoProducto);
                rpta = "Producto registrado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public List<Producto> listarProductos()
        {
            List<Producto> lista = new List<Producto>();
            try
            {
                var consulta = db.SP_Listar_Producto();
                foreach (var pro in consulta)
                {
                    Producto p = new Producto();
                    p.IdProducto = pro.IdProducto;
                    p.NombreProducto = pro.NombreProducto;
                    p.PCProducto = pro.PCProducto;
                    p.PVProducto = pro.PVProducto;
                    p.StockProducto = pro.StockProducto;
                    p.FechaActProducto = pro.FechaActProducto;
                    p.MarcaProducto = pro.MarcaProducto;
                    p.UnidMedProducto = pro.UnidMedProducto;
                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lista;

        }

        public Producto buscarProductosByCodigo(int codigo)
        {

            Producto p = new Producto();
            try
            {
                var consulta = db.Sp_BuscarProducto(codigo);
                foreach (var prod in consulta)
                {
                    p.IdProducto = prod.IdProducto;
                    p.NombreProducto = prod.NombreProducto;
                    p.PCProducto = prod.PCProducto;
                    p.PVProducto = prod.PVProducto;
                    p.MarcaProducto = prod.MarcaProducto;
                    p.UnidMedProducto = prod.UnidMedProducto;
                    p.StockProducto = prod.StockProducto;
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            return p;
        }

        public List<Producto> listarProductoByNombre(string nombre)
        {
            List<Producto> lista = new List<Producto>();
            Producto p;
            try
            {
                var rs = db.SP_Buscar_ProductosByNombre(nombre);

                foreach (var pro in rs)
                {
                     p = new Producto();
                     p.IdProducto = pro.IdProducto;
                     p.NombreProducto = pro.NombreProducto;
                     p.PCProducto = pro.PCProducto;
                     p.PVProducto = pro.PVProducto;
                     p.StockProducto = pro.StockProducto;
                     lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }

        public int GenerarCodigoProducto()
        {
            int codigo = 0;
            try
            {
                var consulta = db.SP_Generar_Codigo_Producto();
                foreach (var item in consulta)
                {
                    codigo = (int)(item.CodProducto);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return codigo;
        }

        public string eliminarProducto(int id)
        {
            string rpta = "";
            try
            {
                db.SP_Eliminar_Producto(id);
                rpta = "OK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string actualizarProductos(Producto p)
        {
            string rpta = "";
            try
            {
                db.SP_Actualizar_Producto(p.IdProducto,
                                        p.NombreProducto,
                                        p.PCProducto,
                                        p.PVProducto,
                                        p.StockProducto,
                                        p.FechaActProducto,
                                        p.MarcaProducto,
                                        p.UnidMedProducto
                                        );
                rpta = "OK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

    }
}

