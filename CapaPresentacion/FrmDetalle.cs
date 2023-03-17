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
using Util;

namespace CapaPresentacion
{
    public partial class FrmDetalle : Form
    {

        Detalle det = new Detalle();
        List<Detalle> d = new List<Detalle>();

        List<Facturas> lista = new List<Facturas>();

        FacturaNE objFacNE = new FacturaNE();

        DetalleNE objDetNE = new DetalleNE();


        public void mostrarFacturas()
        {
            this.dgvPedidos.DataSource = null;
            this.dgvPedidos.Rows.Clear();

            lista = objFacNE.listarFacuras();
            foreach (var item in lista)
            {
                int renglon = this.dgvPedidos.Rows.Add();
                dgvPedidos.Rows[renglon].Cells[0].Value = item.num_fact.ToString();
                dgvPedidos.Rows[renglon].Cells[1].Value = item.Cliente.NombreCliente.ToString();
                dgvPedidos.Rows[renglon].Cells[2].Value = item.Cliente.DireccionCliente.ToString();
                dgvPedidos.Rows[renglon].Cells[3].Value = item.Fecha.ToShortDateString();
            }
        }

        public void buscarPedidosById(int idpedido)
        {
            this.dgvPedidos.DataSource = null;
            this.dgvPedidos.Rows.Clear();
            lista = objFacNE.listarPedidosById(idpedido);
            foreach (var item in lista)
            {
                int renglon = this.dgvPedidos.Rows.Add();
                dgvPedidos.Rows[renglon].Cells[0].Value = item.num_fact.ToString();
                dgvPedidos.Rows[renglon].Cells[1].Value = item.Cliente.NombreCliente.ToString();
                dgvPedidos.Rows[renglon].Cells[2].Value = item.Cliente.DireccionCliente.ToString();
                dgvPedidos.Rows[renglon].Cells[3].Value = item.Fecha.ToShortDateString();
            }
        }

        public void buscarPedidoById()
        {

            if (this.txtNumFact.Text == "")
            {
                mostrarFacturas();
                dgvDetalle.DataSource = null;
                dgvDetalle.Rows.Clear();
            }
            else
            {
                buscarPedidosById(int.Parse(this.txtNumFact.Text.ToString()));
                txt_cliente.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
                txt_direccion.Text = dgvPedidos.CurrentRow.Cells[2].Value.ToString();
                mostrarDetalle(int.Parse(this.txtNumFact.Text.ToString()));
            }
        }

        public void mostrarDetalle(int fact)
        {
            this.dgvDetalle.DataSource = null;
            this.dgvDetalle.Rows.Clear();
            d = objDetNE.mostrarDetalle(fact);

            foreach (var item in d)
            {
                int renglon = this.dgvDetalle.Rows.Add();
                dgvDetalle.Rows[renglon].Cells[0].Value = item.Producto.IdProducto.ToString();
                dgvDetalle.Rows[renglon].Cells[1].Value = item.Producto.NombreProducto.ToString();
                dgvDetalle.Rows[renglon].Cells[2].Value = item.CantidadVenta.ToString();
                dgvDetalle.Rows[renglon].Cells[3].Value = item.PrecioVenta.ToString();
                dgvDetalle.Rows[renglon].Cells[4].Value = item.Importe.ToString();
            }
        }

        private void Realizar_Calculo()
        {
            double Cantidad;
            double IGV;
            double Total;
            double MTotal;
            //double MVenta;
            //double MIGV;
            double Precio;
            MTotal = 0;
            //MVenta = 0;
            //MIGV = 0;
            lbl_vVenta.Text = "0";
            lbl_Igv.Text = "0";
            lbl_pVenta.Text = "0";
            for (int n = 0; (n
                        <= (this.dgvDetalle.RowCount - 1)); n++)
            {
                Cantidad = double.Parse(dgvDetalle.Rows[n].Cells[2].Value.ToString());
                Precio = double.Parse(dgvDetalle.Rows[n].Cells[3].Value.ToString());
                Total = (Cantidad * Precio);
                this.dgvDetalle.Rows[n].Cells[4].Value = Total.ToString("##,##0.00");
                MTotal = (MTotal + Total);
            }
            lbl_vVenta.Text = MTotal.ToString("##,##0.00");
            IGV = ((MTotal * double.Parse(txt_igvM.Text))
                        / 100);
            lbl_Igv.Text = IGV.ToString("##,##0.00");
            Total = (MTotal + IGV);
            lbl_pVenta.Text = Total.ToString("##,##0.00");
            Convertir_Letras();
        }

