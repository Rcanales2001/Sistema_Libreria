using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ModeloDatos;

namespace CapaNegocio
{
    public class UsuariosNE
    {
        CRUD_Usuarios objUsu = new CRUD_Usuarios();

        public Usuarios logueUsuarios(string login)
        {
            return objUsu.logueoUsuarios(login);
        }

    }
}
