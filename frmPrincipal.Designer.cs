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
            this.menuSistema = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProdutos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosDeSistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPerfilUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPermissoesAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuJanFecharTodos = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSistema
            // 
            this.menuSistema.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSistema.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.processosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.utilitáriosToolStripMenuItem,
            this.janelasToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuSistema.Location = new System.Drawing.Point(0, 0);
            this.menuSistema.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuSistema.Name = "menuSistema";
            this.menuSistema.Size = new System.Drawing.Size(551, 24);
            this.menuSistema.TabIndex = 1;
            this.menuSistema.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadClientes,
            this.mnuProdutos,
            this.mnuCadPedidoVendas,
            this.produtoToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.arquivoToolStripMenuItem.Tag = "1000";
            this.arquivoToolStripMenuItem.Text = "&Cadastros";
            // 
            // mnuCadClientes
            // 
            this.mnuCadClientes.Name = "mnuCadClientes";
            this.mnuCadClientes.Size = new System.Drawing.Size(172, 22);
            this.mnuCadClientes.Tag = "1001";
            this.mnuCadClientes.Text = "&Clientes";
            this.mnuCadClientes.Click += new System.EventHandler(this.mnuCadClientes_Click);
            // 
            // mnuProdutos
            // 
            this.mnuProdutos.Name = "mnuProdutos";
            this.mnuProdutos.Size = new System.Drawing.Size(172, 22);
            this.mnuProdutos.Tag = "1002";
            this.mnuProdutos.Text = "Produtos";
            this.mnuProdutos.Click += new System.EventHandler(this.mnuProdutos_Click);
            // 
            // mnuCadPedidoVendas
            // 
            this.mnuCadPedidoVendas.Name = "mnuCadPedidoVendas";
            this.mnuCadPedidoVendas.Size = new System.Drawing.Size(172, 22);
            this.mnuCadPedidoVendas.Tag = "1003";
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
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.produtoToolStripMenuItem.Tag = "1004";
            this.produtoToolStripMenuItem.Text = "R&elacionamentos";
            // 
            // mnuCadRelProdutoBase
            // 
            this.mnuCadRelProdutoBase.Name = "mnuCadRelProdutoBase";
            this.mnuCadRelProdutoBase.Size = new System.Drawing.Size(236, 22);
            this.mnuCadRelProdutoBase.Tag = "10041";
            this.mnuCadRelProdutoBase.Text = "Produto x Base";
            // 
            // mnuCadRelClienteFormaPagamento
            // 
            this.mnuCadRelClienteFormaPagamento.Name = "mnuCadRelClienteFormaPagamento";
            this.mnuCadRelClienteFormaPagamento.Size = new System.Drawing.Size(236, 22);
            this.mnuCadRelClienteFormaPagamento.Tag = "10042";
            this.mnuCadRelClienteFormaPagamento.Text = "Cliente x Forma de Pagamento";
            this.mnuCadRelClienteFormaPagamento.Click += new System.EventHandler(this.mnuCadRelClienteFormaPagamento_Click);
            // 
            // mnuCadRelLocalidadeTransportadora
            // 
            this.mnuCadRelLocalidadeTransportadora.Name = "mnuCadRelLocalidadeTransportadora";
            this.mnuCadRelLocalidadeTransportadora.Size = new System.Drawing.Size(236, 22);
            this.mnuCadRelLocalidadeTransportadora.Tag = "10043";
            this.mnuCadRelLocalidadeTransportadora.Text = "Transportadora x Localidades";
            this.mnuCadRelLocalidadeTransportadora.Click += new System.EventHandler(this.mnuCadRelLocalidadeTransportadora_Click);
            // 
            // mnuCadRelClienteTransportadora
            // 
            this.mnuCadRelClienteTransportadora.Name = "mnuCadRelClienteTransportadora";
            this.mnuCadRelClienteTransportadora.Size = new System.Drawing.Size(236, 22);
            this.mnuCadRelClienteTransportadora.Tag = "10044";
            this.mnuCadRelClienteTransportadora.Text = "Cliente x Transportadora";
            // 
            // processosToolStripMenuItem
            // 
            this.processosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrupamentoDePedidosToolStripMenuItem});
            this.processosToolStripMenuItem.Name = "processosToolStripMenuItem";
            this.processosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.processosToolStripMenuItem.Tag = "2000";
            this.processosToolStripMenuItem.Text = "&Processos";
            // 
            // agrupamentoDePedidosToolStripMenuItem
            // 
            this.agrupamentoDePedidosToolStripMenuItem.Name = "agrupamentoDePedidosToolStripMenuItem";
            this.agrupamentoDePedidosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.agrupamentoDePedidosToolStripMenuItem.Tag = "2001";
            this.agrupamentoDePedidosToolStripMenuItem.Text = "Agrupamento de Pedidos";
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotasDeEntregaToolStripMenuItem});
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatoriosToolStripMenuItem.Tag = "3000";
            this.relatoriosToolStripMenuItem.Text = "&Relatorios";
            // 
            // rotasDeEntregaToolStripMenuItem
            // 
            this.rotasDeEntregaToolStripMenuItem.Name = "rotasDeEntregaToolStripMenuItem";
            this.rotasDeEntregaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.rotasDeEntregaToolStripMenuItem.Tag = "3001";
            this.rotasDeEntregaToolStripMenuItem.Text = "Rotas de Entrega";
            // 
            // utilitáriosToolStripMenuItem
            // 
            this.utilitáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarSenhaToolStripMenuItem,
            this.parametrosDeSistemasToolStripMenuItem,
            this.controleAcessoToolStripMenuItem});
            this.utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            this.utilitáriosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.utilitáriosToolStripMenuItem.Tag = "4000";
            this.utilitáriosToolStripMenuItem.Text = "&Utilitários";
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.trocarSenhaToolStripMenuItem.Text = "Trocar senha";
            // 
            // parametrosDeSistemasToolStripMenuItem
            // 
            this.parametrosDeSistemasToolStripMenuItem.Name = "parametrosDeSistemasToolStripMenuItem";
            this.parametrosDeSistemasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.parametrosDeSistemasToolStripMenuItem.Tag = "4001";
            this.parametrosDeSistemasToolStripMenuItem.Text = "Parâmetro de Sistema";
            // 
            // controleAcessoToolStripMenuItem
            // 
            this.controleAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadUsuario,
            this.mnuPerfilUsuarios,
            this.mnuPermissoesAcesso});
            this.controleAcessoToolStripMenuItem.Name = "controleAcessoToolStripMenuItem";
            this.controleAcessoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.controleAcessoToolStripMenuItem.Tag = "4002";
            this.controleAcessoToolStripMenuItem.Text = "&Controle de Acesso";
            // 
            // mnuCadUsuario
            // 
            this.mnuCadUsuario.Name = "mnuCadUsuario";
            this.mnuCadUsuario.Size = new System.Drawing.Size(189, 22);
            this.mnuCadUsuario.Tag = "40021";
            this.mnuCadUsuario.Text = "Usuários";
            this.mnuCadUsuario.Click += new System.EventHandler(this.mnuCadUsuario_Click);
            // 
            // mnuPerfilUsuarios
            // 
            this.mnuPerfilUsuarios.Name = "mnuPerfilUsuarios";
            this.mnuPerfilUsuarios.Size = new System.Drawing.Size(189, 22);
            this.mnuPerfilUsuarios.Tag = "40022";
            this.mnuPerfilUsuarios.Text = "Perfis de Usuários";
            this.mnuPerfilUsuarios.Click += new System.EventHandler(this.mnuPerfilUsuarios_Click);
            // 
            // mnuPermissoesAcesso
            // 
            this.mnuPermissoesAcesso.Name = "mnuPermissoesAcesso";
            this.mnuPermissoesAcesso.Size = new System.Drawing.Size(189, 22);
            this.mnuPermissoesAcesso.Tag = "40023";
            this.mnuPermissoesAcesso.Text = "Permissões de Acesso";
            this.mnuPermissoesAcesso.Click += new System.EventHandler(this.mnuPermissoesAcesso_Click);
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuJanFecharTodos});
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Tag = "5000";
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // mnuJanFecharTodos
            // 
            this.mnuJanFecharTodos.Name = "mnuJanFecharTodos";
            this.mnuJanFecharTodos.Size = new System.Drawing.Size(144, 22);
            this.mnuJanFecharTodos.Text = "Fechar Todos";
            this.mnuJanFecharTodos.Click += new System.EventHandler(this.mnuJanFecharTodos_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Tag = "6000";
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.menuSistema);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuSistema;
            this.Name = "frmPrincipal";
            this.Text = "Omie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuSistema.ResumeLayout(false);
            this.menuSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSistema;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem mnuCadClientes;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuJanFecharTodos;
        private System.Windows.Forms.ToolStripMenuItem mnuProdutos;
        private System.Windows.Forms.ToolStripMenuItem controleAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuPerfilUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuPermissoesAcesso;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
    }
}