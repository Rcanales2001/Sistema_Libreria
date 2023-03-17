using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CapaNegocio;
using ModeloDatos;

namespace CapaPresentacion
{
    public partial class FrmUsuarios : Form
    {

        Usuarios u = new Usuarios();
        UsuariosNE une = new UsuariosNE();
        public void autenticacionUsuarios()
        {

            try
            {
                string login;
                login = this.txtUsuario.Text;
                int cuenta = 0;
                u = une.logueUsuarios(login);
                MDIPrincipal.idVendedor = u.IdVendedor;
                if ((u.login.Equals(this.txtUsuario.Text)) && (u.password.Equals(this.txtPassword.Text)))
                {
                    MessageBox.Show("Está ingresando como usuario: " + u.login);
                    this.Hide();
                    MDIPrincipal fp = new MDIPrincipal();
                    fp.Show();
                }
                else
                {
                    cuenta = cuenta + 1;
                    if (cuenta == 3)
                    {
                        MessageBox.Show("PARA OTRA VEZ SERÁ");
                        this.Close();
                    }
                    MessageBox.Show("Te queda " + (3 - cuenta).ToString() +
                        "oportunidades", "Error");
                    this.txtPassword.Clear();
                    this.txtUsuario.Clear();
                    this.txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.autenticacionUsuarios();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
