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
    public partial class FrmProductos : Form
    {

        CRUD_Productos prodNE = new CRUD_Productos();

        public Producto p = new Producto();

        public static bool operacion;

        public void cargarProductos()
        {
            dgvProductos.DataSource = prodNE.listarProductos();
        }

        public void configurarGrid()
        {
            dgvProductos.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            dgvProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
        }

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            habilitarbotones(true, false, false, false, true, false, true);
            configurarGrid();
            habilitarEntradas(false);
            cargarProductos();
            buscarProducto(1);
        }

        public void asignarEntradas()
        {
            p.IdProducto = int.Parse(txtCodigo.Text);
            p.NombreProducto = txtDescripcion.Text;
            p.PCProducto = decimal.Parse(txtPC.Text);
            p.PVProducto = decimal.Parse(txtPV.Text);
            p.FechaActProducto = dtpFechaAct.Value.Date;
            p.StockProducto = int.Parse(txtStock.Text);
            p.MarcaProducto = txtMarca.Text;
            p.UnidMedProducto = txtUnidMed.Text;
        }

        public void habilitarEntradas(bool estado)
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = estado;
            txtPC.Enabled = estado;
            txtPV.Enabled = estado;
            txtStock.Enabled = estado;
            txtMarca.Enabled = estado;
            txtUnidMed.Enabled = estado;
        }

        public void limpiarEntradas()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPV.Text = "";
            txtPC.Text = "";
            txtStock.Text = "";
            txtMarca.Text = "";
            txtUnidMed.Text = "";
        }

        public void habilitarbotones(bool nuevo, bool grabar, bool modificar, bool eliminar, bool buscar, bool cancelar, bool salir)
        {
            btnNuevo.Enabled = nuevo;
            btnGrabar.Enabled = grabar;
            btnActualizar.Enabled = modificar;
            btnEliminar.Enabled = eliminar;
            btnBuscar.Enabled = buscar;
            btnCancelar.Enabled = cancelar;
            btnSalir.Enabled = salir;
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
                buscarProducto(int.Parse(codigo));
            }
        }

        private void txtPC_TextChanged(object sender, EventArgs e)
        {
            try
            {   
                double pv = 0;
                if (txtPC.Text.Equals(""))
                {
                    MessageBox.Show("debe ingresar el PC");
                }
                else
                {
                    pv = double.Parse(txtPC.Text) * 1.10;
                    txtPV.Text = pv.ToString();
                }
               
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public void buscarProducto(int codigo)
        {
            p = prodNE.buscarProductosByCodigo(codigo);
            if (p.IdProducto != 0)
            {
                txtCodigo.Text = p.IdProducto.ToString();
                txtDescripcion.Text = p.NombreProducto;
                txtPC.Text = p.PCProducto.ToString();
                txtPV.Text = p.PVProducto.ToString();
                txtStock.Text = p.StockProducto.ToString();
                txtUnidMed.Text = p.UnidMedProducto.ToString();
                txtMarca.Text = p.MarcaProducto;
            }
            else
            {
                MessageBox.Show("Datos no encontrados");
                buscarProducto(1);
            }
        }

        public string nuevoProducto()
        {
            asignarEntradas();
            return prodNE.insertarProducto(p);
        }

        public string actualizarProducto()
        {
            asignarEntradas();
            return prodNE.actualizarProductos(p);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarEntradas(true);
            limpiarEntradas();
            txtCodigo.Text = prodNE.GenerarCodigoProducto().ToString();
            operacion = true;
            habilitarbotones(false, true, false, false, true, true, true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto Eliminado" +
            prodNE.eliminarProducto(int.Parse(txtCodigo.Text)));
            cargarProductos();
        }
        

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                MessageBox.Show("Producto guardado " + nuevoProducto());
            }
            else
            {
                MessageBox.Show("Producto actualizado " + actualizarProducto());
            }
            cargarProductos();
            habilitarbotones(true, false, false, false, true, false, true);
            habilitarEntradas(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            buscarProducto(1);
            habilitarbotones(true, false, false, false, true, false, true);
            habilitarEntradas(false);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            operacion = false;
            habilitarEntradas(true);
            habilitarbotones(false, true, false, false, false, true, true);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProductos.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["IdProducto"].Value.ToString();
                txtDescripcion.Text = row.Cells["NombreProducto"].Value.ToString();
                txtPC.Text = row.Cells["PCProducto"].Value.ToString();
                txtPV.Text = row.Cells["PVProducto"].Value.ToString();
                txtMarca.Text = row.Cells["MarcaProducto"].Value.ToString();
                txtUnidMed.Text = row.Cells["UnidMedProducto"].Value.ToString();
                txtStock.Text = row.Cells["StockProducto"].Value.ToString();
            }
            habilitarbotones(true, false, true, true, true, true, false);
        }

        public void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        public void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtUnidMed_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
           
        }
    }
}
