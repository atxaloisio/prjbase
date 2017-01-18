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
            this.mnuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadPedidoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadRelProdutoBase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadRelClienteFormaPagamento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadRelLocalidadeTransportadora = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadRelClienteTransportadora = new System.Windows.Forms.ToolStripMenuItem();
            this.processosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupamentoDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotasDeEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeSistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanFecharTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.processosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadClientes,
            this.mnuCadUsuario,
            this.mnuCadPedidoVendas,
            this.produtoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.arquivoToolStripMenuItem.Text = "&Cadastros";
            // 
            // mnuCadClientes
            // 
            this.mnuCadClientes.Name = "mnuCadClientes";
            this.mnuCadClientes.Size = new System.Drawing.Size(188, 22);
            this.mnuCadClientes.Text = "&Clientes";
            this.mnuCadClientes.Click += new System.EventHandler(this.mnuCadClientes_Click);
            // 
            // mnuCadUsuario
            // 
            this.mnuCadUsuario.Name = "mnuCadUsuario";
            this.mnuCadUsuario.Size = new System.Drawing.Size(188, 22);
            this.mnuCadUsuario.Text = "&Usuarios";
            this.mnuCadUsuario.Click += new System.EventHandler(this.mnuCadUsuario_Click);
            // 
            // mnuCadPedidoVendas
            // 
            this.mnuCadPedidoVendas.Name = "mnuCadPedidoVendas";
            this.mnuCadPedidoVendas.Size = new System.Drawing.Size(188, 22);
            this.mnuCadPedidoVendas.Text = "Pedidos de &Vendas";
            this.mnuCadPedidoVendas.Click += new System.EventHandler(this.mnuCadPedidoVendas_Click);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadRelProdutoBase,
            this.mnuCadRelClienteFormaPagamento,
            this.mnuCadRelLocalidadeTransportadora,
            this.mnuCadRelClienteTransportadora});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.produtoToolStripMenuItem.Text = "R&elacionamentos";
            // 
            // mnuCadRelProdutoBase
            // 
            this.mnuCadRelProdutoBase.Name = "mnuCadRelProdutoBase";
            this.mnuCadRelProdutoBase.Size = new System.Drawing.Size(255, 22);
            this.mnuCadRelProdutoBase.Text = "Produto x Base";
            // 
            // mnuCadRelClienteFormaPagamento
            // 
            this.mnuCadRelClienteFormaPagamento.Name = "mnuCadRelClienteFormaPagamento";
            this.mnuCadRelClienteFormaPagamento.Size = new System.Drawing.Size(255, 22);
            this.mnuCadRelClienteFormaPagamento.Text = "Cliente x Forma de Pagamento";
            // 
            // mnuCadRelLocalidadeTransportadora
            // 
            this.mnuCadRelLocalidadeTransportadora.Name = "mnuCadRelLocalidadeTransportadora";
            this.mnuCadRelLocalidadeTransportadora.Size = new System.Drawing.Size(255, 22);
            this.mnuCadRelLocalidadeTransportadora.Text = "Localidades x Transportadora";
            // 
            // mnuCadRelClienteTransportadora
            // 
            this.mnuCadRelClienteTransportadora.Name = "mnuCadRelClienteTransportadora";
            this.mnuCadRelClienteTransportadora.Size = new System.Drawing.Size(255, 22);
            this.mnuCadRelClienteTransportadora.Text = "Cliente x Transportadora";
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrupamentoDePedidosToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.processosToolStripMenuItem.Text = "&Processos";
            // 
            // agrupamentoDePedidosToolStripMenuItem
            // 
            this.agrupamentoDePedidosToolStripMenuItem.Name = "agrupamentoDePedidosToolStripMenuItem";
            this.agrupamentoDePedidosToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.agrupamentoDePedidosToolStripMenuItem.Text = "Agrupamento de Pedidos";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotasDeEntregaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.relatoriosToolStripMenuItem.Text = "&Relatorios";
            // 
            // rotasDeEntregaToolStripMenuItem
            // 
            this.rotasDeEntregaToolStripMenuItem.Name = "rotasDeEntregaToolStripMenuItem";
            this.rotasDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.rotasDeEntregaToolStripMenuItem.Text = "Rotas de Entrega";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parametrosDeSistemasToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.utilitáriosToolStripMenuItem.Text = "&Utilitários";
            // 
            // parametrosDeSistemasToolStripMenuItem
            // 
            this.parametrosDeSistemasToolStripMenuItem.Name = "parametrosDeSistemasToolStripMenuItem";
            this.parametrosDeSistemasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.parametrosDeSistemasToolStripMenuItem.Text = "Parâmetro de Sistema";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuJanFecharTodos});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // mnuJanFecharTodos
            // 
            this.mnuJanFecharTodos.Name = "mnuJanFecharTodos";
            this.mnuJanFecharTodos.Size = new System.Drawing.Size(154, 22);
            this.mnuJanFecharTodos.Text = "Fechar Todos";
            this.mnuJanFecharTodos.Click += new System.EventHandler(this.mnuJanFecharTodos_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.ToolStripMenuItem mnuCadPedidoVendas;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadRelProdutoBase;
        private System.Windows.Forms.ToolStripMenuItem mnuCadRelClienteFormaPagamento;
        private System.Windows.Forms.ToolStripMenuItem mnuCadRelLocalidadeTransportadora;
        private System.Windows.Forms.ToolStripMenuItem mnuCadRelClienteTransportadora;
        private System.Windows.Forms.ToolStripMenuItem processosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupamentoDePedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotasDeEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosDeSistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem mnuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuJanFecharTodos;
    }
}