using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class MDIPrincipal : Form
    {
        public static int idVendedor;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

       

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestiónPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarPedido fgp = new FrmGenerarPedido();
            fgp.MdiParent = this;
            fgp.Show();
        }

        private void pedidosPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalle fd = new FrmDetalle();
            fd.MdiParent = this;
            fd.Show();
        }

        private void pedidosPorFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaPedido fcp = new FrmConsultaPedido();
            fcp.MdiParent = this;
            fcp.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FrmProductos fp = new FrmProductos();
            fp.MdiParent = this;
            fp.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmClientes fc = new FrmClientes();
            fc.MdiParent = this;
            fc.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmGenerarPedido fgp = new FrmGenerarPedido();
            fgp.MdiParent = this;
            fgp.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes fc = new FrmClientes();
            fc.MdiParent = this;
            fc.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos fp = new FrmProductos();
            fp.MdiParent = this;
            fp.Show();
        }

        private void clientesPorNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConClientes fcc = new FrmConClientes();
            fcc.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios fUsu = new FrmUsuarios();
            this.Close();
            fUsu.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantProveedores fProv = new FrmMantProveedores();
            fProv.MdiParent = this;
            fProv.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            FrmMantProveedores fmp = new FrmMantProveedores();
            fmp.MdiParent = this;
            fmp.Show();
        }

        private void géstionCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGenerarCompra fProv = new FrmGenerarCompra();
            fProv.MdiParent = this;
            fProv.Show();
        }

        private void ventasPorCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetalleCompras fProv = new FrmDetalleCompras();
            fProv.MdiParent = this;
            fProv.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmGenerarCompra fProv = new FrmGenerarCompra();
            fProv.MdiParent = this;
            fProv.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteClientes fRptC = new FrmReporteClientes();
            fRptC.MdiParent = this;
            fRptC.Show();
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteProductos fRptP = new FrmReporteProductos();
            fRptP.MdiParent = this;
            fRptP.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReporteProveedores fRptPr = new FrmReporteProveedores();
            fRptPr.MdiParent = this;
            fRptPr.Show();
        }

        private void filtroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConClientes rptC = new FrmConClientes();
            rptC.MdiParent = this;
            rptC.Show();
        }

        private void filtroProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConProductos rptP = new FrmConProductos();
            rptP.MdiParent = this;
            rptP.Show();
        }

        private void filtroProveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConProveedor rptPr = new FrmConProveedor();
            rptPr.MdiParent = this;
            rptPr.Show();
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Está seguro de Cerrar aplicación?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == System.Windows.Forms.DialogResult.Yes)
            {
                System.Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
       
    }
}
