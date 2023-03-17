namespace CapaPresentacion
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.géstionCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesPorNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorCodigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtroProveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.movimientosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(967, 55);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.proveedoresToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Sistema;
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(199, 51);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Persona;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Video;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.login2;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Global_manager;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // movimientosToolStripMenuItem
            // 
            this.movimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónPedidoToolStripMenuItem,
            this.géstionCompraToolStripMenuItem});
            this.movimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimientosToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Lista;
            this.movimientosToolStripMenuItem.Name = "movimientosToolStripMenuItem";
            this.movimientosToolStripMenuItem.Size = new System.Drawing.Size(168, 51);
            this.movimientosToolStripMenuItem.Text = "Movimientos";
            // 
            // gestiónPedidoToolStripMenuItem
            // 
            this.gestiónPedidoToolStripMenuItem.Name = "gestiónPedidoToolStripMenuItem";
            this.gestiónPedidoToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.gestiónPedidoToolStripMenuItem.Text = "Gestión Venta";
            this.gestiónPedidoToolStripMenuItem.Click += new System.EventHandler(this.gestiónPedidoToolStripMenuItem_Click);
            // 
            // géstionCompraToolStripMenuItem
            // 
            this.géstionCompraToolStripMenuItem.Name = "géstionCompraToolStripMenuItem";
            this.géstionCompraToolStripMenuItem.Size = new System.Drawing.Size(241, 32);
            this.géstionCompraToolStripMenuItem.Text = "Gestión Compra";
            this.géstionCompraToolStripMenuItem.Click += new System.EventHandler(this.géstionCompraToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosPorCodigoToolStripMenuItem,
            this.pedidosPorFechasToolStripMenuItem,
            this.clientesPorNombreToolStripMenuItem,
            this.ventasPorCodigoToolStripMenuItem});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Buscar;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(135, 51);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // pedidosPorCodigoToolStripMenuItem
            // 
            this.pedidosPorCodigoToolStripMenuItem.Name = "pedidosPorCodigoToolStripMenuItem";
            this.pedidosPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.pedidosPorCodigoToolStripMenuItem.Text = "Pedidos por Codigo";
            this.pedidosPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.pedidosPorCodigoToolStripMenuItem_Click);
            // 
            // pedidosPorFechasToolStripMenuItem
            // 
            this.pedidosPorFechasToolStripMenuItem.Name = "pedidosPorFechasToolStripMenuItem";
            this.pedidosPorFechasToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.pedidosPorFechasToolStripMenuItem.Text = "Pedidos por Fechas";
            this.pedidosPorFechasToolStripMenuItem.Click += new System.EventHandler(this.pedidosPorFechasToolStripMenuItem_Click);
            // 
            // clientesPorNombreToolStripMenuItem
            // 
            this.clientesPorNombreToolStripMenuItem.Name = "clientesPorNombreToolStripMenuItem";
            this.clientesPorNombreToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.clientesPorNombreToolStripMenuItem.Text = "Clientes por nombre";
            this.clientesPorNombreToolStripMenuItem.Click += new System.EventHandler(this.clientesPorNombreToolStripMenuItem_Click);
            // 
            // ventasPorCodigoToolStripMenuItem
            // 
            this.ventasPorCodigoToolStripMenuItem.Name = "ventasPorCodigoToolStripMenuItem";
            this.ventasPorCodigoToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.ventasPorCodigoToolStripMenuItem.Text = "Ventas por Codigo";
            this.ventasPorCodigoToolStripMenuItem.Click += new System.EventHandler(this.ventasPorCodigoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.filtroClientesToolStripMenuItem,
            this.productosToolStripMenuItem1,
            this.filtroProductosToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.filtroProveedoresToolStripMenuItem1});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Image = global::CapaPresentacion.Properties.Resources.Reporte1;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(129, 51);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(263, 32);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // filtroClientesToolStripMenuItem
            // 
            this.filtroClientesToolStripMenuItem.Name = "filtroClientesToolStripMenuItem";
            this.filtroClientesToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.filtroClientesToolStripMenuItem.Text = "Filtro Clientes";
            this.filtroClientesToolStripMenuItem.Click += new System.EventHandler(this.filtroClientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(263, 32);
            this.productosToolStripMenuItem1.Text = "Productos";
            this.productosToolStripMenuItem1.Click += new System.EventHandler(this.productosToolStripMenuItem1_Click);
            // 
            // filtroProductosToolStripMenuItem
            // 
            this.filtroProductosToolStripMenuItem.Name = "filtroProductosToolStripMenuItem";
            this.filtroProductosToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.filtroProductosToolStripMenuItem.Text = "Filtro Productos";
            this.filtroProductosToolStripMenuItem.Click += new System.EventHandler(this.filtroProveedoresToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(263, 32);
            this.ventasToolStripMenuItem.Text = "Proveedores";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // filtroProveedoresToolStripMenuItem1
            // 
            this.filtroProveedoresToolStripMenuItem1.Name = "filtroProveedoresToolStripMenuItem1";
            this.filtroProveedoresToolStripMenuItem1.Size = new System.Drawing.Size(263, 32);
            this.filtroProveedoresToolStripMenuItem1.Text = "Filtro Proveedores";
            this.filtroProveedoresToolStripMenuItem1.Click += new System.EventHandler(this.filtroProveedoresToolStripMenuItem1_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripButton4});
            this.toolStrip.Location = new System.Drawing.Point(0, 55);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(967, 76);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripButton3.Image = global::CapaPresentacion.Properties.Resources.product;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 54);
            this.toolStripButton3.Text = "Productos";
            this.toolStripButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Image = global::CapaPresentacion.Properties.Resources.logocliente;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(60, 54);
            this.toolStripButton1.Text = "Clientes";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Image = global::CapaPresentacion.Properties.Resources.Global_manager;
            this.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(70, 60);
            this.toolStripButton5.Text = "Proveedores";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton5.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Image = global::CapaPresentacion.Properties.Resources.sales;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 54);
            this.toolStripButton2.Text = "Ventas";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 76);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Image = global::CapaPresentacion.Properties.Resources.sales;
            this.toolStripButton4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 54);
            this.toolStripButton4.Text = "Compras";
            this.toolStripButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(967, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaPresentacion.Properties.Resources.preventivo_Bd4dce9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE GESTION DE PEDIDOS VENTAS Y COMPRAS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosPorFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem clientesPorNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem géstionCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ventasPorCodigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtroProveedoresToolStripMenuItem1;
    }
}



