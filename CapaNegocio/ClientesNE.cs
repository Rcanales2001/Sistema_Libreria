using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ModeloDatos;
namespace CapaNegocio
{
    public class ClientesNE
    {
        CRUD_Clientes objCli = new CRUD_Clientes();

        public string insertarClientes(Cliente cli)
        {
            return objCli.insertarClientes(cli);
        }

        public String actualizarClientes(Cliente cli)
        {
            return objCli.actualizarClientes(cli);
        }

        public String eliminarClientes(int codigo)
        {
            return objCli.eliminarClientes(codigo);
        }

        public Cliente buscarClienteByCodigo(int codigo)
        {
            return objCli.buscarClientes(codigo);

        }

        public List<Cliente> listarClientes()
        {
            return objCli.listarClientes();
        }

        public Cliente buscarClienteByDni(string dni)
        {
            return objCli.buscarClientesByDni(dni);
        }

        public int codigoCliente()
        {
            return objCli.generarCodigo();
        }

        public List<Cliente> listarClientesByNombre(string nombre)
        {
            return objCli.listarClientesByNombre(nombre);
        }
    }
}

