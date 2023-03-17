using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ModeloDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmClientes : Form
    {

        public ClientesNE objCliNE = new ClientesNE();
        Cliente c = new Cliente();


        public static bool operacion;

        public void buscarCliente(int codigo)
        {
            Cliente cli = new Cliente();
            cli = objCliNE.buscarClienteByCodigo(codigo);
            this.txtCodigo.Text = cli.IdCliente.ToString();
            this.txtNombres.Text = cli.NombreCliente;
            this.txtApellidos.Text = cli.ApellidoCliente;
            this.txtDNI.Text = cli.DNICliente;
            this.txtRUC.Text = cli.RUCCliente;
            this.txtTelefono.Text = cli.TelefonoCliente;
            this.txtDireccion.Text = cli.DireccionCliente;
        }

        public void cargarClientes()
        {
            dataClientes.DataSource = objCliNE.listarClientes();
        }

        public void configurarGrid()
        {
            dataClientes.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            dataClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            habilitarbotones(true, false, false, false, true, false, true);
            configurarGrid();
            habilitarEntradas(false);
            cargarClientes();
            buscarCliente(1);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // string codigo = Microsoft.VisualBasic.
            //Interaction.InputBox("Ingrese codigo del Producto","Buscar Producto");

            String codigo = InputBox.Show();

            if (codigo == null)
            {
                MessageBox.Show("Operacion no procesada");

            }
            else if (codigo == "")
            {
                MessageBox.Show("Debe ingresar Datos");
                codigo = InputBox.Show();

            }
            else
            {
                habilitarbotones(false, false, true, true, false, true, true);
                buscarCliente(int.Parse(codigo));
            }
        }

        public void limpiarEntradas()
        {

            txtCodigo.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtDNI.Text = "";
            txtRUC.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
        }

        public void habilitarEntradas(bool estado)
        {
            txtCodigo.Enabled = false;
            txtNombres.Enabled = estado;
            txtApellidos.Enabled = estado;
            txtDNI.Enabled = estado;
            txtRUC.Enabled = estado;
            txtTelefono.Enabled = estado;
            txtDireccion.Enabled = estado;
        }

        public void habilitarbotones(bool nuevo, bool grabar, bool modificar,
                                    bool eliminar, bool buscar, bool cancelar,
                                    bool salir)
        {
            btnNuevo.Enabled = nuevo;
            btnGrabar.Enabled = grabar;
            btnActualizar.Enabled = modificar;
            button1.Enabled = eliminar;
            btnBuscar.Enabled = buscar;
            btnCancelar.Enabled = cancelar;
            button2.Enabled = salir;
        }

        //selecionar registros en dgv y mostrar en los textbox
        private void dataClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataClientes.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["IdCliente"].Value.ToString();
                txtNombres.Text = row.Cells["NombreCliente"].Value.ToString();
                txtApellidos.Text = row.Cells["ApellidoCliente"].Value.ToString();
                txtDNI.Text = row.Cells["DNICliente"].Value.ToString();
                txtRUC.Text = row.Cells["RUCCliente"].Value.ToString();
                txtTelefono.Text = row.Cells["TelefonoCliente"].Value.ToString();
                txtDireccion.Text = row.Cells["DireccionCliente"].Value.ToString();
            }
            habilitarbotones(true, false, true, true, true, true, true);
        }

        public void asignarEntradas()
        {
            c.IdCliente = int.Parse(txtCodigo.Text);
            c.NombreCliente = txtNombres.Text;
            c.ApellidoCliente = txtApellidos.Text;
            c.DNICliente = (txtDNI.Text);
            c.RUCCliente = txtRUC.Text;
            c.TelefonoCliente = txtTelefono.Text;
            c.DireccionCliente = txtDireccion.Text;
        }

        public string nuevoCliente()
        {
            asignarEntradas();
            return objCliNE.insertarClientes(c);
        }

        public string actualizarProducto()
        {
            asignarEntradas();
            return objCliNE.actualizarClientes(c);
        }


        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            buscarCliente(1);
            habilitarbotones(true, false, false, false, true, false, true);
            habilitarEntradas(false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarEntradas(true);
            limpiarEntradas();
            txtCodigo.Text = objCliNE.codigoCliente().ToString();
            operacion = true;
            habilitarbotones(false, true, false, false, true, true, true);
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                MessageBox.Show("CLiente guardado " + nuevoCliente());
            }
            else
            {
                MessageBox.Show("Cliente actualizado " + actualizarProducto());
            }
            cargarClientes();
            habilitarbotones(true, false, false, false, true, false, true);
            habilitarEntradas(false);
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            operacion = false;
            habilitarEntradas(true);
            habilitarbotones(false, true, false, false, false, true, true);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             MessageBox.Show("Cliente Eliminado" +
             objCliNE.eliminarClientes(int.Parse(txtCodigo.Text)));
             cargarClientes();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}