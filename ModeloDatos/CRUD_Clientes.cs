using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace ModeloDatos
{
    public class CRUD_Clientes
    {
        PedidosDataContext db = new PedidosDataContext();
        public String insertarClientes(Cliente cli)
        {
            string rpta = "";

            try
            {

                db.SP_Insertar_Cliente(
                                cli.IdCliente,
                                cli.NombreCliente,
                                cli.ApellidoCliente,
                                cli.DNICliente,
                                cli.RUCCliente,
                                cli.TelefonoCliente,
                                cli.DireccionCliente);
                rpta = "Registro guardado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        public String actualizarClientes(Cliente cli)
        {
            string rpta = "";

            try
            {
                db.SP_Actualizar_Cliente(
                                 cli.IdCliente,
                                 cli.NombreCliente,
                                 cli.ApellidoCliente,
                                 cli.DNICliente,
                                 cli.RUCCliente,
                                 cli.TelefonoCliente,
                                 cli.DireccionCliente);
                rpta = "Registro actualizado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }
        public Cliente buscarClientes(int codigo)
        {
            Cliente c = new Cliente();

            try
            {
                var consulta = db.Sp_BuscarCliente(codigo);
                foreach (var cli in consulta)
                {

                    c.IdCliente = cli.IdCliente;
                    c.NombreCliente = cli.NombreCliente;
                    c.ApellidoCliente = cli.ApellidoCliente;
                    c.DNICliente = cli.DNICliente;
                    c.RUCCliente = cli.RUCCliente;
                    c.TelefonoCliente = cli.TelefonoCliente;
                    c.DireccionCliente = cli.DireccionCliente;
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            return c;
        }

        public Cliente buscarClientesByDni(String dni)
        {
            Cliente c = new Cliente();

            try
            {
                var consulta = db.Sp_BuscarCliente_DNI(dni);
                foreach (var cli in consulta)
                {

                    c.IdCliente = cli.IdCliente;
                    c.NombreCliente = cli.NombreCliente;
                    c.ApellidoCliente = cli.ApellidoCliente;
                    c.DNICliente = cli.DNICliente;
                    c.RUCCliente = cli.RUCCliente;
                    c.TelefonoCliente = cli.TelefonoCliente;
                    c.DireccionCliente = cli.DireccionCliente;
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }

            return c;
        }
        public String eliminarClientes(int codigo)
        {
            String rpta = "";

            try
            {
                db.SP_Eliminar_Cliente(codigo);
                rpta = "Cliente eliminado con éxito";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public List<Cliente> listarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                var consulta = db.SP_Listar_Clientes();

                foreach (var cli in consulta)
                {
                    Cliente c = new Cliente();
                    c.IdCliente = cli.IdCliente;
                    c.NombreCliente = cli.NombreCliente;
                    c.ApellidoCliente = cli.ApellidoCliente;
                    c.DNICliente = cli.DNICliente;
                    c.RUCCliente = cli.RUCCliente;
                    c.TelefonoCliente = cli.TelefonoCliente;
                    c.DireccionCliente = cli.DireccionCliente;
                    lista.Add(c);


                }

            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }

        public int generarCodigo()
        {
            int codigo = 0;
            var consulta = db.SP_Generar_Cod_Cliente();

            foreach (var cod in consulta)
            {
                codigo = (int)cod.CodCliente;
            }
            return codigo;
        }


        public List<Cliente> listarClientesByNombre(string nombre)
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                var rs = db.SP_Buscar_ClientesByNombre(nombre);

                foreach (var cli in rs)
                {
                    Cliente c = new Cliente();
                    c.IdCliente = cli.IdCliente;
                    c.NombreCliente = cli.NombreCliente;
                    c.ApellidoCliente = cli.ApellidoCliente;
                    c.DNICliente = cli.DNICliente;
                    c.RUCCliente = cli.RUCCliente;
                    c.TelefonoCliente = cli.TelefonoCliente;
                    c.DireccionCliente = cli.DireccionCliente;
                    lista.Add(c);
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

