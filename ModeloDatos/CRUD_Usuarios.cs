using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModeloDatos
{
    public class CRUD_Usuarios
    {
        PedidosDataContext db = new PedidosDataContext();
        public Usuarios logueoUsuarios(String login)
        {
            Usuarios u = new Usuarios();
            try
            {
                var consulta = db.SP_Listar_Usuarios(login);
                foreach (var us in consulta)
                {
                    u.IdUsuario = us.IdUsuario;
                    u.login = us.login;
                    u.password = us.password;
                    u.IdVendedor = us.IdVendedor;
                }
            }
            catch (Exception)
            {

                throw;
            }

            return u;
        }
    }
}
