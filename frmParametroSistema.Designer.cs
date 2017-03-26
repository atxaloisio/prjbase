namespace prjbase
{
    partial class frmParametroSistema
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
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tcParametros = new System.Windows.Forms.TabControl();
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.btnCaminhoArquivos = new System.Windows.Forms.Button();
            this.txtCaminhoArquivos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkIntGenLab = new System.Windows.Forms.CheckBox();
            this.tpPedidoVenda = new System.Windows.Forms.TabPage();
            this.cbContaCorrente = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpIntegracao = new System.Windows.Forms.TabPage();
            this.txtAppSecret = new System.Windows.Forms.TextBox();
            this.txtAppKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dlgCaminhoArquivos = new System.Windows.Forms.FolderBrowserDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.pnlPrincipal.SuspendLayout();
            this.tcParametros.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.tpPedidoVenda.SuspendLayout();
            this.tpIntegracao.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPrincipal.Controls.Add(this.tcParametros);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPrincipal.Location = new System.Drawing.Point(115, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(548, 258);
            this.pnlPrincipal.TabIndex = 2;
            // 
            // tcParametros
            // 
            this.tcParametros.Controls.Add(this.tpGeral);
            this.tcParametros.Controls.Add(this.tpPedidoVenda);
            this.tcParametros.Controls.Add(this.tpIntegracao);
            this.tcParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcParametros.Location = new System.Drawing.Point(0, 0);
            this.tcParametros.Name = "tcParametros";
            this.tcParametros.SelectedIndex = 0;
            this.tcParametros.Size = new System.Drawing.Size(546, 256);
            this.tcParametros.TabIndex = 0;
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.btnCaminhoArquivos);
            this.tpGeral.Controls.Add(this.txtCaminhoArquivos);
            this.tpGeral.Controls.Add(this.label1);
            this.tpGeral.Controls.Add(this.chkIntGenLab);
            this.tpGeral.Location = new System.Drawing.Point(4, 25);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(538, 227);
            this.tpGeral.TabIndex = 0;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // btnCaminhoArquivos
            // 
            this.btnCaminhoArquivos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCaminhoArquivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhoArquivos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhoArquivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaminhoArquivos.Image = global::prjbase.Properties.Resources.pasta;
            this.btnCaminhoArquivos.Location = new System.Drawing.Point(504, 47);
            this.btnCaminhoArquivos.Name = "btnCaminhoArquivos";
            this.btnCaminhoArquivos.Size = new System.Drawing.Size(31, 28);
            this.btnCaminhoArquivos.TabIndex = 10;
            this.btnCaminhoArquivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCaminhoArquivos.UseVisualStyleBackColor = false;
            this.btnCaminhoArquivos.Click += new System.EventHandler(this.btnCaminhoArquivos_Click);
            // 
            // txtCaminhoArquivos
            // 
            this.txtCaminhoArquivos.Location = new System.Drawing.Point(6, 50);
            this.txtCaminhoArquivos.Name = "txtCaminhoArquivos";
            this.txtCaminhoArquivos.Size = new System.Drawing.Size(496, 23);
            this.txtCaminhoArquivos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho de geração do arquivos de integração";
            // 
            // chkIntGenLab
            // 
            this.chkIntGenLab.AutoSize = true;
            this.chkIntGenLab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIntGenLab.Location = new System.Drawing.Point(6, 6);
            this.chkIntGenLab.Name = "chkIntGenLab";
            this.chkIntGenLab.Size = new System.Drawing.Size(262, 20);
            this.chkIntGenLab.TabIndex = 0;
            this.chkIntGenLab.Text = "Gerar arquivo de integração GENLAB";
            this.chkIntGenLab.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.chkIntGenLab.UseVisualStyleBackColor = true;
            // 
            // tpPedidoVenda
            // 
            this.tpPedidoVenda.Controls.Add(this.txtCodigoEmpresa);
            this.tpPedidoVenda.Controls.Add(this.label6);
            this.tpPedidoVenda.Controls.Add(this.cbContaCorrente);
            this.tpPedidoVenda.Controls.Add(this.cbCategoria);
            this.tpPedidoVenda.Controls.Add(this.label3);
            this.tpPedidoVenda.Controls.Add(this.label2);
            this.tpPedidoVenda.Location = new System.Drawing.Point(4, 25);
            this.tpPedidoVenda.Name = "tpPedidoVenda";
            this.tpPedidoVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedidoVenda.Size = new System.Drawing.Size(538, 227);
            this.tpPedidoVenda.TabIndex = 1;
            this.tpPedidoVenda.Text = "Pedido de Vendas";
            this.tpPedidoVenda.UseVisualStyleBackColor = true;
            // 
            // cbContaCorrente
            // 
            this.cbContaCorrente.FormattingEnabled = true;
            this.cbContaCorrente.Location = new System.Drawing.Point(10, 88);
            this.cbContaCorrente.Name = "cbContaCorrente";
            this.cbContaCorrente.Size = new System.Drawing.Size(351, 24);
            this.cbContaCorrente.TabIndex = 3;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(10, 30);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(351, 24);
            this.cbCategoria.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Conta Corrente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria";
            // 
            // tpIntegracao
            // 
            this.tpIntegracao.Controls.Add(this.txtAppSecret);
            this.tpIntegracao.Controls.Add(this.txtAppKey);
            this.tpIntegracao.Controls.Add(this.label5);
            this.tpIntegracao.Controls.Add(this.label4);
            this.tpIntegracao.Location = new System.Drawing.Point(4, 25);
            this.tpIntegracao.Name = "tpIntegracao";
            this.tpIntegracao.Padding = new System.Windows.Forms.Padding(3);
            this.tpIntegracao.Size = new System.Drawing.Size(538, 227);
            this.tpIntegracao.TabIndex = 2;
            this.tpIntegracao.Text = "Integração Omie";
            this.tpIntegracao.UseVisualStyleBackColor = true;
            // 
            // txtAppSecret
            // 
            this.txtAppSecret.Location = new System.Drawing.Point(9, 83);
            this.txtAppSecret.Name = "txtAppSecret";
            this.txtAppSecret.Size = new System.Drawing.Size(311, 23);
            this.txtAppSecret.TabIndex = 3;
            // 
            // txtAppKey
            // 
            this.txtAppKey.Location = new System.Drawing.Point(9, 33);
            this.txtAppKey.Name = "txtAppKey";
            this.txtAppKey.Size = new System.Drawing.Size(163, 23);
            this.txtAppKey.TabIndex = 2;
            this.txtAppKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "App Secret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "App Key";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnSalvar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(115, 258);
            this.pnlBotoes.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Image = global::prjbase.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(3, 40);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Image = global::prjbase.Properties.Resources.salvar;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalvar.Location = new System.Drawing.Point(3, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(109, 33);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Código da Empresa";
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(10, 146);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(163, 23);
            this.txtCodigoEmpresa.TabIndex = 5;
            this.txtCodigoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNumber_KeyPress);
            // 
            // frmParametroSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(663, 258);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.pnlBotoes);
            this.Name = "frmParametroSistema";
            this.Text = "Parâmetros de Sistema ";
            this.Load += new System.EventHandler(this.frmParametroSistema_Load);
            this.pnlPrincipal.ResumeLayout(false);
            this.tcParametros.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.tpGeral.PerformLayout();
            this.tpPedidoVenda.ResumeLayout(false);
            this.tpPedidoVenda.PerformLayout();
            this.tpIntegracao.ResumeLayout(false);
            this.tpIntegracao.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pnlPrincipal;
        protected System.Windows.Forms.Panel pnlBotoes;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabControl tcParametros;
        private System.Windows.Forms.TabPage tpGeral;
        public System.Windows.Forms.Button btnCaminhoArquivos;
        private System.Windows.Forms.TextBox txtCaminhoArquivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkIntGenLab;
        private System.Windows.Forms.TabPage tpPedidoVenda;
        private System.Windows.Forms.TabPage tpIntegracao;
        private System.Windows.Forms.FolderBrowserDialog dlgCaminhoArquivos;
        private System.Windows.Forms.ComboBox cbContaCorrente;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAppSecret;
        private System.Windows.Forms.TextBox txtAppKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.Label label6;
    }
}