        private void Convertir_Letras()
        {
            sisReutilizable objLetras = new sisReutilizable();
            if ((this.dgvDetalle.RowCount == 0))
            {
                lbl_numletras.Text = "";
            }
            else
            {
                string numero;
                int cantidad = this.lbl_pVenta.Text.Length;
                numero = lbl_pVenta.Text.Substring(0, (cantidad - 3));
                lbl_numletras.Text = ("SON: "
                            + (objLetras.toText(double.Parse(numero)) + (" CON "
                            + (lbl_pVenta.Text.Substring((lbl_pVenta.Text.Length - 2)) + "/100 NUEVO SOLES"))));
            }
        }


        //Métodos para Comprobante y TipoComprobante
        public ComprobantePagoNE cpaNE = new ComprobantePagoNE();
        public ComprobantePago cp = new ComprobantePago();

        public TipoComprobanteNE tcpaNE = new TipoComprobanteNE();
        public TipoComprobantePago tpc = new TipoComprobantePago();

        public void cargarTipoComprobante()
        {
            cboTipoComp.DataSource = tcpaNE.listarTipoComp();
            cboTipoComp.DisplayMember = "nombre";
            cboTipoComp.ValueMember = "IdTipoComprobantePago";
        
        }

        public void nroComprobantePago()
        {
            try
            {
                int id = System.Convert.ToInt32(cboTipoComp.SelectedValue.ToString());
                
                txtNroComrpobante.Text =(string) cpaNE.nroComprobantePago(id).ToString();
            }
            catch (Exception ex)
            {

                System.Console.Write(ex.Message);
            }
        }

        public void asignarComprobantePago()
        {
            cp.NroComprobante = int.Parse(txtNroComrpobante.Text);
            cp.IdPedido = int.Parse(txtNumFact.Text);
            cp.IdTipoComp =int.Parse( cboTipoComp.SelectedValue.ToString());
            cp.MotivoEli = "";
            cp.Estado = "Cancelado";
        }

        public string nuevoComprobantePago()
        {
            asignarComprobantePago();
            return cpaNE.insertarComprabantePago(cp);
        }

        public void configurarGrid()
        {
            dgvDetalle.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            dgvDetalle.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;
            dgvPedidos.RowsDefaultCellStyle.BackColor = Color.LightGreen;
            dgvPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow;

        }

        public FrmDetalle()
        {
            InitializeComponent();
        }

        private void FrmDetalle_Load(object sender, EventArgs e)
        {
            mostrarFacturas();
            cargarTipoComprobante();
            configurarGrid();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            buscarPedidoById();
            Realizar_Calculo();
        }

       
       

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FrmRptFactura.MiCod_fact = this.txtNumFact.Text;
            FrmRptFactura.V_Venta = this.lbl_vVenta.Text;
            FrmRptFactura.IGV = this.lbl_Igv.Text;
            FrmRptFactura.Total = this.lbl_pVenta.Text;
            FrmRptFactura.NumeroLetras = this.lbl_numletras.Text;
            FrmRptFactura rpf = new FrmRptFactura();
            rpf.Show();
        }

        private void dgvPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPedido = int.Parse(dgvPedidos.CurrentRow.Cells[0].Value.ToString());
            this.txtNumFact.Text = idPedido.ToString();
            txt_cliente.Text = dgvPedidos.CurrentRow.Cells[1].Value.ToString();
            txt_direccion.Text = dgvPedidos.CurrentRow.Cells[2].Value.ToString();
        }

        private void cboTipoComp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            nroComprobantePago();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comprobante Grabado" + nuevoComprobantePago());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
