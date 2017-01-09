namespace prjbase
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeSistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupamentoDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoXBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteXFormaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadesXTransportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesXTransportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.processosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.utilitáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.mnuCadUsuario,
            this.pedidosDeVendasToolStripMenuItem,
            this.produtoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.arquivoToolStripMenuItem.Text = "&Cadastros";
            // 
            // mnuCadUsuario
            // 
            this.mnuCadUsuario.Name = "mnuCadUsuario";
            this.mnuCadUsuario.Size = new System.Drawing.Size(172, 22);
            this.mnuCadUsuario.Text = "&Usuarios";
            this.mnuCadUsuario.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // pedidosDeVendasToolStripMenuItem
            // 
            this.pedidosDeVendasToolStripMenuItem.Name = "pedidosDeVendasToolStripMenuItem";
            this.pedidosDeVendasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pedidosDeVendasToolStripMenuItem.Text = "Pedidos de &Vendas";
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrupamentoDePedidosToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.processosToolStripMenuItem.Text = "&Processos";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotasDeEntregaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Text = "&Relatorios";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosDeSistemasToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Text = "&Utilitários";
            // 
            // parametrosDeSistemasToolStripMenuItem
            // 
            this.parametrosDeSistemasToolStripMenuItem.Name = "parametrosDeSistemasToolStripMenuItem";
            this.parametrosDeSistemasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.parametrosDeSistemasToolStripMenuItem.Text = "Parâmetro de Sistema";
            // 
            // agrupamentoDePedidosToolStripMenuItem
            // 
            this.agrupamentoDePedidosToolStripMenuItem.Name = "agrupamentoDePedidosToolStripMenuItem";
            this.agrupamentoDePedidosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.agrupamentoDePedidosToolStripMenuItem.Text = "Agrupamento de Pedidos";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(551, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoXBaseToolStripMenuItem,
            this.clienteXFormaDePagamentoToolStripMenuItem,
            this.localidadesXTransportadoraToolStripMenuItem,
            this.clientesXTransportadoraToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.produtoToolStripMenuItem.Text = "R&elacionamentos";
            // 
            // produtoXBaseToolStripMenuItem
            // 
            this.produtoXBaseToolStripMenuItem.Name = "produtoXBaseToolStripMenuItem";
            this.produtoXBaseToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.produtoXBaseToolStripMenuItem.Text = "Produto x Base";
            // 
            // clienteXFormaDePagamentoToolStripMenuItem
            // 
            this.clienteXFormaDePagamentoToolStripMenuItem.Name = "clienteXFormaDePagamentoToolStripMenuItem";
            this.clienteXFormaDePagamentoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.clienteXFormaDePagamentoToolStripMenuItem.Text = "Cliente x Forma de Pagamento";
            // 
            // localidadesXTransportadoraToolStripMenuItem
            // 
            this.localidadesXTransportadoraToolStripMenuItem.Name = "localidadesXTransportadoraToolStripMenuItem";
            this.localidadesXTransportadoraToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.localidadesXTransportadoraToolStripMenuItem.Text = "Localidades x Transportadora";
            // 
            // clientesXTransportadoraToolStripMenuItem
            // 
            this.clientesXTransportadoraToolStripMenuItem.Name = "clientesXTransportadoraToolStripMenuItem";
            this.clientesXTransportadoraToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.clientesXTransportadoraToolStripMenuItem.Text = "Clientes x Transportadora";
            // 
            // rotasDeEntregaToolStripMenuItem
            // 
            this.rotasDeEntregaToolStripMenuItem.Name = "rotasDeEntregaToolStripMenuItem";
            this.rotasDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotasDeEntregaToolStripMenuItem.Text = "Rotas de Entrega";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clientesToolStripMenuItem.Text = "&Clientes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Omie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadUsuario;
        private System.Windows.Forms.ToolStripMenuItem pedidosDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoXBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteXFormaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadesXTransportadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesXTransportadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupamentoDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosDeSistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}